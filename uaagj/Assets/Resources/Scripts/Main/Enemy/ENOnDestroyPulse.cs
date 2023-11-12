using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 多分もっといい名前のつけ方があると思う
/// </summary>
public class ENOnDestroyPulse : MonoBehaviour
{
    [SerializeField] private float maxSize = 2f;//これをいじると範囲を調整できる
    /// <summary>
    /// 弾ける　いい感じに ifの条件式の右側をいじると範囲を調整できる
    /// </summary>
    private void Boom()
    {
        this.gameObject.transform.localScale += new Vector3(0.01f, 0, 0.01f);
        if (this.gameObject.transform.localScale.x >= maxSize)
        {
            Destroy(this.gameObject);
        }
    }




    private void Update()
    {
        Boom();        
    }
}
