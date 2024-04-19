using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject bird;
    public AudioSource dingSound;

    public void Start()
    {
        scoreText.text = playerScore.ToString();
    }
    public void addScore() {
        if(bird.GetComponent<BirdScript>().birdIsAlive) {
            playerScore++;
            scoreText.text = playerScore.ToString();
            dingSound.Play();
        }
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playerScore = 0;
        scoreText.text = playerScore.ToString();
        gameOverScreen.SetActive(false);
    } 

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }   
}
