using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject nextSceneButton;
    //static int i = 0;
    //static int sceneIndex;
    public GameObject PlayerPrefab;
    public int life;

    private GameObject Goal;
    private GoalController GoalScript;
    private Text textLife;

    private bool inGame;

    Image image_component;


    private void Start()
    {
        Invoke("DelayMethod", 3f);
        life = 3;
        Time.timeScale = 1f;
        nextSceneButton.SetActive(false);
        Goal = GameObject.FindGameObjectWithTag("Goal");
        GoalScript = Goal.GetComponent<GoalController>();
        textLife = GameObject.Find("Life").GetComponent<Text>();
        SetLifeText(life);
        //今いるシーンをセット
        MoveScene.SceneSet();
        inGame = true;

        GameObject image_object = GameObject.Find("GameOver");

        image_component = image_object.GetComponent<Image>();
        image_component.enabled = false;

    }



    private void Update()
    {
        
        if (inGame)
        {
            



            GameObject playerObj = GameObject.Find("unitychan");
            

            if (playerObj == null)
            {
                --life;
                SetLifeText(life);
                if (life > 0)
                {
                    GameObject newPlayer = Instantiate(PlayerPrefab);
                    newPlayer.name = PlayerPrefab.name;
                    //シーン読み込み
                    //SceneManager.LoadScene(i);
                }
                else
                {

                    SceneManager.LoadScene("GameOver");
                    inGame = false;
                }

            }

            //bool ClearFlag=GoalScript.GameClearFlag;



            if (GoalScript.GameClearFlag)
            {
                nextSceneButton.SetActive(true);
                Time.timeScale = 0f;
            }


        }
    }


    

    private void SetLifeText(int life)
    {
        textLife.text = "Life:" + life.ToString();
        
    }

   
}
