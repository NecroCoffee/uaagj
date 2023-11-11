using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤー操作用クラス
/// </summary>
public class PL2DController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 0.01f;
    [SerializeField] private Vector3 thisPos;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject soundBullet;
    [SerializeField] private GameObject bulletPos;


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
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg-180f;
        this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(angle, -90,90));
    }

    private void PlayerMove()
    {
        float posX = Input.GetAxisRaw("Horizontal");
        float posY = Input.GetAxisRaw("Vertical");

        this.transform.position += new Vector3(posX,posY,0).normalized * playerSpeed;
    }

    private void FixedUpdate()
    {
        LookAtMousePosition();
        PlayerMove();
    }
}
