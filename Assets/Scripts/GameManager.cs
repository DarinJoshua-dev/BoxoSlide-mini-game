using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GamehasEnded = false;
    public float Restartdelay = 2.6f;
    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void Endgame()
    {
        if (GamehasEnded == false)
        {
            GamehasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", Restartdelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
