using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerProgression : MonoBehaviour
{
    public int startHealth;
    private int currentHealth;
    public TextMeshProUGUI healthText;
    public int gameProgression;
    public int totalSoal;

    public GameObject winPanel, losePanel, flag;
    
    void Start()
    {
        Time.timeScale = 1.0f;
        currentHealth = startHealth;
        gameProgression = 0;

        winPanel.SetActive(false);
        losePanel.SetActive(false); 
    }

    void Update()
    {
        healthText.text = currentHealth.ToString();

        if (currentHealth <= 0 )
        {
            losePanel.SetActive(true);
        }

        if(gameProgression >= totalSoal )
        {
            flag.SetActive(true);
        }
    }

    public void JawabanBenar()
    {
        Time.timeScale = 1.0f;
        currentHealth += 1;
        gameProgression += 1;
    }

    public void JawabanSalah()
    {
        Time.timeScale = 1.0f;
        currentHealth -= 1;
        gameProgression += 1;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
