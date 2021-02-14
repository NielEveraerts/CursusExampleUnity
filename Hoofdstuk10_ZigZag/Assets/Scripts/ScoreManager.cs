using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int highScore;
    public static ScoreManager instance;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("score",score);  //hiermee sla je de score op op je pc of gsm,...
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IncrementScore(){
        score++;
    }

    public void startScore(){
        InvokeRepeating("IncrementScore",0.1f,0.5f);
    }
    public void stopScore(){
        CancelInvoke("IncrementScore");
        PlayerPrefs.SetInt("score",score);                  //hiermee sla je de score op op je pc of gsm
        if(PlayerPrefs.HasKey("highscore")){                //check of er al een highscore is
            if(score > PlayerPrefs.GetInt("highScore")){    //check ofdat nieuwe score meer is dan oude highscore
                PlayerPrefs.SetInt("highScore", highScore); 
            }
        }
        else{
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }
}

