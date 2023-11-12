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

    // “ü—Í
    private const string _InputMouseWheel = "Mouse ScrollWheel";
    private float _mouseVelocity_y = 0;

    // Start is called before the first frame update
    void Start()
    {
        // UI‚Ì—v‘f‚ðŽæ“¾
        _SEIconImg = _SEIconObj.GetComponent<Image>();
        _SEAttributeImg = _SEGuideObj.transform.Find(_SEAttributeObjName).GetComponent<Image>();
        _SEVolumeText = _SEGuideObj.transform.Find(_SEVolumeObjName).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _mouseVelocity_y = Input.GetAxisRaw(_InputMouseWheel);

        
        // Œø‰Ê‰¹‚ÌØ‚è‘Ö‚¦(ŽŸ‚ÌŒø‰Ê‰¹)
        if (ChangeUpChack())
        {
            SEListIndex++;
            ChangeSE();
        }

        // Œø‰Ê‰¹‚ÌØ‚è‘Ö‚¦(‘O‚ÌŒø‰Ê‰¹)
        if (ChangeDownCheck())
        {
            SEListIndex--;
            ChangeSE();
        }

    }

    // Œø‰Ê‰¹‚ðØ‚è‘Ö‚¦‚é
    private void ChangeSE()
    {
        // UI‚Ì•\Ž¦‚ðØ‚è‘Ö‚¦
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
