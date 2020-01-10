using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Home.
/// </summary>
[Serializable]
public class ThemeCanvasHome
{
    #region Static
    public static int ACTUAL_INFORMATION = 1;
    #endregion

    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Canvas Home / Informations")]
    [Tooltip("Sprite of Background of part Informations.")]
    [SerializeField] Sprite imgImgBackImgInformationsCanvasHome;
    [Tooltip("Position Background of part Informations.")]
    [SerializeField] RectTransform transformImgBackImgInformationsCanvasHome;
    [Tooltip("Sprite of Img information 1")]
    [SerializeField] Sprite imgImgInformations1CanvasHome;
    [Tooltip("Sprite of Img information 2")]
    [SerializeField] Sprite imgImgInformations2CanvasHome;
    [Tooltip("Sprite of Img information 3")]
    [SerializeField] Sprite imgImgInformations3CanvasHome;
    [Tooltip("Position of Img information")]
    [SerializeField] RectTransform transformImgInformationsCanvasHome;
    [Header("Canvas Home / Indicators Informations")]
    [Tooltip("Sprite focus Img indicator number information")]
    [SerializeField] Sprite imgFocusImgIndicatorNumberInformationsCanvasHome;
    [Tooltip("Sprite not focus Img indicator number information")]
    [SerializeField] Sprite imgNotFocusImgIndicatorNumberInformationsCanvasHome;
    [Tooltip("Position Img indicator number information 1")]
    [SerializeField] RectTransform transformImgIndicatorNumberInformation1CanvasHome;
    [Tooltip("Position Img indicator number information 2")]
    [SerializeField] RectTransform transformImgIndicatorNumberInformation2CanvasHome;
    [Tooltip("Position Img indicator number information 3")]
    [SerializeField] RectTransform transformImgIndicatorNumberInformation3CanvasHome;
    [Header("Canvas Home / Arrow Informations Left")]
    [Tooltip("Sprite Background of part Left Arrow.")]
    [SerializeField] Sprite imgImgBackImgLeftArrowCanvasHome;
    [Tooltip("Position Background of part Left Arrow.")]
    [SerializeField] RectTransform transformImgBackImgLeftArrowCanvasHome;
    [Tooltip("Sprite Left Arrow.")]
    [SerializeField] Sprite imgBtnLeftArrowCanvasHome;
    [Tooltip("Position Left Arrow.")]
    [SerializeField] RectTransform transformBtnLeftArrowCanvasHome;
    [Header("Canvas Home / Arrow Informations Right")]
    [Tooltip("Sprite Background of part Right Arrow.")]
    [SerializeField] Sprite imgImgBackImgRightArrowCanvasHome;
    [Tooltip("Position Background of part Right Arrow.")]
    [SerializeField] RectTransform transformImgBackImgRightArrowCanvasHome;
    [Tooltip("Sprite Right Arrow.")]
    [SerializeField] Sprite imgBtnRightArrowCanvasHome;
    [Tooltip("Position Right Arrow.")]
    [SerializeField] RectTransform transformBtnRightArrowCanvasHome;
    [Header("Canvas Home / Text Home")]
    [Tooltip("Sprite Background of part text home.")]
    [SerializeField] Sprite imgImgBackImgTextCanvasHome;
    [Tooltip("Position Background of part text home.")]
    [SerializeField] RectTransform transformImgBackImgTextCanvasHome;
    [Tooltip("Color Text Home")]
    [SerializeField] Color colorTextCanvasHome;
    [Tooltip("Position Text Home")]
    [SerializeField] RectTransform transformTextCanvasHome;
    [Header("Canvas Home / Timer")]
    [Tooltip("Time before switch informations")]
    [SerializeField] float timer;
    #endregion

    #region Getters & Setters
    public float m_timer { get { return timer; } }
    #endregion

    #region Private
    GameObjectManager _goManager = null;
    bool _canDecrease = false;
    #endregion

    #region System
    public void Awake()
    {
        _goManager = GameObject.Find("GameObjectManager").GetComponent<GameObjectManager>();
        ACTUAL_INFORMATION = 1;
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// Function use to change the theme on the Home.
    /// </summary>
    public void ChangeThemeCanvasHome()
    {
        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformImgBackImgInformationsCanvasHome, transformImgBackImgInformationsCanvasHome);
        _goManager.m_goCanvasHome.m_imgImgBackImgInformationsCanvasHome.sprite = imgImgBackImgInformationsCanvasHome;

        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformImgInformationsCanvasHome, transformImgInformationsCanvasHome);
        ChangeActualInformation(0);

        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformImgIndicatorNumberInformation1CanvasHome, transformImgIndicatorNumberInformation1CanvasHome);
        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformImgIndicatorNumberInformation2CanvasHome, transformImgIndicatorNumberInformation2CanvasHome);
        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformImgIndicatorNumberInformation3CanvasHome, transformImgIndicatorNumberInformation3CanvasHome);

        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformImgBackBtnLeftArrowCanvasHome, transformImgBackImgLeftArrowCanvasHome);
        _goManager.m_goCanvasHome.m_imgImgBackBtnLeftArrowCanvasHome.sprite = imgImgBackImgLeftArrowCanvasHome;
        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformBtnLeftArrowCanvasHome, transformBtnLeftArrowCanvasHome);
        _goManager.m_goCanvasHome.m_imgBtnLeftArrowCanvasHome.sprite = imgBtnLeftArrowCanvasHome;

        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformImgBackBtnRightArrowCanvasHome, transformImgBackImgRightArrowCanvasHome);
        _goManager.m_goCanvasHome.m_imgImgBackBtnRightArrowCanvasHome.sprite = imgImgBackImgRightArrowCanvasHome;
        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformBtnRightArrowCanvasHome, transformBtnRightArrowCanvasHome);
        _goManager.m_goCanvasHome.m_imgBtnRightArrowCanvasHome.sprite = imgBtnRightArrowCanvasHome;

        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformImgBackImgTextCanvasHome, transformImgBackImgTextCanvasHome);
        _goManager.m_goCanvasHome.m_imgImgBackImgTextCanvasHome.sprite = imgImgBackImgTextCanvasHome;

        ChangeRectTransform(_goManager.m_goCanvasHome.m_transformTextCanvasHome, transformTextCanvasHome);
        _goManager.m_goCanvasHome.m_tmpTextCanvasHome.font = font;
        _goManager.m_goCanvasHome.m_tmpTextCanvasHome.color = colorTextCanvasHome;
    }
    /// <summary>
    /// Function use to change the position of data(s) on the Canvas Home.
    /// </summary>
    public void ChangeRectTransform(RectTransform from, RectTransform to)
    {
        from.SetPositionAndRotation(to.position, to.rotation);
        from.sizeDelta = new Vector2(to.sizeDelta.x, to.sizeDelta.y);
        from.anchorMax = to.anchorMax;
        from.anchorMin = to.anchorMin;
        from.pivot = to.pivot;
        from.localScale = new Vector3(to.localScale.x, to.localScale.y, to.localScale.z);
    }
    /// <summary>
    /// Function use to change the ACTUAL_INFORMATION.
    /// </summary>
    public void ChangeActualInformation(int change)
    {

        ACTUAL_INFORMATION += change;

        if(ACTUAL_INFORMATION > 3)
        {
            ACTUAL_INFORMATION = 1;
        }
        else if(ACTUAL_INFORMATION < 1)
        {
            ACTUAL_INFORMATION = 3;
        }

        switch(ACTUAL_INFORMATION)
        {
            case 1:
                _goManager.m_goCanvasHome.m_imgImgInformationsCanvasHome.sprite = imgImgInformations1CanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation1CanvasHome.sprite = imgFocusImgIndicatorNumberInformationsCanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation2CanvasHome.sprite = imgNotFocusImgIndicatorNumberInformationsCanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation3CanvasHome.sprite = imgNotFocusImgIndicatorNumberInformationsCanvasHome;
                break;
            case 2:
                _goManager.m_goCanvasHome.m_imgImgInformationsCanvasHome.sprite = imgImgInformations2CanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation1CanvasHome.sprite = imgNotFocusImgIndicatorNumberInformationsCanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation2CanvasHome.sprite = imgFocusImgIndicatorNumberInformationsCanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation3CanvasHome.sprite = imgNotFocusImgIndicatorNumberInformationsCanvasHome;
                break;
            case 3:
                _goManager.m_goCanvasHome.m_imgImgInformationsCanvasHome.sprite = imgImgInformations3CanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation1CanvasHome.sprite = imgNotFocusImgIndicatorNumberInformationsCanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation2CanvasHome.sprite = imgNotFocusImgIndicatorNumberInformationsCanvasHome;
                _goManager.m_goCanvasHome.m_imgImgIndicatorNumberInformation3CanvasHome.sprite = imgFocusImgIndicatorNumberInformationsCanvasHome;
                break;
            default:
                break;
        }
    }
    #endregion
}
