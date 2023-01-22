using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator controller;

    [SerializeField]
    private FixedJoystick joystick;

    private void Start()
    {
        controller = GetComponent<Animator>();
    }


    private void Update()
    {
     if(joystick.Horizontal != 0 ||  joystick.Vertical != 0)
        {
            controller.SetBool("isRunning", true);
        }
     else
        {
            controller.SetBool("isRunning", false);
        }
    }
}
