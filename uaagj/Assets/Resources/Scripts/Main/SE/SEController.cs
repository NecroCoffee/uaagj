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

    public AudioClip SEClip;

    // 入力
    private const string _InputMouseWheel = "Mouse ScrollWheel";
    private float _mouseVelocity_y = 0;

    // Start is called before the first frame update
    void Start()
    {
        // UIの要素を取得
        _SEIconImg = _SEIconObj.GetComponent<Image>();
        _SEAttributeImg = _SEGuideObj.transform.Find(_SEAttributeObjName).GetComponent<Image>();
        _SEVolumeText = _SEGuideObj.transform.Find(_SEVolumeObjName).GetComponent<Text>();

        // 属性リスト先頭の要素をセット
        _SEIconImg.sprite = _SEDataBase.SEList[SEListIndex].Icon;
        SEClip = _SEDataBase.SEList[SEListIndex].audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        _mouseVelocity_y = Input.GetAxisRaw(_InputMouseWheel);

        
        // 効果音の切り替え(次の効果音)
        if (ChangeUpChack())
        {
            SEListIndex++;
            ChangeSE();
        }

        // 効果音の切り替え(前の効果音)
        if (ChangeDownCheck())
        {
            SEListIndex--;
            ChangeSE();
        }

    }

    // 効果音を切り替える
    private void ChangeSE()
    {
        // UIの表示を切り替え
        _SEIconImg.sprite = _SEDataBase.SEList[SEListIndex].Icon;
        //_SEAttributeImg.sprite = _SEDataBase.SEList[SEListIndex].Attribute;
        //_SEVolumeText.text = string.Format(_SEVolumeTextFormat, _SEDataBase.SEList[SEListIndex].Volume.ToString());

        // 効果音を取得
        SEClip = _SEDataBase.SEList[SEListIndex].audioClip;
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
