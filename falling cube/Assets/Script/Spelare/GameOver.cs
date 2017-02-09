using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {

    public GameObject gameOverScreen;
    
    public Text score;
    public Text scoreIngame;
    public Text username;
    //en boolean som håller reda på ifall man har dött eller inte. 
    bool gameOver;

    const string privateCode = "xhUQj5MSQUGj_7-2lfwazgORP4qiIuEUCZOz59JoysIA";
    const string publicCode = "589b113e68fc111e806eec29";
    const string webURL = "http://dreamlo.com/lb/";

    //skapar en add request url till dreamlo.com där username och score sparas.
    public void AddHighscore(string username, int score){
        StartCoroutine(PostHighscore(username, score));
    }
    IEnumerator PostHighscore(string username, int score){
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score);
        yield return www;
    }

    // Update is called once per frame
    void Update () {
        //sätter score så att det är lika med hur många sekunder spelaren överlevde ifall spelet inte är över. När spelet är över så tar den bort poängräknaren. 
        if (gameOver == false)
        {
            scoreIngame.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        }else{
            Destroy(scoreIngame);
        }
        
        //ifall gameOver är true och enter trycks så byter man tillbaka till scenen och spelet börjas om
        if (gameOver){
            if (Input.GetKeyDown(KeyCode.Space)){
                SceneManager.LoadScene(1);
            }
        }
        //ifall gameOver är true och esc trycks så byter man till meny scenen
        if (gameOver){
            if (Input.GetKeyDown(KeyCode.Escape)){
                SceneManager.LoadScene(0);
            }
        }
    }
    //funktion som kallas på när spelaren dör
    public void OnGameOver(){
        //sätter gameOverScreen till activ så den syns
        gameOverScreen.SetActive(true);
        //sätter score så att det är lika med hur många sekunder spelaren överlevde
        score.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        //sätter till true så att if satsen då man klickar enter kan kallas.
        username.text = Meny.ingameName;
        AddHighscore(Meny.ingameName, Mathf.RoundToInt(Time.timeSinceLevelLoad));
        gameOver = true;
    }
}
