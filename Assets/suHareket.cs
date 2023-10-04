using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suHareket : MonoBehaviour
{
    public float akisHiz = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left* akisHiz * Time.deltaTime);
        /* if(transform.position.z>=100)
         {
             transform.position = new Vector3(0f, 1.5f);
         }   */
        if (transform.position.x <= -40) transform.position += new Vector3(165f, 0, 0);  //170   //-50

        //belki //-40 //180

        //-40 160 iyi gibi videosu var


    }
}
