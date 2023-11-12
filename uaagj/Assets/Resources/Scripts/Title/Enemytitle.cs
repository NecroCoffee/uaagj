using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytitle : MonoBehaviour
{
    public GameObject efe;
    GameObject en;
    float delta = 0;
    void Start()
    {
       this.en = GameObject.Find("enemy");
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        Transform myTransform = this.transform;
        Vector3 worldPos = myTransform.position;
   
        if( worldPos.x < -1.55)
        {
            transform.Translate(0.005f, 0, 0);
        }
        if(this.delta > 5.96f && this.delta < 5.97f)
        {
            GameObject go = Instantiate(efe);
        }
        if(this.delta > 6.1f)
        {
            Destroy(en);
        }
    }
}
