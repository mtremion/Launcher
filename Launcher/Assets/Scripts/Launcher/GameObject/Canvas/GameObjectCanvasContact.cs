using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Contact.
/// </summary>
[Serializable]
public class GameObjectCanvasContact
{
    #region SerializeField
    [Header("Canvas Contact / Text")]
    [Tooltip("Background of part Text.")]
    [SerializeField] GameObject goImgBackTxtCanvasContact;
    [Tooltip("Text.")]
    [SerializeField] GameObject goTxtCanvasContact;
    [Header("Canvas Contact / Button")]
    [Tooltip("Background of part Button.")]
    [SerializeField] GameObject goImgBackBtnCanvasContact;
    [Tooltip("Button Facebook.")]
    [SerializeField] GameObject goBtnFacebookCanvasContact;
    [Tooltip("Button Linkedin.")]
    [SerializeField] GameObject goBtnLinkedinCanvasContact;
    [Tooltip("Button CV.")]
    [SerializeField] GameObject goBtnCVCanvasContact;
    [Tooltip("Button GitHub.")]
    [SerializeField] GameObject goBtnGitHubCanvasContact;
    [Tooltip("Button Web Site.")]
    [SerializeField] GameObject goBtnWebSiteCanvasContact;
    #endregion

    #region Getters & Setters
    public RectTransform m_transformImgBackTxtCanvasContact { get { return _transformImgBackTxtCanvasContact; } }
    public RectTransform m_transformTxtCanvasContact { get { return _transformTxtCanvasContact; } }
    public RectTransform m_transformImgBackBtnCanvasContact { get { return _transformImgBackBtnCanvasContact; } }
    public RectTransform m_transformBtnFacebookCanvasContact { get { return _transformBtnFacebookCanvasContact; } }
    public RectTransform m_transformBtnLinkedinCanvasContact { get { return _transformBtnLinkedinCanvasContact; } }
    public RectTransform m_transformBtnCVCanvasContact { get { return _transformBtnCVCanvasContact; } }
    public RectTransform m_transformBtnGitHubCanvasContact { get { return _transformBtnGitHubCanvasContact; } }
    public RectTransform m_transformBtnWebSiteCanvasContact { get { return _transformBtnWebSiteCanvasContact; } }

    public Image m_imgImgBackTxtCanvasContact { get { return _imgImgBackTxtCanvasContact; } }
    public Image m_imgImgBackBtnCanvasContact { get { return _imgImgBackBtnCanvasContact; } }
    public Image m_imgBtnFacebookCanvasContact { get { return _imgBtnFacebookCanvasContact; } }
    public Image m_imgBtnLinkedinCanvasContact { get { return _imgBtnLinkedinCanvasContact; } }
    public Image m_imgBtnCVCanvasContact { get { return _imgBtnCVCanvasContact; } }
    public Image m_imgBtnGitHubCanvasContact { get { return _imgBtnGitHubCanvasContact; } }
    public Image m_imgBtnWebSiteCanvasContact { get { return _imgBtnWebSiteCanvasContact; } }

    public TextMeshProUGUI m_tmpTxtCanvasContact { get { return _tmpTxtCanvasContact; } }
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    RectTransform _transformImgBackTxtCanvasContact = null, _transformTxtCanvasContact = null, _transformImgBackBtnCanvasContact = null,
        _transformBtnFacebookCanvasContact = null, _transformBtnLinkedinCanvasContact = null, _transformBtnCVCanvasContact = null,
        _transformBtnGitHubCanvasContact = null, _transformBtnWebSiteCanvasContact = null;
    Image _imgImgBackTxtCanvasContact = null, _imgImgBackBtnCanvasContact = null, _imgBtnFacebookCanvasContact = null,
        _imgBtnLinkedinCanvasContact = null, _imgBtnCVCanvasContact = null, _imgBtnGitHubCanvasContact = null,
        _imgBtnWebSiteCanvasContact = null;
    TextMeshProUGUI _tmpTxtCanvasContact = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformImgBackTxtCanvasContact = goImgBackTxtCanvasContact.GetComponent<RectTransform>();
        _transformTxtCanvasContact = goTxtCanvasContact.GetComponent<RectTransform>();
        _transformImgBackBtnCanvasContact = goImgBackBtnCanvasContact.GetComponent<RectTransform>();
        _transformBtnFacebookCanvasContact = goBtnFacebookCanvasContact.GetComponent<RectTransform>();
        _transformBtnLinkedinCanvasContact = goBtnLinkedinCanvasContact.GetComponent<RectTransform>();
        _transformBtnCVCanvasContact = goBtnCVCanvasContact.GetComponent<RectTransform>();
        _transformBtnGitHubCanvasContact = goBtnGitHubCanvasContact.GetComponent<RectTransform>();
        _transformBtnWebSiteCanvasContact = goBtnWebSiteCanvasContact.GetComponent<RectTransform>();

        _imgImgBackTxtCanvasContact = goImgBackTxtCanvasContact.GetComponent<Image>();
        _imgImgBackBtnCanvasContact = goImgBackBtnCanvasContact.GetComponent<Image>();
        _imgBtnFacebookCanvasContact = goBtnFacebookCanvasContact.GetComponent<Image>();
        _imgBtnLinkedinCanvasContact = goBtnLinkedinCanvasContact.GetComponent<Image>();
        _imgBtnCVCanvasContact = goBtnCVCanvasContact.GetComponent<Image>();
        _imgBtnGitHubCanvasContact = goBtnGitHubCanvasContact.GetComponent<Image>();
        _imgBtnWebSiteCanvasContact = goBtnWebSiteCanvasContact.GetComponent<Image>();

        _tmpTxtCanvasContact = goTxtCanvasContact.GetComponent<TextMeshProUGUI>();
    }
    #endregion
}
