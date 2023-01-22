using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using Assets;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private FixedJoystick _joystick;
    

    
    private Animator _animator;

    [SerializeField]
    private float _moveSpeed = .4f;

   
    public float _collectivecount = 0;

  
    private Rigidbody ribody;


 


  

    void Start()
    {
        ribody = GetComponentInChildren<Rigidbody>();
       
   
       
    }

   
    private void FixedUpdate()
    {
        Vector3 vec = Vector3.zero;

        vec = new Vector3(_joystick.Horizontal * _moveSpeed, 0, _joystick.Vertical * _moveSpeed);
        ribody.velocity += vec;

        Vector3 direction = (Vector3.right* _joystick.Horizontal + Vector3.forward * _joystick.Vertical);
        transform.rotation = Quaternion.LookRotation(direction);



    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Collection")
        {
            Debug.Log("Tetiklenme gerçekleþti Ben Oyuncuyum.");
            _collectivecount++;
            Debug.Log(_collectivecount);
        }

       

       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "UnlockArea")
        {
            
            if (_collectivecount > 0)
                _collectivecount--;
        }
    }
}
