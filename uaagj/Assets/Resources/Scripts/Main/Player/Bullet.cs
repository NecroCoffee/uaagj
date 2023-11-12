using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Qなにこれ？　A弾動かしてる
/// </summary>
public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public int attributeID;
    public int volume;

    private void BulletMove()
    {
        this.transform.localPosition += transform.forward * bulletSpeed;
    }

    private void OnEnable()
    {
        //bulletSpeed = 0.1f;//仮データ 受け渡し処理実装済み 不要
        Destroy(this.gameObject, 5f);//消滅時間は適当に調整しといてください
    }

    private void FixedUpdate()
    {
        BulletMove();
    }
}
