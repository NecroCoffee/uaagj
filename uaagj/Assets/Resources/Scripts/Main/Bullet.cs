using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Q�Ȃɂ���H�@A����̓��e��錾���Ă邾��
/// </summary>
public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public int attributeID;
    public int volume;

    private void dammy()
    {
        bulletSpeed = 0.1f;
        Vector3 test = this.transform.position;
        this.transform.position+=test * bulletSpeed * Time.deltaTime;
    }

    private void OnEnable()
    {
        Destroy(this.gameObject, 5f);
    }

    private void FixedUpdate()
    {
        dammy();
    }
}
