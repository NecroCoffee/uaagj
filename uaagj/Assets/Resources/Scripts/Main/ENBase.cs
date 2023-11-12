using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵周りを使いやすくする用 寝てたら二階堂君のやつ使っといてください
/// </summary>
[CreateAssetMenu]
[SerializeField]
public class ENBase : ScriptableObject
{
    public int AttributeId;         // 属性のID
    public Color32 EnemyColor32;    // 敵のモデルに張り付けてあるマテリアルのRGB値を変更　変更されたマテリアルは増殖するのでメモリリークを防ぐためにEnemyMove側でマテリアルのDestroy処理をする
    public int Health;              // 敵の体力 0になったらDestroy処理を増殖済みマテリアルと共にお願いします

    //最低限これだけ 必要になったらまた新たに変数宣言すればいいんじゃないんですかね
}
