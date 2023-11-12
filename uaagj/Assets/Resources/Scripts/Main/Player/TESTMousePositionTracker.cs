using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTMousePositionTracker : MonoBehaviour
{
    [SerializeField] GameObject map;
    Vector3 mousePos;

    private void Tracking()
    {
        Vector3 test = Input.mousePosition;
        test.z = 1;
        mousePos = Camera.main.ScreenToWorldPoint(test);
        Debug.Log(mousePos);
        float diff = mousePos.y - map.gameObject.transform.position.y;
        mousePos.y -= diff-2;
        this.transform.position = mousePos;
    }

    private void FixedUpdate()
    {
        Tracking();
    }
}
