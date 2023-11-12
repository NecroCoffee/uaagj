using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytit2 : MonoBehaviour
{
    public GameObject efe;
    GameObject en;
    float delta = 0;
    void Start()
    {
       this.en = GameObject.Find("enemy2");
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        Transform myTransform = this.transform;
        Vector3 worldPos = myTransform.position;
   
        if( worldPos.x < -2.25)
        {
            transform.Translate(0.005f, 0, 0);
        }
        if(this.delta > 5.98f && this.delta < 5.99f)
        {
            GameObject go = Instantiate(efe);
        }
        if(this.delta > 6.3f)
        {
            Destroy(en);
        }
    }
}
