using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Q�Ȃɂ���H�@A�e�������Ă�
/// </summary>
public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public int attributeID;
    public int volume;

    private void BulletMove()
    {
        this.transform.localPosition += transform.forward * bulletSpeed;
    }

    private void OnEnable()
    {
        //bulletSpeed = 0.1f;//���f�[�^ �󂯓n�����������ς� �s�v
        Destroy(this.gameObject, 5f);//���Ŏ��Ԃ͓K���ɒ������Ƃ��Ă�������
    }

    private void FixedUpdate()
    {
        BulletMove();
    }
}
