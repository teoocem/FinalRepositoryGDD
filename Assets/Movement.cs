using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    private Rigidbody rigBody;

    [SerializeField]
    private FixedJoystick _joystick;

    [SerializeField]
    private float _moveSpeed = .7f;

    [SerializeField]
    private float capacity = 5;


    public int _collectivecount = 0;
    void Start()
    {
        rigBody = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        Vector3 vec = Vector3.zero;
        vec = new Vector3(_joystick.Horizontal * _moveSpeed, 0, _joystick.Vertical * _moveSpeed);
        rigBody.velocity += vec;

        Vector3 direction = (Vector3.right * _joystick.Horizontal + Vector3.forward * _joystick.Vertical);
        transform.rotation = Quaternion.LookRotation(direction);
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Collection")
        {
            Debug.Log("Tetiklenme gerçekleþti " + gameObject.name);

            if (capacity > Collection.getCollection().current_count)
            {
                Collection.getCollection().sum_count++;
                Collection.getCollection().current_count++;
                Destroy(other.transform.parent.gameObject);
                Debug.Log(_collectivecount);
            }
            
         
        }

    }
   


}
