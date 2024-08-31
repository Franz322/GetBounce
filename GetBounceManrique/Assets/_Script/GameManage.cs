using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public string sceneName;
    public GameObject ui;

    private void Start()
    {
        Time.timeScale = 1f;
        ui.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        ui.SetActive(true);

    }
    public void ContinueGame()
    {
        Time.timeScale = 1f;
        ui.SetActive(false);

    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName);
    }


    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void ExitMainGame()
    {
        SceneManager.LoadScene(sceneName);
    }


}