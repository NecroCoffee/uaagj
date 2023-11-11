using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤー操作用クラス
/// </summary>
public class PLMainScript : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 0.01f;
    [SerializeField] private Vector3 thisPos;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private float energy;

    //イクーーーーーーーーーーー（リーシン）
     private Vector3 mousePos;

    /// <summary>
    /// nullチェック
    /// </summary>
    private void nullCheck()
    {
        if (thisPos == null)
        {
            thisPos = this.gameObject.transform.position;
        }

        if (energy == null)
        {
            energy = 100f;//とりあえず100fを入れておく。後で変えたりする。
        }
    }

    /// <summary>
    /// マウス座標取得
    /// </summary>
    private void GetMousePosition()
    {
        Vector3 test = Input.mousePosition;
        test.z = 1;
        mousePos = Camera.main.ScreenToWorldPoint(test);
        Debug.Log(mousePos);
    }

    /// <summary>
    /// 回転
    /// </summary>
    private void RotatePlayerMouse()
    {
        this.transform.LookAt(new Vector3((mousePos.x + mousePos.z) * 10,0 ,mousePos.z));
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void PlayerMove()
    {

        float posX = Input.GetAxisRaw("Horizontal");
        float posZ = Input.GetAxisRaw("Vertical");

        this.transform.position += new Vector3(posX, thisPos.y, posZ).normalized * playerSpeed;//一行でいいだろこれ
        
    }

    private void FixedUpdate()
    {
        GetMousePosition();
        RotatePlayerMouse();
        PlayerMove();
    }


}
