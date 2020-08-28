using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            Destroy(other.gameObject, 0.1f);
        }



        //private int frame = 0;
        //private float time = 0.0f;

        ////対象のオブジェクト
        //public GameObject desObj;
        //private bool isRespon = false;
        //private Vector3 initPos;
        //private Vector3 firstPos;

        //// Use this for initialization 
        //void Start()
        //{
        //    //初期値設定 
        //    this.initPos = Vector3.zero;
        //}
        //// Update is called once per frame 
        //void Update()
        //{
        //    if (isRespon)
        //    {
        //        time += Time.deltaTime;
        //        if (time >= 3.0f)
        //        {
        //            time = 0.0f;
        //            isRespon = false;
        //            this.desObj.SetActive(true);
        //            this.desObj.transform.position = firstPos;
        //        }
        //    }
        //}
        //void OnCollisionEnter2D(Collision2D coll)
        //{
        //    if (coll.gameObject.tag == "Player")
        //    {
        //        this.desObj.SetActive(false);
        //        isRespon = true;
        //        //または
        //        //coll.gameObject.SetActive(false);
        //    }
        //}
    }
}
