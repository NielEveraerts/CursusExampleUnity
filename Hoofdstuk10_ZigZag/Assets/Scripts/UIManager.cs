using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject zigZagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public Text score;
    public Text highScore1;
    public Text highScore2;

    public static UIManager instance;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart(){
        tapText.SetActive(false);
        zigZagPanel.GetComponent<Animator>().Play("PanelUp");
    }

    public void GameOver(){
        gameOverPanel.SetActive(true);
    }

    public void Restart(){
        SceneManager.LoadScene(0);
    }
}
