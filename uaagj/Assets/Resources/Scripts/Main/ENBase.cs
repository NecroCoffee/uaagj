using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �G������g���₷������p �Q�Ă����K���N�̂�g���Ƃ��Ă�������
/// </summary>
[CreateAssetMenu]
[SerializeField]
public class ENBase : ScriptableObject
{
    public int AttributeId;         // ������ID
    public Color32 EnemyColor32;    // �G�̃��f���ɒ���t���Ă���}�e���A����RGB�l��ύX�@�ύX���ꂽ�}�e���A���͑��B����̂Ń��������[�N��h�����߂�EnemyMove���Ń}�e���A����Destroy����������
    public int Health;              // �G�̗̑� 0�ɂȂ�����Destroy�����𑝐B�ς݃}�e���A���Ƌ��ɂ��肢���܂�

    //�Œ�����ꂾ�� �K�v�ɂȂ�����܂��V���ɕϐ��錾����΂����񂶂�Ȃ���ł�����
}
