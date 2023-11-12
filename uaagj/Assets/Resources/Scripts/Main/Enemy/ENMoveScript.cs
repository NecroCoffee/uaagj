using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 二階堂君が書いてくれた敵挙動処理のスクリプトがちょっとモヤっとしたので自分も書いてみる
/// </summary>
public class ENMoveScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.2f;//移動速度
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject hitObject;//当たり判定用オブジェクト　なんか適当に入れといてください

    [SerializeField] public int AttributeId;//DataBaseからどうやって持ってくるのかわからないのでとりあえず放置
    [SerializeField] private Material thisMaterial;
    [SerializeField] private int health;



    private void SearchPlayer()
    {

    }
    private void Move()
    {

    }

    private void Death()
    {

    }


    private void Awake()
    {
        //thisMaterial.SetColor() マテリアルのカラーを変えれるようにしといてください
        playerObject = GameObject.FindWithTag("Player");
    }

}
