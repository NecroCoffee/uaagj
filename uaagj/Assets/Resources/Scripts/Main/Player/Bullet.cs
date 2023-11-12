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

    private void BulletMove()
    {
        this.transform.localPosition += transform.forward * bulletSpeed;
    }

    private void OnEnable()
    {
        Destroy(this.gameObject, 5f);//���Ŏ��Ԃ͓K���ɒ������Ƃ��Ă�������
    }

    private void FixedUpdate()
    {
        BulletMove();
    }

    // �G�ɓ����������̏���
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTrigger");

        // ���������I�u�W�F�N�g���G���ǂ�������
        if (collider.gameObject.tag != EnemyTagName) { return; }

        Debug.Log("Enemy");

        // �G�Ȃ��_�̑������擾���A�U�����L��������
        _plMainScript = GameObject.Find("Player").GetComponent<PLMainScript>();
        Debug.Log(collider.gameObject.GetComponent<ENMoveScript>().weakAttributeId);
        Debug.Log(_plMainScript.SEattributeIndex);
        if (collider.gameObject.GetComponent<ENMoveScript>().weakAttributeId != _plMainScript.SEattributeIndex)
        { return; }

        Debug.Log("EnemyDestroy");

        // �L���Ȃ�G��Destroy����
        Destroy(this.gameObject);
        Destroy(collider.gameObject);
    }
}
