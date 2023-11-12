using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbox : MonoBehaviour
{
    float delta = 0;
    GameObject sp;
    void Start()
    {
       this.sp = GameObject.Find("Cube");
    }

    void Update()
    {
    this.delta += Time.deltaTime;
    Transform myTransform = this.transform;
    Vector3 worldPos = myTransform.position;
   
        if( worldPos.x > 2.5)
        {
            transform.Translate(-0.005f, 0, 0);
        }
        if(delta > 6.6f)
        {
            transform.Translate(-0.009f, 0, 0);
        }
    }
}
