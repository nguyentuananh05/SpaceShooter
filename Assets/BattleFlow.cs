using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameplay;

    public GameObject gameOverUI;
    public GameObject gameWinUI;

    public PlayerHealth playerHealth;

    void Start()
    {
        gameplay.SetActive(false);
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);

        playerHealth.onDead += OnGameOver;
    }

    public void StartGame()
    {
        mainMenu.SetActive(false);
        gameplay.SetActive(true);
    }

    void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    void OnGameOver()
    {
        gameOverUI.SetActive(true);
    }

    void OnGameWin()
    {
        gameWinUI.SetActive(true);
    }
}