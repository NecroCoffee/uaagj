using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������V���ɍ���Ă݂� ENBase��˂�����ǂ���
/// </summary>
[CreateAssetMenu]
[SerializeField]
public class ENDataBase : ScriptableObject
{
    public List<ENBase> SEList = new List<ENBase>();
}
