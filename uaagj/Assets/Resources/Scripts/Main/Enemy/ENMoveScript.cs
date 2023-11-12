using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��K���N�������Ă��ꂽ�G���������̃X�N���v�g��������ƃ������Ƃ����̂Ŏ����������Ă݂�
/// </summary>
public class ENMoveScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.2f;//�ړ����x
    [SerializeField] private GameObject playerObject;//awake�̎��ɏE���Ă���
    [SerializeField] private GameObject hitObject;//�����蔻��p�I�u�W�F�N�g�@�Ȃ񂩓K���ɓ���Ƃ��Ă�������

    [SerializeField] public int weakAttributeId;//DataBase����ǂ�����Ď����Ă���̂��킩��Ȃ��̂łƂ肠�������u
    [SerializeField] private Material thisMaterial;
    [SerializeField] private int health;

    [SerializeField] private GameObject pulse;



    private void RotateToPlayer()
    {
        this.gameObject.transform.LookAt(playerObject.transform.position, Vector3.up);
    }
    private void Move()
    {
        this.transform.localPosition += transform.forward * moveSpeed;
    }

    /*
    /// <summary>
    /// �G�e���Ŏ��ɂ��������̏������������肷��
    /// </summary>
    private void Death()
    {
        Instantiate(pulse);
        Destroy(this.gameObject);
    }
    */


    private void Awake()
    {
        //thisMaterial.SetColor() �}�e���A���̃J���[��ς����悤�ɂ��Ƃ��Ă�������
        playerObject = GameObject.FindWithTag("Player");
    }

    private void FixedUpdate()
    {
        RotateToPlayer();
        Move();
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        //GameObject gameObject = collision.gameObject;
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("EnemyDestroy");
            Death();
        }
    }
    */

}
