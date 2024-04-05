using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadAdditionGame(string name)
    {
        GameSettings.Instance.SetGameMode(GameSettings.EGameMode.ADD);
        SceneManager.LoadScene(name);
    }
    public void LoadSubtractionGame(string name)
    {
        GameSettings.Instance.SetGameMode(GameSettings.EGameMode.SUB);
        SceneManager.LoadScene(name);
    }
    public void LoadMultiplicationGame(string name)
    {
        GameSettings.Instance.SetGameMode(GameSettings.EGameMode.MUL);
        SceneManager.LoadScene(name);
    }
    public void LoadDivisionGame(string name)
    {
        GameSettings.Instance.SetGameMode(GameSettings.EGameMode.DIV);
        SceneManager.LoadScene(name);
    }
    public void ActivateObject(GameObject obj)
    {
        obj.SetActive(true);

    }
    public void DeActivateObject(GameObject obj)
    {
        obj.SetActive(false);

    }

    public void SetPaused(bool paused)
    {
        GameSettings.Instance.SetPaused(paused);
    }
}
