using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    private CharacterController characterController;
    private Vector3 velocity;
    private float totalFallTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        totalFallTime += Time.deltaTime;
        velocity.y = Physics.gravity.y * totalFallTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}
