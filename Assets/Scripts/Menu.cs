using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string sceneName;

    public void PlayGame()
    {
        Debug.Log("aaa");
        SceneManager.LoadScene(sceneName);
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
}
