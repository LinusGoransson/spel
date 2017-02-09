using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontroller : MonoBehaviour {

    //Hastigheten på spelaren
    public float speed = 8;
    //Variabel för längden på halva skärmen 
    float screenHalf;

    // Use this for initialization
    void Start()
    {
        //räknar ut storleken på fönstret så att slutet av mappen alltid kommer vara i kanterna'
        float halfPlayer = transform.localScale.x / 2f;
        screenHalf = Camera.main.aspect * Camera.main.orthographicSize - halfPlayer;

    }

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxisRaw("Horizontal");
        float velocity = inputX * speed;
        transform.Translate(Vector2.right * velocity * Time.deltaTime);

        //Gör så att spelaren inte kan röra sig utanför spelfönstret. 
        if(transform.position.x < - screenHalf){
            transform.position = new Vector2 (-screenHalf, transform.position.y);
        }
        if (transform.position.x > screenHalf)
        {
            transform.position = new Vector2(screenHalf, transform.position.y);
        }

    }
    //Funktion för ifall spelaren kolliderar med fiender.
    void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if(triggerCollider.tag == "Fiende")
        {
            FindObjectOfType<GameOver> ().OnGameOver();
            Destroy (gameObject);
        }
    }
}
