using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEController : MonoBehaviour
{
    [SerializeField] private SEDataBase _SEDataBase;

    public int SEListIndex = 0;

    [Header("UI")]
    [SerializeField] private GameObject _SEIconObj;
    private Image _SEIconImg;
    [SerializeField] private GameObject _SEGuideObj;
    private const string _SEAttributeObjName = "Attribute";
    private Image _SEAttributeImg;
    private const string _SEVolumeObjName = "Volume";
    private Text _SEVolumeText;
    private const string _SEVolumeTextFormat = "{0}db";

    // ����
    private const string _InputMouseWheel = "Mouse ScrollWheel";
    private float _mouseVelocity_y = 0;

    // Start is called before the first frame update
    void Start()
    {
        // UI�̗v�f���擾
        _SEIconImg = _SEIconObj.GetComponent<Image>();
        _SEAttributeImg = _SEGuideObj.transform.Find(_SEAttributeObjName).GetComponent<Image>();
        _SEVolumeText = _SEGuideObj.transform.Find(_SEVolumeObjName).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _mouseVelocity_y = Input.GetAxisRaw(_InputMouseWheel);

        
        // ���ʉ��̐؂�ւ�(���̌��ʉ�)
        if (ChangeUpChack())
        {
            SEListIndex++;
            ChangeSE();
        }

        // ���ʉ��̐؂�ւ�(�O�̌��ʉ�)
        if (ChangeDownCheck())
        {
            SEListIndex--;
            ChangeSE();
        }

    }

    // ���ʉ���؂�ւ���
    private void ChangeSE()
    {
        // UI�̕\����؂�ւ�
        _SEIconImg.sprite = _SEDataBase.SEList[SEListIndex].Icon;
        _SEAttributeImg.sprite = _SEDataBase.SEList[SEListIndex].Attribute;
        _SEVolumeText.text = string.Format(_SEVolumeTextFormat, _SEDataBase.SEList[SEListIndex].Volume.ToString());
    }


    private bool ChangeUpChack()
    {
        if (SEListIndex >= _SEDataBase.SEList.Count - 1) { return false; }
        if (Input.GetAxisRaw(_InputMouseWheel) <= 0) { return false; }

        return true;
    }

    private bool ChangeDownCheck()
    {
        if (SEListIndex <= 0) { return false; }
        if (Input.GetAxisRaw(_InputMouseWheel) >= 0) { return false; }

        return true;
        
    }
}
