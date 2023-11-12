using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���������Ƃ������O�̂���������Ǝv��
/// </summary>
public class ENOnDestroyPulse : MonoBehaviour
{
    [SerializeField] private float maxSize = 2f;//�����������Ɣ͈͂𒲐��ł���
    /// <summary>
    /// �e����@���������� if�̏������̉E����������Ɣ͈͂𒲐��ł���
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
