using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI gameOverText, coinText, timeText;
    private int maxCoins = 5, coinCounter = 0, time = 0;
    private PlayerController[] playerControllers;
    public GameObject coinPrefab;
    Vector3 randomPosition;     

    void Start()
    {
        playerControllers = FindObjectsOfType<PlayerController>();
        foreach (PlayerController controller in playerControllers)
        {
            controller.enabled = false; 
        }

        randomPosition = new(Random.Range(-100, 100), 1, Random.Range(-100, 100));
        Debug.Log("maxCoins: " + maxCoins);
        gameOverText.gameObject.SetActive(false);
        coinText.SetText("Coins: " + coinCounter + "/" + maxCoins);
    }

    public void StartGame()
    {
        foreach (PlayerController controller in playerControllers)
        {
            controller.enabled = true;
        }

        StartCoroutine(Countdown());
        SpawnCoin();
    }

    IEnumerator Countdown()
    {
        while (time < 1000)
        {
            yield return new WaitForSeconds(1);
            time++;
            timeText.SetText(time.ToString());
        }
        GameOver(false);
    }

    public void CoinPickedUp()
    {
        coinCounter++;
        coinText.SetText("Coins: " + coinCounter + "/" + maxCoins);
        SpawnCoin();
        Debug.Log("Coins: " + coinCounter);
        if (coinCounter == maxCoins)
        {
            Debug.Log("You won!");
            GameOver(true);
        }
    }

    void SpawnCoin()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-30, 30), 1, Random.Range(-10, 190));
        Instantiate(coinPrefab, randomPosition, Quaternion.identity);
    }

    public void GameOver(bool isWin)
    {
        GameObject.FindObjectOfType<PlayerController>().enabled = false;
        gameOverText.gameObject.SetActive(true);
        if (!isWin)
        {
            gameOverText.SetText("Game Over");
        }
        Time.timeScale = 0;
    }
}
