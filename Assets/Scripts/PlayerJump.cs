using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody PlayerRigid;//PlayerオブジェクトのRigidbobyを保管する
    public float Upspeed;　　　　//ジャンプのスピード

    private bool isJumping = false;

    private AnimatorStateInfo currentBaseState;

    static int idleState = Animator.StringToHash("Base Layer.Idle");
    static int jumpState = Animator.StringToHash("Base Layer.Jump");
    static int waitjumpState = Animator.StringToHash("Base Layer.Wait_Jump_Flag");

    Animator anime;
    // Use this for initialization
    void Start()
    {
        PlayerRigid = Player.GetComponent<Rigidbody>();
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        currentBaseState = anime.GetCurrentAnimatorStateInfo(0);	// 参照用のステート変数にBase Layer (0)の現在のステートを設定する

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (isJumping == false && currentBaseState.fullPathHash!=waitjumpState)
                {
                    isJumping = true;
                    anime.SetBool("JumpFlag", true);


                    //上にジャンプする。
                    PlayerRigid.AddForce(transform.up * Upspeed);
                    


                }
            
        }
        


    }

    
    void Finish()
    {
        anime.SetBool("JumpFlag", false);
        //isJumping = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
            anime.SetBool("JumpFlag", false);
        }
    }
}