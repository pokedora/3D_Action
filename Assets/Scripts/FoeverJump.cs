using System.Collections.Generic;
using UnityEngine;

public class ForeverJump : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody PlayerRigid;//PlayerオブジェクトのRigidbobyを保管する
    public float Upspeed;　　　　//ジャンプのスピード

    int count = 1;
    bool spaceKeyDown = false;


    // Use this for initialization
    void Start()
    {
        PlayerRigid = Player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        spaceKeyDown = true;
    }

    private void FixedUpdate()
    {
        Animator anime = GetComponent<Animator>();

        if (spaceKeyDown && count != 0)
        {
            anime.SetBool("JumpFlag", true);

            //上にジャンプする。
            PlayerRigid.AddForce(transform.up * Upspeed);
            count -= 1;
        }
        else
            anime.SetBool("JumpFlag", false);

    }

    private void OnCollisionEnter(Collision collision)
    {
        count = 1;
    }
}