using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meny : MonoBehaviour {
    public static string ingameName;

    //Funktion som byter scene till spelet
    public void LoadGame(string SceneName){
        SceneManager.LoadScene(SceneName);
    }

    //Funktion som byter scene till scoreboard
    public void LoadScoreboard(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    //Funktion som stänger ner spelet
    public void ExitGame(){
        Application.Quit();
    }

    //Ta värdet från namn input i menyn
    public void GetInput(string name)
    {
        ingameName = name;
        Debug.Log("namn:" + ingameName);

    }
}
