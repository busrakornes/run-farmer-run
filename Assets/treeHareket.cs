using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeHareket : MonoBehaviour
{

    public bool don;
    public float donmeHiz;

    void Start()
    {
        
    }

    void Update()
    {
        if(don == true)
        {
            transform.Rotate(0, donmeHiz * Time.deltaTime, 0, Space.World);
        }
    }
}
