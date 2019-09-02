using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject GameOverText;
    public Text ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        StartButton.SetActive(false);
        GameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + GameController.instance.Score;
                         
        if (GameController.instance.isGameOver)
        {
            StartButton.SetActive(true);
            GameOverText.SetActive(true);
        }
        else
        {
            StartButton.SetActive(false);
            GameOverText.SetActive(false);
        }
    }

    public void PressedStartButton()
    {
        SceneManager.LoadScene("Level1");
        GameController.instance.Restart();
    }
}
