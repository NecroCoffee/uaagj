using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���ʉ��̒�`�N���X
// [Project]�ŉE�N���b�N��[SEBase]����ǉ��\
[CreateAssetMenu]
[SerializeField]
public class SEBase : ScriptableObject
{
    public int AttributeId;         // ������ID
    public Sprite Attribute;        // ����
    public int Volume;              // �З�
    public Sprite Icon;             // �\������A�C�R��
    public AudioClip audioClip;     // �Ή�����SE
}
