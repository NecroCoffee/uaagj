using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[SerializeField]
public class EnemyBase : ScriptableObject
{
    public int AttributeId;         // ‘®«‚ÌID
    public Sprite Attribute;        // ‘®«
    public int WeaknessAttributeId; // ã“_‚Ì‘®«‚ÌID
    public Enemy enemy;             // ‘Î‰‚·‚éPrefab
}
