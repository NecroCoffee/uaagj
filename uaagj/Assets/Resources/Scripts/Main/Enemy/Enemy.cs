using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform PlayerTr;                 // �v���C���[��Transform�ł��B
    [SerializeField] float speed = 2;   // �G�̈ړ����x�ł��B

    void Start()
    {
        // �v���C���[��Transform���擾���܂��B
        PlayerTr = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        // �v���C���[�Ɍ����Đi�܂��܂��B
        transform.position = Vector2.MoveTowards
            (transform.position, new Vector2
            (PlayerTr.position.x, PlayerTr.position.y),
            speed * Time.deltaTime);
    }

    // �v���C���[�ɏՓ˂����...
    void OnTriggerEnter(Collider collider)
    {
        /* Player��isTrigger�Ƀ`�F�b�N��t���� */
        if (collider.gameObject.tag == "Player")
        {
            // 0.2�b��i���j�ɍ폜�����܂��B
            Destroy(gameObject, 0.2f);
        }
    }
}
