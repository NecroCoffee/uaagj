using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[SerializeField]
public class EnemyBase : ScriptableObject
{
    public int AttributeId;         // ������ID
    public Sprite Attribute;        // ����
    public int WeaknessAttributeId; // ��_�̑�����ID
    public Enemy enemy;             // �Ή�����Prefab
}
