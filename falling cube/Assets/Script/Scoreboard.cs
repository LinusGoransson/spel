using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System;
using LitJson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour {

    const string privateCode = "xhUQj5MSQUGj_7-2lfwazgORP4qiIuEUCZOz59JoysIA";
    const string publicCode = "589b113e68fc111e806eec29";
    const string webURL = "http://dreamlo.com/lb/";
    private JsonData itemData;
    public Text firstPlayer, secoundPlayer, firstPlayerScore, secoundPlayerScore, thirdPlayer, thirdPlayerScore, fourthPlayer, fourthPlayerScore, fithPlayer, fithPlayerScore;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    void Awake()
    {
        string url = @webURL + publicCode + "/json/5";
        var json = new WebClient().DownloadString(url);
       
        itemData = JsonMapper.ToObject(json);
        firstPlayer.text = itemData["dreamlo"]["leaderboard"]["entry"][0]["name"].ToString();
        firstPlayerScore.text = itemData["dreamlo"]["leaderboard"]["entry"][0]["score"].ToString();
        secoundPlayer.text = itemData["dreamlo"]["leaderboard"]["entry"][1]["name"].ToString();
        secoundPlayerScore.text = itemData["dreamlo"]["leaderboard"]["entry"][1]["score"].ToString();
        thirdPlayer.text = itemData["dreamlo"]["leaderboard"]["entry"][2]["name"].ToString();
        thirdPlayerScore.text = itemData["dreamlo"]["leaderboard"]["entry"][2]["score"].ToString();
        fourthPlayer.text = itemData["dreamlo"]["leaderboard"]["entry"][3]["name"].ToString();
        fourthPlayerScore.text = itemData["dreamlo"]["leaderboard"]["entry"][3]["score"].ToString();
        fithPlayer.text = itemData["dreamlo"]["leaderboard"]["entry"][4]["name"].ToString();
        fithPlayerScore.text = itemData["dreamlo"]["leaderboard"]["entry"][4]["score"].ToString();
    }
}
