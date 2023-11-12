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

    //[SerializeField] private bool isAtack = false;   // 効果音が発生している最中かどうか
    [SerializeField] private GameObject soundBullet;    // 当たり判定となるオブジェクト
    [SerializeField] private GameObject bulletPos;      // 当たり判定が発射される位置
    private GameObject soundBulletObj;

    private SEController seController;
    public int SEattributeIndex { get; private set; } = 0;  // 攻撃時の属性のIndex

    [SerializeField] private GameObject bulletParticle; // 当たり判定のエフェクト
    private GameObject bulletParticleObj;   // 生成したエフェクト
    private bool canAtack = true;

    [SerializeField] private float bulletSpeed = 1f;//発射した弾の速度　0.1fにするとごっつええ感じ



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

        
    }

    /// <summary>
    /// マウス座標取得
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
    /// マウスの方向を向かせる処理
    /// </summary>
    private void LookAtMousePosition()
    {
        Vector3 thisPos = this.transform.position;
        Vector3 lookDir = GetMousePosition() - thisPos;
        float angle = Mathf.Atan2(lookDir.x, lookDir.y) * Mathf.Rad2Deg;
        this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0,angle,0));
    }


    /// <summary>
    /// 移動
    /// </summary>
    private void PlayerMove()
    {

        float posX = Input.GetAxisRaw("Horizontal");
        float posZ = Input.GetAxisRaw("Vertical");

        this.transform.position += new Vector3(posX, 0, posZ).normalized * playerSpeed;//一行でいいだろこれ
        
    }

    /// <summary>
    /// プレイヤー
    /// 効果音の発生
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

        // 効果音の再生
        audioSource.PlayOneShot(seController.SEClip);

        // エフェクトの生成
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
