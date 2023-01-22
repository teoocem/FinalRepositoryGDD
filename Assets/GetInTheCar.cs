using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInTheCar : MonoBehaviour
{
    [SerializeField]
    private Transform carTransform;

    private bool isPressed = false;

    private bool isInthecar = false;
 
    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.F)) isPressed = true;
        gameObject.transform.position = carTransform.position; 
        
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "PlayerCharacter")
        {
            if (isPressed)
            {
                if(!isInthecar)
                {
                    other.gameObject.SetActive(false);
                    GameObject.FindObjectOfType<Movement>().enabled = true;
                    Debug.Log(GameObject.FindObjectOfType<Movement>().gameObject.name);
                    isInthecar = true;
                    isPressed = false;
                }
                else
                {
                    other.gameObject.SetActive(true);
                    other.gameObject.transform.position = carTransform.position;
                    GameObject.FindObjectOfType<Movement>().enabled = false;
                    isInthecar = false;
                    isPressed = false;
                }
              
            }
            else
            {
                Debug.Log("Trigger oldu.");
            }
        }
    }
}
