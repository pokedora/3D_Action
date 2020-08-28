using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoalController : MonoBehaviour
{

    //public GameObject GoalText;
    public bool GameClearFlag;

    Image image_component;

    // Start is called before the first frame update
    void Start()
    {
        GameObject image_object = GameObject.Find("Image");

        image_component = image_object.GetComponent<Image>();
        image_component.enabled=false;

        //GoalText.SetActive(false);
        GameClearFlag = false;
    }

    // Update is called once per frame
    //void Update()
    //{
       

    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            image_component.enabled = true;
           //GoalText.SetActive(true);
            GameClearFlag = true;
        }
    }

}
