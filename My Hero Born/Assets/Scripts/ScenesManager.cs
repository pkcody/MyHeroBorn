using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void EndGame()
    {
        SceneManager.LoadScene(2);
    //    lostWin.text = "You Won!";
    //    lostWin.text = "You Lost!";
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
