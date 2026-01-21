using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject gameOverText;

    void OnEnable()
    {
        playerHealth.OnDeath += OnGameOver;
    }

    void OnDisable()
    {
        playerHealth.OnDeath -= OnGameOver;
    }

    void OnGameOver()
    {
        gameOverText.SetActive(true);
        Debug.Log("Hello world");
    }
}