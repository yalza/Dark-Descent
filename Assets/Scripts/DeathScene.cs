using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
    public string sceneName;
    public float timeDelay;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(timeDelay);
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

}
