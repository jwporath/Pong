using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Ball object
    public GameObject ball;

    // Player Paddle object
    public GameObject Player;

    // Scores
    private int PlayerScore;
    private int CPUScore;

    // ScoreBoard
    public GameObject PlayerScoreText;
    public GameObject CPUScoreText;

    // PauseMenu
    public GameObject PauseMenu;

    private bool DRBCMode;

    void Start()
    {
        // Pause game on startup
        Pause();
        DRBCMode = false;
    }

    void Update()
    {
        // Open/Close pause menu
        if(Input.GetKeyDown("escape"))
        {
            if(PauseMenu.activeInHierarchy) // Game is already paused
            {
                Resume();
            }
            else // Game is not already paused
            {
                Pause();
            }
        }

        // DRBC Mode
        if(Input.GetKeyDown("d"))
        {
            if(DRBCMode) // DRBCMode already enabled
            {
                Player.transform.localScale = new Vector3(0.26f, 2.5f, 1f);
                DRBCMode = false;
            }
            else // DRBCMode not already enabled
            {
                Player.transform.localScale = new Vector3(0.26f, 8.7f, 1f);
                Player.transform.position = new Vector3(-8.5f, 0, 0); // Reset to center positon to avoid clipping with Game Arena edge
                DRBCMode = true;
            }
        }

        // Quit game
        if(Input.GetKeyDown("q"))
        {
            Application.Quit();
        }
    }

    public void PlayerScored()
    {
        // Increment and display score
        PlayerScore++;
        PlayerScoreText.GetComponent<TextMeshProUGUI>().text = PlayerScore.ToString();
        
        // Reset Ball
        ResetBall();
    }
    public void CPUScored()
    {
        // Increment and display score
        CPUScore++;
        CPUScoreText.GetComponent<TextMeshProUGUI>().text = CPUScore.ToString();

        // Reset Ball
        ResetBall();
    }

    private void ResetBall()
    {
        ball.GetComponent<Ball>().ResetPos();
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
