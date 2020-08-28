using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{

    static int i = 0;
    static int reScene;

    public static void SceneSet()
    {
        i = SceneManager.GetActiveScene().buildIndex;
    }

    public void Replay()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }

    public void NextScene()
    {
        reScene = i++;
        SceneManager.LoadScene(i); //次のステージへ進む
    }

    public void Retry()
    {
        SceneManager.LoadScene(reScene);
    }

    public void SetTitle()
    {
        SceneManager.LoadScene("Start");
    }
}
