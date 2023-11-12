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

    public GameObject _player;

    [SerializeField] private GameObject _palse;

    private void BulletMove()
    {
        this.transform.localPosition += _player.transform.forward * bulletSpeed;
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

        // 撃破した敵の位置から撃破音を発生
        Instantiate(_palse, collider.gameObject.transform);

        // 有効なら敵をDestroyする
        Destroy(collider.gameObject);
        Destroy(this.gameObject);
    }
}
