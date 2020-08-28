using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject ThirdCamera;      //メインカメラ格納用
    private GameObject FirstCamera;       //サブカメラ格納用 

    bool CameraFlag = false;

    //呼び出し時に実行される関数
    void Start()
    {
        //メインカメラとサブカメラをそれぞれ取得
        ThirdCamera = GameObject.Find("ThirdCamera");
        FirstCamera = GameObject.Find("FirstCamera");

        //サブカメラを非アクティブにする
        FirstCamera.SetActive(false);
    }


    //単位時間ごとに実行される関数
    void Update()
    {
        //Qキーを押すと一人称視点と三人称視点を変えられる
        if (Input.GetKeyDown(KeyCode.Q)){
            if (!CameraFlag)
            {
                CameraFlag = true;
            }
            else
            {
                CameraFlag = false;
            }
        }
        if (CameraFlag == true)
        {
                    //サブカメラをアクティブに設定
                    ThirdCamera.SetActive(false);
                    FirstCamera.SetActive(true);

        }
        else if(CameraFlag==false)
        {
            //メインカメラをアクティブに設定
            FirstCamera.SetActive(false);
            ThirdCamera.SetActive(true);
        }
    }
}
