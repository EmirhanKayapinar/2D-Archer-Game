using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanelControl : MonoBehaviour
{
    [SerializeField] GameObject _escPanel;
    public void OpenEscPanel()
    {
        _escPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseEscPanel()
    {
        _escPanel.SetActive(false);
        Time.timeScale = 1;

    }

    public void RestartOnClick()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void MainMenuOnClick()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitOnClick()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenEscPanel();
        }
        
    }
}
