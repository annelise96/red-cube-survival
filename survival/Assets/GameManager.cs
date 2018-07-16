using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public GameObject gameOverUI;

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOver();
        }

    }

    public bool getGameHasEnded()
    {
        return gameHasEnded;
    }

    public void GameOver()
    {        
        gameOverUI.SetActive(true);
        
    }
}
