using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �쐬�������ʉ����i�[����
[CreateAssetMenu]
[SerializeField]
public class SEDataBase : ScriptableObject
{
    public List<SEBase> SEList = new List<SEBase>();

}
