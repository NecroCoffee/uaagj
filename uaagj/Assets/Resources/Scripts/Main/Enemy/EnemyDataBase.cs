using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[SerializeField]
public class EnemyDataBase : ScriptableObject
{
    public List<EnemyBase> EnemyList= new List<EnemyBase>();
}
