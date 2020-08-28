using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Camera : MonoBehaviour
{
    internal static Action<Camera> onPreRender;
    public Transform verRot;
    public Transform horRot;
    internal int cullingMask;
    internal DepthTextureMode depthTextureMode;
    internal object targetTexture;
    internal static object current;
    internal object fieldOfView;
    internal bool layerCullSpherical;
    internal object layerCullDistances;
    internal object farClipPlane;
    internal Matrix4x4 worldToCameraMatrix;
    internal object projectionMatrix;
    internal object clearFlags;
    internal int pixelWidth;
    internal int pixelHeight;
    internal Color backgroundColor;
    internal object depth;
    internal object CompareTo;
    internal float nearClipPlane;
    internal object ransform;
    internal static object main;

    private GameObject player; //プレイヤー情報格納用
    private Vector3 offset; //相対距離取得用

    // Use this for initialization
    void Start()
    {
        
        verRot = transform.parent;
        horRot = GetComponent<Transform>();

        //unitychanの情報を取得
        //this.player = GameObject.Find("unitychan");

        //MainCamera(自分自身)とplayerとの相対距離を求める
        //offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        

        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotation, 0);
        horRot.transform.Rotate(-Y_Rotation, 0, 0);

        //新しいトランスフォームの値を代入
       // transform.position = player.transform.position + offset;

    }

    internal void AddCommandBuffer(CameraEvent afterGBuffer, CommandBuffer cb)
    {
        throw new NotImplementedException();
    }

    internal void RemoveCommandBuffer(CameraEvent afterGBuffer, CommandBuffer cb)
    {
        throw new NotImplementedException();
    }

    internal void Render()
    {
        throw new NotImplementedException();
    }
}