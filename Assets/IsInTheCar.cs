using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsInTheCar : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private bool isinthecar = false;
    private void Update()
    {
        if (!player.gameObject.activeInHierarchy) isinthecar = true;

        if(Input.GetKeyDown(KeyCode.F) && isinthecar)
        {
            gameObject.GetComponent<Movement>().enabled = false;
            Debug.Log("Emredersin sahip");
            player.transform.position = transform.position;
            player.gameObject.SetActive(true);
            isinthecar = false;
        }
    }
}
