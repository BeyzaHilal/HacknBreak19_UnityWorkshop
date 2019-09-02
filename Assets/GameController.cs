using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    public bool isGameOver = false;
    
    public int Score;
    private int asteroidPoint = 10;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if( instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

 

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0.0f;
    }

    public void Restart()
    {
        Score = 0;
        isGameOver = false;
        Time.timeScale = 1.0f;
    }

    public void IncreaseScore()
    {
        Score += asteroidPoint;   //Score = Score + asteroidPoint;
    }

}
