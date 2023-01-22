using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Rigidbody rigidBody;

    [SerializeField]
    private FixedJoystick joystick;

    [SerializeField]
    private int capacity = 0;


    [SerializeField]
    private float moveSpeed = 2.0f;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 positionVector = Vector3.zero;
        positionVector = new Vector3(moveSpeed * joystick.Horizontal, 0, moveSpeed * joystick.Vertical);
        rigidBody.velocity += positionVector; 

        rigidBody.rotation = Quaternion.LookRotation(positionVector);
    }
}
