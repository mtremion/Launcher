using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Contact
/// </summary>
[Serializable]
public class ThemeCanvasContact
{
    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Canvas Contact / Text")]
    [Tooltip("Sprite of Background of part Text.")]
    [SerializeField] Sprite imgImgBackTxtCanvasContact;
    [Tooltip("Position of Background of part Text.")]
    [SerializeField] RectTransform transformImgBackTxtCanvasContact;
    [Tooltip("Color of text Text.")]
    [SerializeField] Color colorTxtCanvasContact;
    [Tooltip("Position of text Text.")]
    [SerializeField] RectTransform transformTxtCanvasContact;
    [Header("Canvas Contact / Buttons")]
    [Tooltip("Sprite of Background of part Buttons.")]
    [SerializeField] Sprite imgImgBackBtnCanvasContact;
    [Tooltip("Position of Background of part Buttons.")]
    [SerializeField] RectTransform transformImgBackBtnCanvasContact;
    [Tooltip("Sprite of Button Facebook.")]
    [SerializeField] Sprite imgBtnFacebookCanvasContact;
    [Tooltip("Position of Button Facebook.")]
    [SerializeField] RectTransform transformBtnFacebookCanvasContact;
    [Tooltip("Sprite of Button Linkedin.")]
    [SerializeField] Sprite imgBtnLinkedinCanvasContact;
    [Tooltip("Position of Button Linkedin.")]
    [SerializeField] RectTransform transformBtnLinkedinCanvasContact;
    [Tooltip("Sprite of Button CV.")]
    [SerializeField] Sprite imgBtnCVCanvasContact;
    [Tooltip("Position of Button CV.")]
    [SerializeField] RectTransform transformBtnCVCanvasContact;
    [Tooltip("Sprite of Button GitHub.")]
    [SerializeField] Sprite imgBtnGitHubCanvasContact;
    [Tooltip("Position of Button GitHub.")]
    [SerializeField] RectTransform transformBtnGitHubCanvasContact;
    [Tooltip("Sprite of Button Web Site.")]
    [SerializeField] Sprite imgBtnWebSiteCanvasContact;
    [Tooltip("Position of Button Facebook.")]
    [SerializeField] RectTransform transformBtnWebSiteCanvasContact;
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
    /// Function use to change the theme on the Contact.
    /// </summary>
    public void ChangeThemeCanvasContact()
    {
        ChangeRectTransform(_goManager.m_goCanvasContact.m_transformImgBackTxtCanvasContact, transformImgBackTxtCanvasContact);
        _goManager.m_goCanvasContact.m_imgImgBackTxtCanvasContact.sprite = imgImgBackTxtCanvasContact;

        ChangeRectTransform(_goManager.m_goCanvasContact.m_transformTxtCanvasContact, transformTxtCanvasContact);
        _goManager.m_goCanvasContact.m_tmpTxtCanvasContact.font = font;
        _goManager.m_goCanvasContact.m_tmpTxtCanvasContact.color = colorTxtCanvasContact;

        ChangeRectTransform(_goManager.m_goCanvasContact.m_transformImgBackBtnCanvasContact, transformImgBackBtnCanvasContact);
        _goManager.m_goCanvasContact.m_imgImgBackBtnCanvasContact.sprite = imgImgBackBtnCanvasContact;

        ChangeRectTransform(_goManager.m_goCanvasContact.m_transformBtnFacebookCanvasContact, transformBtnFacebookCanvasContact);
        _goManager.m_goCanvasContact.m_imgBtnFacebookCanvasContact.sprite = imgBtnFacebookCanvasContact;

        ChangeRectTransform(_goManager.m_goCanvasContact.m_transformBtnLinkedinCanvasContact, transformBtnLinkedinCanvasContact);
        _goManager.m_goCanvasContact.m_imgBtnLinkedinCanvasContact.sprite = imgBtnLinkedinCanvasContact;

        ChangeRectTransform(_goManager.m_goCanvasContact.m_transformBtnCVCanvasContact, transformBtnCVCanvasContact);
        _goManager.m_goCanvasContact.m_imgBtnCVCanvasContact.sprite = imgBtnCVCanvasContact;

        ChangeRectTransform(_goManager.m_goCanvasContact.m_transformBtnGitHubCanvasContact, transformBtnGitHubCanvasContact);
        _goManager.m_goCanvasContact.m_imgBtnGitHubCanvasContact.sprite = imgBtnGitHubCanvasContact;

        ChangeRectTransform(_goManager.m_goCanvasContact.m_transformBtnWebSiteCanvasContact, transformBtnWebSiteCanvasContact);
        _goManager.m_goCanvasContact.m_imgBtnWebSiteCanvasContact.sprite = imgBtnWebSiteCanvasContact;   
    }
    /// <summary>
    /// Function use to change the position of data(s) on the Canvas Contact.
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
