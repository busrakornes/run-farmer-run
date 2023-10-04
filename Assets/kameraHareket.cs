using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraHareket : MonoBehaviour
{
    public GameObject gamer;
    public Vector3 offset= new Vector3(-4f, 13f, 10f);   

     void Update()
      {
         transform.position = gamer.transform.position + offset;
      }
    
   
}
