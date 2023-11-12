using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Q�Ȃɂ���H�@A�e�������Ă�
/// ���ʉ��̓����蔻�肨��уG�t�F�N�g�`��̃N���X
/// </summary>
public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public int attributeID;
    public int volume;

    private const string EnemyTagName = "Enemy";
    private PLMainScript _plMainScript;

    public GameObject _player;

    [SerializeField] private GameObject _palse;

    private void BulletMove()
    {
        this.transform.localPosition += _player.transform.forward * bulletSpeed;
    }

    private void FixedUpdate()
    {
        BulletMove();
    }

    // �G�ɓ����������̏���
    private void OnTriggerEnter(Collider collider)
    {
        // ���������I�u�W�F�N�g���G���ǂ�������
        if (collider.gameObject.tag != EnemyTagName) { return; }

        // �G�Ȃ��_�̑������擾���A�U�����L��������
        _plMainScript = GameObject.Find("Player").GetComponent<PLMainScript>();
        if (collider.gameObject.GetComponent<ENMoveScript>().weakAttributeId != _plMainScript.SEattributeIndex)
        { return; }

        // ���j�����G�̈ʒu���猂�j���𔭐�
        Instantiate(_palse, collider.gameObject.transform);

        // �L���Ȃ�G��Destroy����
        Destroy(collider.gameObject);
        Destroy(this.gameObject);
    }
}
