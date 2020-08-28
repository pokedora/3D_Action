using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTU : MonoBehaviour
{
    private Vector3 objectpos;

    public float wide = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        objectpos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクターが上に乗って移動
        this.GetComponent<Rigidbody>().velocity = new Vector3(0f, Mathf.Sin(Time.time) * wide, 0f);

        //this.GetComponent<Rigidbody>().AddForce(new Vector3(0f,Mathf.Sin(Time.time) * wide, 0f));

        //キャラクターが乗らない
        //transform.position = new Vector3( objectpos.x, Mathf.Sin(Time.time) * wide, objectpos.z);
    }
}
