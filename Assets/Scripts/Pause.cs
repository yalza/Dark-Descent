using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool toggle;
    public SC_FPSController player;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            toggle= !toggle;
            if(!toggle)
            {
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
                player.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                player.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    public void ResumeGame()
    {
        toggle = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        player.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void QuiT2Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Settings(GameObject settingPanel) {
        settingPanel.SetActive(true);
        pauseMenu.SetActive(false);
    }
}
