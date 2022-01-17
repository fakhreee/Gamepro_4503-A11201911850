using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // public static ScoreManager instance;
    public Text ScoreText, HighscoreText; 
    public float score, highscore;    

    // Update is called once per frame

    void Start(){
        highscore = PlayerPrefs.GetInt("highscore", 0);
        HighscoreText.text = "Highscore: "+highscore.ToString();
    }
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")!= null)
        {
            score += 1 * Time.deltaTime;

            UpdateHighScore();
            
            ScoreText.text = "Score: "+((int)score).ToString();
            // GameOverScoreText.text - ((int)score).ToString();
        }        
    }

    public void UpdateHighScore()
    {
        if(score > highscore )
        {
            PlayerPrefs.SetInt("highscore", (int)score);
        }
    }

    public void ClearHighscore()
    {
        PlayerPrefs.DeleteKey("highscore");

        highscore =0;
        HighscoreText.text = "Highscore: "+highscore.ToString();
    }
}
