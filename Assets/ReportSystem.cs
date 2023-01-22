using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Assets;


 
public class ReportSystem : MonoBehaviour
{
    [SerializeField]
    private bool isUnLocked = false;
   
    

    private Camera followCamera;

    [SerializeField]
    private int requiredMaterial = 0;

    [SerializeField]
    private GameObject vehicle;

    private bool isPressed = false;

 

        
       
    
       
  
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "PlayerCharacter")
        {
            if (requiredMaterial > Collection.getCollection().current_count)
            {
                requiredMaterial -= Collection.getCollection().current_count;
                Collection.getCollection().current_count = 0;
                Debug.Log(requiredMaterial);
            }
            else
            {
                isUnLocked = true;
                other.gameObject.SetActive(false);
                vehicle.SetActive(true);
            }
        }
    }



}
