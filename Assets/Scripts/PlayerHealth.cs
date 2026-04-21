using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public TMP_Text healthText;
    public GameObject deathScreen;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();
        deathScreen.SetActive(false);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth < 0)
            currentHealth = 0;

        UpdateUI();

        if (currentHealth == 0)
        {
            Die();
        }
    }

    void UpdateUI()
    {
        healthText.text = "Health: " + currentHealth + "/100";
    }

    void Die()
    {
        deathScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Respawn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}