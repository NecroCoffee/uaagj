using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 作成した効果音を格納する
[CreateAssetMenu]
[SerializeField]
public class SEDataBase : ScriptableObject
{
    public List<SEBase> SEList = new List<SEBase>();

}
