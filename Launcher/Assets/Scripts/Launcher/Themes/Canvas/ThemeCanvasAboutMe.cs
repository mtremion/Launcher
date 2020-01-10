using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas About Me.
/// </summary>
[Serializable]
public class ThemeCanvasAboutMe
{
    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Canvas About Me / Me")]
    [Tooltip("Sprite of Background of part Me.")]
    [SerializeField] Sprite imgImgBackImgMeCanvasAboutMe;
    [Tooltip("Position of Background of part Me.")]
    [SerializeField] RectTransform transformImgBackImgMeCanvasAboutMe;
    [Tooltip("Sprite of Me.")]
    [SerializeField] Sprite imgImgMeCanvasAboutMe;
    [Tooltip("Position Me.")]
    [SerializeField] RectTransform transformImgMeCanvasAboutMe;
    [Header("Canvas About Me / Informations")]
    [Tooltip("Sprite of Background of part Informations.")]
    [SerializeField] Sprite imgImgBackTxtInformationsCanvasAboutMe;
    [Tooltip("Position of Background of part Informations.")]
    [SerializeField] RectTransform transformImgBackTxtInformationsCanvasAboutMe;
    [Tooltip("Color of text Informations.")]
    [SerializeField] Color colorTxtInformationsCanvasAboutMe;
    [Tooltip("Position of text Informations.")]
    [SerializeField] RectTransform transformTxtInformationsCanvasAboutMe;
    [Header("Canvas About Me / Text")]
    [Tooltip("Sprite of Background of part Text.")]
    [SerializeField] Sprite imgImgBackTxtCanvasAboutMe;
    [Tooltip("Position of Background of part Text.")]
    [SerializeField] RectTransform transformImgBackTxtCanvasAboutMe;
    [Tooltip("Color of text Text.")]
    [SerializeField] Color colorTxtCanvasAboutMe;
    [Tooltip("Position of text Text.")]
    [SerializeField] RectTransform transformTxtCanvasAboutMe;
    #endregion

    #region Private
    GameObjectManager _goManager = null;
    #endregion

    #region System
    public void Awake()
    {
        _goManager = GameObject.Find("GameObjectManager").GetComponent<GameObjectManager>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// Function use to change the theme on the About Me.
    /// </summary>
    public void ChangeThemeCanvasAboutMe()
    {
        ChangeRectTransform(_goManager.m_goCanvasAboutMe.m_transformImgBackImgMeCanvasAboutMe, transformImgBackImgMeCanvasAboutMe);
        _goManager.m_goCanvasAboutMe.m_imgImgBackImgMeCanvasAboutMe.sprite = imgImgBackImgMeCanvasAboutMe;
        ChangeRectTransform(_goManager.m_goCanvasAboutMe.m_transformImgMeCanvasAboutMe, transformImgMeCanvasAboutMe);
        _goManager.m_goCanvasAboutMe.m_imgImgMeCanvasAboutMe.sprite = imgImgMeCanvasAboutMe;

        ChangeRectTransform(_goManager.m_goCanvasAboutMe.m_transformImgBackTxtInformationsCanvasAboutMe, transformImgBackTxtInformationsCanvasAboutMe);
        _goManager.m_goCanvasAboutMe.m_imgImgBackTxtInformationsCanvasAboutMe.sprite = imgImgBackTxtInformationsCanvasAboutMe;
        ChangeRectTransform(_goManager.m_goCanvasAboutMe.m_transformTxtInformationsCanvasAboutMe, transformTxtInformationsCanvasAboutMe);
        _goManager.m_goCanvasAboutMe.m_tmpTxtInformationsCanvasAboutMe.font = font;
        _goManager.m_goCanvasAboutMe.m_tmpTxtInformationsCanvasAboutMe.color = colorTxtInformationsCanvasAboutMe;

        ChangeRectTransform(_goManager.m_goCanvasAboutMe.m_transformImgBackTxtCanvasAboutMe, transformImgBackTxtCanvasAboutMe);
        _goManager.m_goCanvasAboutMe.m_imgImgBackTxtCanvasAboutMe.sprite = imgImgBackTxtCanvasAboutMe;
        ChangeRectTransform(_goManager.m_goCanvasAboutMe.m_transformTxtCanvasAboutMe, transformTxtCanvasAboutMe);
        _goManager.m_goCanvasAboutMe.m_tmpTxtCanvasAboutMe.font = font;
        _goManager.m_goCanvasAboutMe.m_tmpTxtCanvasAboutMe.color = colorTxtCanvasAboutMe;
    }
    /// <summary>
    /// Function use to change the position of data(s) on the Canvas About Me.
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
    #endregion
}
