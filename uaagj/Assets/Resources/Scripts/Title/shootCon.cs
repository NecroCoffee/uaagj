using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootCon : MonoBehaviour
{
    public GameObject Bul;
    GameObject shoot;
    void Start()
    {
       this.shoot = GameObject.Find("Sphere");
    }

    void Update()
    {
    Transform myTransform = this.transform;
    Vector3 worldPos = myTransform.position;
   
        if( worldPos.x > -1.3)
        {
            transform.Translate(-0.02f, 0, 0);
        }else{
            Destroy(Bul);
        }
    }
}