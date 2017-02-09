using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiende4 : MonoBehaviour {

    //Hastighet på fiende
    float speed = 7;
    //spelplanens synliga höjd
    float visibleHeight;
    // Use this for initialization
    void Start()
    {
        //sätter den synliga höjden
        visibleHeight = -Camera.main.orthographicSize - transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Rörelse på fienden (faller ner)
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        //ifall fienderna faller under spel höjden så förstörs dom istället för att fortsätta falla. 
        if (transform.position.y < visibleHeight)
        {
            Destroy(gameObject);
        }
    }
}
