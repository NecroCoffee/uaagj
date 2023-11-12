using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Qなにこれ？　A弾動かしてる
/// 効果音の当たり判定およびエフェクト描画のクラス
/// </summary>
public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public int attributeID;
    public int volume;

    private const string EnemyTagName = "Enemy";
    private PLMainScript _plMainScript;

    private void BulletMove()
    {
        this.transform.localPosition += transform.forward * bulletSpeed;
    }

    private void OnEnable()
    {
        Destroy(this.gameObject, 5f);//消滅時間は適当に調整しといてください
    }

    private void FixedUpdate()
    {
        BulletMove();
    }

    // 敵に当たった時の処理
    private void OnCollisionEnter(Collision collision)
    {
        // 当たったオブジェクトが敵かどうか判定
        if (collision.gameObject.tag != EnemyTagName) { return; }

        // 敵なら弱点の属性を取得し、攻撃が有効か判定
        _plMainScript = GameObject.Find("Player").GetComponent<PLMainScript>();
        if (collision.gameObject.GetComponent<ENMoveScript>().weakAttributeId != _plMainScript.SEattributeIndex)
        { return; }

        // 有効なら敵をDestroyする
        Destroy(collision.gameObject);
    }
}
