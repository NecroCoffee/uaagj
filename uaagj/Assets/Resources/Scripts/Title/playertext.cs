using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertext : MonoBehaviour
{
    public GameObject bikuri;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > 3.9f && this.delta < 3.904f)
        {
            GameObject go = Instantiate(bikuri);
        }
    }
}
