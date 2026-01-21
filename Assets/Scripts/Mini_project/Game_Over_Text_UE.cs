using UnityEngine;

public class Game_Over_Text_UE : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverText;

    public void ShowGameOver()
    {
        player.SetActive(false);
        gameOverText.SetActive(true);
    }
}
