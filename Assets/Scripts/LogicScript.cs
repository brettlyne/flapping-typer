using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public int highScore = 0;
    public Text scoreText;
    public Text highScoreText;

    public GameObject gameOverScreen;
    public GameObject titleScreen;
    public GameObject bird;
    public GameObject pipeSpawner;
    public AudioSource dingSound;
    public AudioSource buzzSound;

    public void Start()
    {
        scoreText.text = playerScore.ToString();
    }
    public void addScore(int n)
    {
        if (bird.GetComponent<BirdScript>().birdIsAlive)
        {
            playerScore += n;
            if (playerScore > highScore)
            {
                highScore = playerScore;
                highScoreText.text = highScore.ToString();
            }
            scoreText.text = playerScore.ToString();
            if (n > 0)
            {
                dingSound.Play();
            }
            else
            {
                buzzSound.Play();
            }

        }
    }

    public void startGame()
    {
        titleScreen.SetActive(false);
        bird.SetActive(true);
        pipeSpawner.SetActive(true);
        restartGame();
    }
    public void restartGame()
    {
        bird.GetComponent<BirdScript>().birdIsAlive = true;
        bird.transform.position = new Vector3(-6, 0, 0);
        bird.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        bird.GetComponent<Rigidbody2D>().angularVelocity = 0;
        bird.transform.rotation = Quaternion.Euler(0, 0, -21);
        GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");
        foreach (GameObject pipe in pipes)
        {
            Destroy(pipe);
        }
        playerScore = 0;
        scoreText.text = playerScore.ToString();
        gameOverScreen.SetActive(false);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
