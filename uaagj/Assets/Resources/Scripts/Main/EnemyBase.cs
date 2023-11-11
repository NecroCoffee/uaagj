using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[SerializeField]
public class EnemyBase : ScriptableObject
{
    public int AttributeId;         // 属性のID
    public Sprite Attribute;        // 属性
    public int WeaknessAttributeId; // 弱点の属性のID
    public Enemy enemy;             // 対応するPrefab
}
