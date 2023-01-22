using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Assets;

public class ToplananMaterial : MonoBehaviour
{

    public Movement player;


    private TextMeshProUGUI textmesh;


    private void Start()
    {
        textmesh = GetComponentInChildren<TextMeshProUGUI>();
    }
   
    private void Update()
    {
        textmesh.SetText("-Toplanan Material- {0}" , Collection.getCollection().current_count);
    }
}
