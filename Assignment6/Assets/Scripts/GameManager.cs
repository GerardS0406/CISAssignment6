/*
 * Gerard Lamoureux
 * GameManager
 * Assignment 6
 * Handles the Internal Game Systems
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int baseHealth = 500;

    public static GameManager gameManager;

    public int playerDamage = 20;

    public bool gameOver = false;

    public int PlayerScore = 0;

    public int GameWave = 1;

    public GameObject gameOverPanel;

    public TextMeshProUGUI healthText;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        gameManager = this;
        Time.timeScale = 0;
    }

    private void Update()
    {
        healthText.text = "Base Health: " + baseHealth;
        scoreText.text = "Wave: " + GameWave;
    }

    public void TakeDamage(int amount)
    {
        baseHealth -= amount;
        if (baseHealth <= 0 && !gameOver)
        {
            baseHealth = 0;
            GameIsOver(false);
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void GameIsOver(bool win)
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        if(win)
            gameOverPanel.transform.Find("GameOverText").GetComponent<TextMeshProUGUI>().text = "Game Over!\nYou Win!";
        else
            gameOverPanel.transform.Find("GameOverText").GetComponent<TextMeshProUGUI>().text = "Game Over!\nYou Lose!";
    }
}
