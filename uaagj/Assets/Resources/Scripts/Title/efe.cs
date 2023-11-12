using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efe : MonoBehaviour
{
    float delta = 0;
    public GameObject effe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(delta > 5.9f)
        {
             Destroy(effe);
        }
    }
}
