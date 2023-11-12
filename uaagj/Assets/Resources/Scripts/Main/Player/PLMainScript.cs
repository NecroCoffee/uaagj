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

    //[SerializeField] private bool isAtack = false;   // ���ʉ����������Ă���Œ����ǂ���
    [SerializeField] private GameObject soundBullet;    // �����蔻��ƂȂ�I�u�W�F�N�g
    [SerializeField] private GameObject bulletPos;      // �����蔻�肪���˂����ʒu
    private GameObject soundBulletObj;

    private SEController seController;
    public int SEattributeIndex { get; private set; } = 0;  // �U�����̑�����Index

    [SerializeField] private GameObject bulletParticle; // �����蔻��̃G�t�F�N�g
    private GameObject bulletParticleObj;   // ���������G�t�F�N�g
    private bool canAtack = true;

    [SerializeField] private float bulletSpeed = 1f;//���˂����e�̑��x�@0.1f�ɂ���Ƃ�����������



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
        //Debug.Log(mousePos);
        return mousePos;
    }


    /// <summary>
    /// �}�E�X�̕������������鏈��
    /// </summary>
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
    /// ���ʉ��̔���
    /// </summary>
    private void PlayerAttack()
    {
        canAtack = false;
        seController = GameObject.Find("SEController").GetComponent<SEController>();
        SEattributeIndex = seController.SEListIndex + 1;

        //GameObject bullet = Instantiate(soundBullet, bulletPos.transform.position,Quaternion.identity)) as GameObject;
        soundBulletObj = Instantiate(soundBullet, bulletPos.transform.position, this.gameObject.transform.rotation) as GameObject;
        Bullet bulletScript = soundBulletObj.GetComponent<Bullet>();
        bulletScript.bulletSpeed = bulletSpeed;

        // ���ʉ��̍Đ�
        audioSource.PlayOneShot(seController.SEClip);

        // �G�t�F�N�g�̐���
        Vector3 particlePos = bulletPos.transform.position;
        particlePos.y = 1;
        bulletParticleObj = Instantiate(bulletParticle, particlePos, bulletPos.transform.rotation);
    }

    private void FixedUpdate()
    {
        LookAtMousePosition();
        PlayerMove(); 
    }

    private void Update()
    {
        if (canAtack && Input.GetMouseButtonDown(0))
        {
            PlayerAttack();
        }

        if (bulletParticleObj != null && bulletParticleObj.GetComponent<ParticleSystem>().isStopped)
        {
            Destroy(bulletParticleObj);
            Destroy(soundBulletObj);
            canAtack = true;
        }
    }

}
