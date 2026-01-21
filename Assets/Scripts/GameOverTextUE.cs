using UnityEngine;

public class GameOverTextUE : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverText;

    public void ShowGameOver()
    {
        player.SetActive(false);
        gameOverText.SetActive(true);
    }
}
