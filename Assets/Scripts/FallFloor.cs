using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{
    //床が落下するまでの時間
    [SerializeField]
    private float timeToFall = 5f;
    //主人公が床に乗っていたトータル時間
    private float totalTime = 0f;
    private Rigidbody rigid;

    Vector3 startposition; 

    // Start is called before the first frame update
    void Start()
    {
        startposition = transform.position;
        rigid = GetComponent<Rigidbody>();
        rigid.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        //床が落下する時間を超えたらリジッドボディのisKinematicをfalseに
        //isKinematicをfalseにしたことで重力が働く
        if (totalTime >= timeToFall)
        {
            rigid.isKinematic = false;
        }
    }

    //主人公が床に乗っているときに呼び出す
    public void ReceiveForce()
    {
        //床に乗っている時間を足してく
        totalTime += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Plane")
        {
            transform.position = startposition;
            totalTime = 0f;
            rigid.isKinematic = true;
            
        }
    }

    

}
