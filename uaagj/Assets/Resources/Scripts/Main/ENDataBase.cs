using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// これも新たに作ってみる ENBaseを突っ込んどいて
/// </summary>
[CreateAssetMenu]
[SerializeField]
public class ENDataBase : ScriptableObject
{
    public List<ENBase> SEList = new List<ENBase>();
}
