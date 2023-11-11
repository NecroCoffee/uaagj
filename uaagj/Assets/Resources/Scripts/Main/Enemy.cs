using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform PlayerTr;                 // プレイヤーのTransformです。
    [SerializeField] float speed = 2;   // 敵の移動速度です。

    void Start()
    {
        // プレイヤーのTransformを取得します。
        PlayerTr = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        // プレイヤーに向けて進ませます。
        transform.position = Vector2.MoveTowards
            (transform.position, new Vector2
            (PlayerTr.position.x, PlayerTr.position.y),
            speed * Time.deltaTime);

        
    }

    void OnTriggerEnter(Collider collider)
    {
        // PlayerにisTriggerつけてもらう
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
