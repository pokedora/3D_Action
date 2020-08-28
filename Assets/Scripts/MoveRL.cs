using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRL : MonoBehaviour
{
    private Vector3 objectpos;

    public float wide = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        objectpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクターが上に乗って移動
        this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, Mathf.Sin(Time.time) * wide);

        //キャラクターが乗らない
        //transform.position = new Vector3( objectpos.x, objectpos.y, Mathf.Sin(Time.time) * movearea + objectpos.z);
    }


}
