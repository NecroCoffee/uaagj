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

    private void FixedUpdate()
    {
        BulletMove();
    }

    // 敵に当たった時の処理
    private void OnTriggerEnter(Collider collider)
    {
        // 当たったオブジェクトが敵かどうか判定
        if (collider.gameObject.tag != EnemyTagName) { return; }

        // 敵なら弱点の属性を取得し、攻撃が有効か判定
        _plMainScript = GameObject.Find("Player").GetComponent<PLMainScript>();
        if (collider.gameObject.GetComponent<ENMoveScript>().weakAttributeId != _plMainScript.SEattributeIndex)
        { return; }

        // 有効なら敵をDestroyする
        Destroy(this.gameObject);
        Destroy(collider.gameObject);
    }
}
