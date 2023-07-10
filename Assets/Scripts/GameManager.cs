using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool isGameEnded = false;
    
    public GameObject gameOverUI;
    public GameObject levelCompletedUI;
    
    public void EndGame() {
        if (isGameEnded == false) {
            // Debug.Log("Game Over!");
            GameOver();
            isGameEnded = true;
        }
    }

    public void LevelCompleted() {
        levelCompletedUI.SetActive(true);
    }

    void GameOver() {
        var score = GameObject.Find("Canvas").transform.Find("Score").GetComponent<Text>();
        var yourScore = gameOverUI.transform.Find("TextScore").GetComponent<Text>();

        yourScore.text = "YOUR SCORE: " + score.text;
        gameOverUI.SetActive(true);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update() {
        if (isGameEnded) {
            if (Input.GetKey("space")) {
                Restart();
            };
        }
    }
}
