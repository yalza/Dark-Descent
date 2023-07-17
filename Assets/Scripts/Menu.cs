using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string sceneName;

    public GameObject settingsPanel, menuPanel,controlsPanel;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

    public void ContinueGame()
    {
        if(PlayerPrefs.GetInt("level") == 0|| PlayerPrefs.GetInt("level") == 1)
        {
            PlayGame();
        }
        else
        {
            SceneManager.LoadScene("Level" + PlayerPrefs.GetInt("level").ToString());
        }

        

    }

    public virtual void QuitGame()
    {
        #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
                Debug.Log(this.name + " : " + this.GetType() + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
        #endif
        #if (UNITY_EDITOR)
                UnityEditor.EditorApplication.isPlaying = false;
        #elif (UNITY_STANDALONE)
                            Application.Quit();
        #elif (UNITY_WEBGL)
                            SceneManager.LoadScene("QuitScene");
        #endif
    }

    public void Settings()
    {
        menuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void Controls()
    {
        menuPanel.SetActive(false);
        controlsPanel.SetActive(true);

    }

    public void Back2Menu()
    {
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        controlsPanel.SetActive(false);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}


