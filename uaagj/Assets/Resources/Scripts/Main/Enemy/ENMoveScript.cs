using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 二階堂君が書いてくれた敵挙動処理のスクリプトがちょっとモヤっとしたので自分も書いてみる
/// </summary>
public class ENMoveScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.2f;//移動速度
    [SerializeField] private GameObject playerObject;//awakeの時に拾ってくる
    [SerializeField] private GameObject hitObject;//当たり判定用オブジェクト　なんか適当に入れといてください

    [SerializeField] public int weakAttributeId;//DataBaseからどうやって持ってくるのかわからないのでとりあえず放置
    [SerializeField] private Material thisMaterial;
    [SerializeField] private int health;

    [SerializeField] private GameObject pulse;



    private void RotateToPlayer()
    {
        this.gameObject.transform.LookAt(playerObject.transform.position, Vector3.up);
    }
    private void Move()
    {
        this.transform.localPosition += transform.forward * moveSpeed;
    }

    /*
    /// <summary>
    /// 敵弾消滅時にいい感じの処理を書いたりする
    /// </summary>
    private void Death()
    {
        Instantiate(pulse);
        Destroy(this.gameObject);
    }
    */


    private void Awake()
    {
        //thisMaterial.SetColor() マテリアルのカラーを変えれるようにしといてください
        playerObject = GameObject.FindWithTag("Player");
    }

    private void FixedUpdate()
    {
        RotateToPlayer();
        Move();
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        //GameObject gameObject = collision.gameObject;
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("EnemyDestroy");
            Death();
        }
    }
    */

}
