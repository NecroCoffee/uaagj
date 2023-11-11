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
    [SerializeField] private float energy;

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

        if (energy == null)
        {
            energy = 100f;//�Ƃ肠����100f�����Ă����B��ŕς����肷��B
        }
    }

    /// <summary>
    /// �}�E�X���W�擾
    /// </summary>
    private void GetMousePosition()
    {
        Vector3 test = Input.mousePosition;
        test.z = 1;
        mousePos = Camera.main.ScreenToWorldPoint(test);
        Debug.Log(mousePos);
    }

    /// <summary>
    /// ��]
    /// </summary>
    private void RotatePlayerMouse()
    {
        this.transform.LookAt(new Vector3((mousePos.x + mousePos.z) * 10,0 ,mousePos.z));
    }

    /// <summary>
    /// �ړ�
    /// </summary>
    private void PlayerMove()
    {

        float posX = Input.GetAxisRaw("Horizontal");
        float posZ = Input.GetAxisRaw("Vertical");

        this.transform.position += new Vector3(posX, thisPos.y, posZ).normalized * playerSpeed;//��s�ł������낱��
        
    }

    private void FixedUpdate()
    {
        GetMousePosition();
        RotatePlayerMouse();
        PlayerMove();
    }


}
