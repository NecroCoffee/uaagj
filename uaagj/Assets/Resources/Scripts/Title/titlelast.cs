using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlelast : MonoBehaviour
{
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(delta > 11.0f && delta < 20.0f)
        {
            transform.Translate(-0.015f, 0, 0);
        }
    }
}
