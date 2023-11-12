using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootGene : MonoBehaviour
{
    public GameObject SpherePrefab;
    float deldel =0;
    float span = 0.5f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        this.deldel += Time.deltaTime;
        if(this.deldel > 5.0f && this.deldel < 6.0f)
        {
            if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(SpherePrefab);
        }
        }
        
    }
}
