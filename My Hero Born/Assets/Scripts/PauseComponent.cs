using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class PauseComponent : MonoBehaviour
{
    [SerializeField]

    GameObject pauseScreen;

    public ScenesManager sceneManager;

    void Awake()
    {
        pauseScreen.SetActive(false);
        SetPauseButtoneActive(false);
        Invoke("delayPauseAppear", 5);
    }

    void delayPauseAppear()
    {
        SetPauseButtoneActive(true);
    }


    void SetPauseButtoneActive(bool switchButton)
    {
        ColorBlock col = GetComponentInChildren<Toggle>().colors;

        if (switchButton == false)
        {
            col.normalColor = new Color32(0, 0, 0, 0);
            col.highlightedColor = new Color32(0, 0, 0, 0);
            col.pressedColor = new Color32(0, 0, 0, 0);
            col.disabledColor = new Color32(0, 0, 0, 0);
            GetComponentInChildren<Toggle>().interactable = false;
        }
        else
        {
            col.normalColor = new Color32(245, 245, 245, 255);
            col.highlightedColor = new Color32(245, 245, 245, 255);
            col.pressedColor = new Color32(200, 200, 200, 255);
            col.disabledColor = new Color32(200, 200, 200, 128);
            GetComponentInChildren<Toggle>().interactable = true;
        }

        GetComponentInChildren<Toggle>().colors = col;
        GetComponentInChildren<Toggle>().transform.GetChild(0).gameObject.SetActive(switchButton);
    }

    public void PauseGame()
    {
        Debug.Log("poop");
        pauseScreen.SetActive(true);
        SetPauseButtoneActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseScreen.SetActive(false);
        SetPauseButtoneActive(true);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Time.timeScale = 1;
        sceneManager.BeginGame(0);
    }
}
