using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 効果音の定義クラス
// [Project]で右クリック→[SEBase]から追加可能
[CreateAssetMenu]
[SerializeField]
public class SEBase : ScriptableObject
{
    public int AttributeId;         // 属性のID
    public Sprite Attribute;        // 属性
    public int Volume;              // 威力
    public Sprite Icon;             // 表示するアイコン
    public AudioClip audioClip;     // 対応するSE
}
