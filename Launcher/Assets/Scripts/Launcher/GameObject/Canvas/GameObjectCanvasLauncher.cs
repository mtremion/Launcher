using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Launcher.
/// </summary>
[Serializable]
public class GameObjectCanvasLauncher
{
    #region SerializeField
    [Header("Canvas Launcher")]
    [Tooltip("GameObject Canvas Launcher")]
    [SerializeField] GameObject goCanvasLauncher;
    [Header("Background")]
    [Tooltip("Background of the Canvas Launcher.")]
    [SerializeField] GameObject goBackgroundCanvasLauncher;
    [Header("Button Home")]
    [Tooltip("Button Home of the Canvas Launcher.")]
    [SerializeField] GameObject goBtnHomeCanvasLauncher;
    [Tooltip("Txt Button Home of the Canvas Launcher.")]
    [SerializeField] GameObject goTxtBtnHomeCanvasLauncher;
    [Header("Canvas Home")]
    [Tooltip("GameObject Canvas Home")]
    [SerializeField] GameObject goCanvasHome;
    [Header("Button Librairy")]
    [Tooltip("Button Librairy of the Canvas Launcher.")]
    [SerializeField] GameObject goBtnLibrairyCanvasLauncher;
    [Tooltip("Txt Button Librairy of the Canvas Launcher.")]
    [SerializeField] GameObject goTxtBtnLibrairyCanvasLauncher;
    [Header("Canvas Librairy")]
    [Tooltip("GameObject Canvas Librairy")]
    [SerializeField] GameObject goCanvasLibrairy;
    [Header("Button AboutMe")]
    [Tooltip("Button AboutMe of the Canvas Launcher.")]
    [SerializeField] GameObject goBtnAboutMeCanvasLauncher;
    [Tooltip("Txt Button AboutMe of the Canvas Launcher.")]
    [SerializeField] GameObject goTxtBtnAboutMeCanvasLauncher;
    [Header("Canvas AboutMe")]
    [Tooltip("GameObject Canvas AboutMe")]
    [SerializeField] GameObject goCanvasAboutMe;
    [Header("Button Contact")]
    [Tooltip("Button Contact of the Canvas Launcher.")]
    [SerializeField] GameObject goBtnContactCanvasLauncher;
    [Tooltip("Txt Button Contact of the Canvas Launcher.")]
    [SerializeField] GameObject goTxtBtnContactCanvasLauncher;
    [Header("Canvas Contact")]
    [Tooltip("GameObject Canvas Contact")]
    [SerializeField] GameObject goCanvasContact;
    [Header("Button Profil")]
    [Tooltip("Button Profil of the Canvas Launcher.")]
    [SerializeField] GameObject goBtnProfilCanvasLauncher;
    [Tooltip("Txt Button Profil of the Canvas Launcher.")]
    [SerializeField] GameObject goTxtBtnProfilCanvasLauncher;
    [Header("Canvas Profil")]
    [Tooltip("GameObject Canvas Profil")]
    [SerializeField] GameObject goCanvasProfil;
    [Header("Button Deconnection")]
    [Tooltip("Button Deconnection of the Canvas Launcher.")]
    [SerializeField] GameObject goBtnDeconnectionCanvasLauncher;
    [Header("Pop Up Deconnection")]
    [Tooltip("GameObject Pop up Deconnection.")]
    [SerializeField] GameObject goPopUpDeconnectionCanvasLauncher;
    [Tooltip("Sprite Img back PopUp Deconnection.")]
    [SerializeField] GameObject goImgBackPopUpDeconnectionCanvasLauncher;
    [Tooltip("Text PopUp Deconnection.")]
    [SerializeField] GameObject goTxtPopUpDeconnectionCanvasLauncher;
    [Tooltip("Button Yes PopUp Deconnection.")]
    [SerializeField] GameObject goBtnYesPopUpDeconnectionCanvasLauncher;
    [Tooltip("Text Button Yes PopUp Deconnection.")]
    [SerializeField] GameObject goTxtBtnYesPopUpDeconnectionCanvasLauncher;
    [Tooltip("Button Yes PopUp Deconnection.")]
    [SerializeField] GameObject goBtnNoPopUpDeconnectionCanvasLauncher;
    [Tooltip("Text Button Yes PopUp Deconnection.")]
    [SerializeField] GameObject goTxtBtnNoPopUpDeconnectionCanvasLauncher;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasLauncher { get { return goCanvasLauncher; } }
    public GameObject m_goCanvasHome { get { return goCanvasHome; } }
    public GameObject m_goCanvasLibrairy{ get { return goCanvasLibrairy; } }
    public GameObject m_goCanvasAboutMe { get { return goCanvasAboutMe; } }
    public GameObject m_goCanvasContact { get { return goCanvasContact; } }
    public GameObject m_goCanvasProfil { get { return goCanvasProfil; } }
    public GameObject m_goPopUpDeconnection { get { return goPopUpDeconnectionCanvasLauncher; } }

    public RectTransform m_transformBackgroundCanvasLauncher { get { return _transformBackgroundCanvasLauncher; } }
    public RectTransform m_transformBtnHomeCanvasLauncher { get { return _transformBtnHomeCanvasLauncher; } }
    public RectTransform m_transformBtnLibrairyCanvasLauncher { get { return _transformBtnLibrairyCanvasLauncher; } }
    public RectTransform m_transformBtnAboutMeCanvasLauncher { get { return _transformBtnAboutMeCanvasLauncher; } }
    public RectTransform m_transformBtnContactCanvasLauncher { get { return _transformBtnContactCanvasLauncher; } }
    public RectTransform m_transformBtnProfilCanvasLauncher { get { return _transformBtnProfilCanvasLauncher; } }
    public RectTransform m_transformBtnDeconnectionCanvasLauncher { get { return _transformBtnDeconnectionCanvasLauncher; } }
    public RectTransform m_transformImgBackPopUpDeconnectionCanvasLauncher { get { return _transformImgBackPopUpDeconnectionCanvasLauncher; } }
    public RectTransform m_transformTxtPopUpDeconnectionCanvasLauncher { get { return _transformTxtPopUpDeconnectionCanvasLauncher; } }
    public RectTransform m_transformBtnYesPopUpDeconnectionCanvasLauncher { get { return _transformBtnYesPopUpDeconnectionCanvasLauncher; } }
    public RectTransform m_transformBtnNoPopUpDeconnectionCanvasLauncher { get { return _transformBtnNoPopUpDeconnectionCanvasLauncher; } }

    public Image m_imgBackgroundCanvasLauncher { get { return _imgBackgroundCanvasLauncher; } }
    public Image m_imgBtnDeconnectionCanvasLauncher { get { return _imgBtnDeconnectionCanvasLauncher; } }
    public Image m_imgImgBackPopUpDeconnectionCanvasLauncher { get { return _imgImgBackPopUpDeconnectionCanvasLauncher; } }
    public Image m_imgBtnYesPopUpDeconnectionCanvasLauncher { get { return _imgBtnYesPopUpDeconnectionCanvasLauncher; } }
    public Image m_imgBtnNoPopUpDeconnectionCanvasLauncher { get { return _imgBtnNoPopUpDeconnectionCanvasLauncher; } }

    public TextMeshProUGUI m_tmpTxtBtnHomeCanvasLauncher { get { return _tmpTxtBtnHomeCanvasLauncher; } }
    public TextMeshProUGUI m_tmpTxtBtnLibrairyCanvasLauncher { get { return _tmpTxtBtnLibrairyCanvasLauncher; } }
    public TextMeshProUGUI m_tmpTxtBtnAboutMeCanvasLauncher { get { return _tmpTxtBtnAboutMeCanvasLauncher; } }
    public TextMeshProUGUI m_tmpTxtBtnContactCanvasLauncher { get { return _tmpTxtBtnContactCanvasLauncher; } }
    public TextMeshProUGUI m_tmpTxtBtnProfilCanvasLauncher { get { return _tmpTxtBtnProfilCanvasLauncher; } }
    public TextMeshProUGUI m_tmpTxtPopUpDeconnectionCanvasLauncher { get { return _tmpTxtPopUpDeconnectionCanvasLauncher; } }
    public TextMeshProUGUI m_tmpTxtBtnYesPopUpDeconnectionCanvasLauncher { get { return _tmpTxtBtnYesPopUpDeconnectionCanvasLauncher; } }
    public TextMeshProUGUI m_tmpTxtBtnNoPopUpDeconnectionCanvasLauncher { get { return _tmpTxtBtnNoPopUpDeconnectionCanvasLauncher; } }
   
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    RectTransform _transformBackgroundCanvasLauncher = null, _transformBtnHomeCanvasLauncher = null, _transformBtnLibrairyCanvasLauncher = null,
        _transformBtnAboutMeCanvasLauncher = null, _transformBtnContactCanvasLauncher = null, _transformBtnProfilCanvasLauncher = null,
        _transformBtnDeconnectionCanvasLauncher = null, _transformImgBackPopUpDeconnectionCanvasLauncher = null, _transformTxtPopUpDeconnectionCanvasLauncher = null,
        _transformBtnYesPopUpDeconnectionCanvasLauncher = null, _transformBtnNoPopUpDeconnectionCanvasLauncher = null;
    Image _imgBackgroundCanvasLauncher = null, _imgBtnDeconnectionCanvasLauncher = null, _imgImgBackPopUpDeconnectionCanvasLauncher = null,
        _imgBtnYesPopUpDeconnectionCanvasLauncher = null, _imgBtnNoPopUpDeconnectionCanvasLauncher = null;
    TextMeshProUGUI _tmpTxtBtnHomeCanvasLauncher = null, _tmpTxtBtnLibrairyCanvasLauncher = null, _tmpTxtBtnAboutMeCanvasLauncher = null,
        _tmpTxtBtnContactCanvasLauncher = null, _tmpTxtBtnProfilCanvasLauncher = null, _tmpTxtPopUpDeconnectionCanvasLauncher = null,
        _tmpTxtBtnYesPopUpDeconnectionCanvasLauncher = null, _tmpTxtBtnNoPopUpDeconnectionCanvasLauncher = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformBackgroundCanvasLauncher = goBackgroundCanvasLauncher.GetComponent<RectTransform>();
        _transformBtnHomeCanvasLauncher = goBtnHomeCanvasLauncher.GetComponent<RectTransform>();
        _transformBtnLibrairyCanvasLauncher = goBtnLibrairyCanvasLauncher.GetComponent<RectTransform>();
        _transformBtnAboutMeCanvasLauncher = goBtnAboutMeCanvasLauncher.GetComponent<RectTransform>();
        _transformBtnContactCanvasLauncher = goBtnContactCanvasLauncher.GetComponent<RectTransform>();
        _transformBtnProfilCanvasLauncher = goBtnProfilCanvasLauncher.GetComponent<RectTransform>();
        _transformBtnDeconnectionCanvasLauncher = goBtnDeconnectionCanvasLauncher.GetComponent<RectTransform>();
        _transformImgBackPopUpDeconnectionCanvasLauncher = goImgBackPopUpDeconnectionCanvasLauncher.GetComponent<RectTransform>();
        _transformTxtPopUpDeconnectionCanvasLauncher = goTxtPopUpDeconnectionCanvasLauncher.GetComponent<RectTransform>();
        _transformBtnYesPopUpDeconnectionCanvasLauncher = goBtnYesPopUpDeconnectionCanvasLauncher.GetComponent<RectTransform>();
        _transformBtnNoPopUpDeconnectionCanvasLauncher = goBtnNoPopUpDeconnectionCanvasLauncher.GetComponent<RectTransform>();

        _imgBackgroundCanvasLauncher = goBackgroundCanvasLauncher.GetComponent<Image>();
        _imgBtnDeconnectionCanvasLauncher = goBtnDeconnectionCanvasLauncher.GetComponent<Image>();
        _imgImgBackPopUpDeconnectionCanvasLauncher = goImgBackPopUpDeconnectionCanvasLauncher.GetComponent<Image>();
        _imgBtnYesPopUpDeconnectionCanvasLauncher = goBtnYesPopUpDeconnectionCanvasLauncher.GetComponent<Image>();
        _imgBtnNoPopUpDeconnectionCanvasLauncher = goBtnNoPopUpDeconnectionCanvasLauncher.GetComponent<Image>();

        _tmpTxtBtnHomeCanvasLauncher = goTxtBtnHomeCanvasLauncher.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnLibrairyCanvasLauncher = goTxtBtnLibrairyCanvasLauncher.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnAboutMeCanvasLauncher = goTxtBtnAboutMeCanvasLauncher.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnContactCanvasLauncher = goTxtBtnContactCanvasLauncher.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnProfilCanvasLauncher = goTxtBtnProfilCanvasLauncher.GetComponent<TextMeshProUGUI>();
        _tmpTxtPopUpDeconnectionCanvasLauncher = goTxtPopUpDeconnectionCanvasLauncher.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnYesPopUpDeconnectionCanvasLauncher = goTxtBtnYesPopUpDeconnectionCanvasLauncher.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnNoPopUpDeconnectionCanvasLauncher = goTxtBtnNoPopUpDeconnectionCanvasLauncher.GetComponent<TextMeshProUGUI>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will reinitialize info text and input block Color for the Canvas Launcher.
    /// </summary>
    public void ReinitializeAllCanvasLauncher()
    {

    }
    #endregion
}
