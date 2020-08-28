using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3.0f;

    // Use this for initialization
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

        Animator anime = GetComponent<Animator>();

        //if (Input.GetKey(KeyCode.W))
        //{

        //    transform.position += transform.forward * speed * Time.deltaTime;
        //    anime.SetBool("Run_F", true);
        //}
        //else
        //{
        //    anime.SetBool("Run_F", false);
        //}
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += transform.forward * speed * Time.deltaTime;
            anime.SetBool("Walk_F", true);
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {

                transform.position += transform.forward * 1.5f * Time.deltaTime;
                anime.SetBool("Run_F", true);
            }
            else
            {
                anime.SetBool("Run_F", false);
            }

        }
        else
        {
            anime.SetBool("Walk_F", false);
        }
        


        if (Input.GetKey(KeyCode.S))
        {

            transform.position -= transform.forward * speed * Time.deltaTime;
            anime.SetBool("Walk_B", true);
        }
        else
        {
            anime.SetBool("Walk_B", false);
        }

        //if (Input.GetKey(KeyCode.D))
        //{
            
        //    transform.position += transform.right * speed * Time.deltaTime;
        //    anime.SetBool("Run_R", true);
      
        //}
        //else
        //{
        //    anime.SetBool("Run_R", false);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{

        //    transform.position -= transform.right * speed * Time.deltaTime;
        //    anime.SetBool("Run_F", true);
        //}
        //else
        //{
        //    anime.SetBool("Run_F", false);
        //}

    }
}
  
