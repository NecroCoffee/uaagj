using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��K���N�������Ă��ꂽ�G���������̃X�N���v�g��������ƃ������Ƃ����̂Ŏ����������Ă݂�
/// </summary>
public class ENMoveScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.2f;//�ړ����x
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject hitObject;//�����蔻��p�I�u�W�F�N�g�@�Ȃ񂩓K���ɓ���Ƃ��Ă�������

    [SerializeField] public int AttributeId;//DataBase����ǂ�����Ď����Ă���̂��킩��Ȃ��̂łƂ肠�������u
    [SerializeField] private Material thisMaterial;
    [SerializeField] private int health;



    private void SearchPlayer()
    {

    }
    private void Move()
    {

    }

    private void Death()
    {

    }


    private void Awake()
    {
        //thisMaterial.SetColor() �}�e���A���̃J���[��ς����悤�ɂ��Ƃ��Ă�������
        playerObject = GameObject.FindWithTag("Player");
    }

}
