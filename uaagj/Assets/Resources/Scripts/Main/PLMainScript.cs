using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[����p�N���X
/// </summary>
public class PLMainScript : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 0.01f;
    [SerializeField] private Vector3 thisPos;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject soundBullet;
    [SerializeField] private GameObject bulletPos;

    [SerializeField] private float bulletSpeed = 0.1f;//���˂����e�̑��x�@0.1f�ɂ���Ƃ�����������


    //�C�N�[�[�[�[�[�[�[�[�[�[�[�i���[�V���j
    //�C�N�[�[�[�[�[�[�[�[�[�[�[�i���[�V���j
    //�C�N�[�[�[�[�[�[�[�[�[�[�[�i���[�V���j
    private Vector3 mousePos;

    /// <summary>
    /// null�`�F�b�N
    /// </summary>
    private void nullCheck()
    {
        if (thisPos == null)
        {
            thisPos = this.gameObject.transform.position;
        }

        
    }

    /// <summary>
    /// �}�E�X���W�擾
    /// </summary>
    private Vector3 GetMousePosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Debug.Log(mousePos);
        return mousePos;
    }


    private void LookAtMousePosition()
    {
        Vector3 thisPos = this.transform.position;
        Vector3 lookDir = GetMousePosition() - thisPos;
        float angle = Mathf.Atan2(lookDir.x, lookDir.y) * Mathf.Rad2Deg;
        this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0,angle,0));
    }


    /// <summary>
    /// �ړ�
    /// </summary>
    private void PlayerMove()
    {

        float posX = Input.GetAxisRaw("Horizontal");
        float posZ = Input.GetAxisRaw("Vertical");

        this.transform.position += new Vector3(posX, 0, posZ).normalized * playerSpeed;//��s�ł������낱��
        
    }

    /// <summary>
    /// �v���C���[
    /// </summary>
    private void PlayerAttack()
    {
        //GameObject bullet = Instantiate(soundBullet, bulletPos.transform.position,Quaternion.identity)) as GameObject;
        GameObject gameObject = Instantiate(soundBullet, bulletPos.transform.position, this.gameObject.transform.rotation)as GameObject;
        Bullet bulletScript = gameObject.GetComponent<Bullet>();
        bulletScript.bulletSpeed = bulletSpeed;
    }

    private void FixedUpdate()
    {
        LookAtMousePosition();
        PlayerMove();

        if (Input.GetMouseButtonDown(0))
        {
            PlayerAttack();
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerAttack();
        }
    }


}
