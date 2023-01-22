using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSpawn : MonoBehaviour
{

    [SerializeField]
    private GameObject material;

    public const int count = 200;


    private void Start()
    {
        
        for(int i = 0;i<count; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-190, 190), 3, Random.Range(-190, 190));
            Instantiate(material,randomPos, Quaternion.identity);
        }
        
    }


}
