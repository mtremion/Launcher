using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Sign In.
/// </summary>
[Serializable]
public class GameObjectCanvasManager
{
    #region SerializeField
    [Header("Canvas Manager")]
    [Tooltip("GameObject Canvas Manager")]
    [SerializeField] GameObject goCanvasManager;
    [Header("Background")]
    [Tooltip("Background of the Canvas Manager.")]
    [SerializeField] GameObject goBackgroundCanvasManager;
    [Header("Title")]
    [Tooltip("Title of the Canvas Manager.")]
    [SerializeField] GameObject goTitleCanvasManager;
    [Header("Toggle Mute")]
    [Tooltip("Toggle mute of the Canvas Manager.")]
    [SerializeField] GameObject goToggleMuteCanvasManager;
    [Tooltip("Background of Toggle mute of the Canvas Manager.")]
    [SerializeField] GameObject goBackgroundToggleMuteCanvasManager;
    [Tooltip("CheckMark of Toggle mute of the Canvas Manager.")]
    [SerializeField] GameObject goCheckMarkToggleMuteCanvasManager;
    [Tooltip("Label of Toggle mute of the Canvas Manager.")]
    [SerializeField] GameObject goLabelToggleMuteCanvasManager;
    [Header("DropDown Theme")]
    [Tooltip("DropDown Theme of the Canvas Manager.")]
    [SerializeField] GameObject goDropDownThemeCanvasManager;
    [Tooltip("Label DropDown Theme of the Canvas Manager.")]
    [SerializeField] GameObject goLabelDropDownThemeCanvasManager;
    [Tooltip("Arrow DropDown Theme of the Canvas Manager.")]
    [SerializeField] GameObject goArrowDropDownThemeCanvasManager;
    [Tooltip("Background Template DropDown Theme of the Canvas Manager.")]
    [SerializeField] GameObject goBackgroundTemplateDropDownThemeCanvasManager;
    [Tooltip("CheckMark Template DropDown Theme of the Canvas Manager.")]
    [SerializeField] GameObject goCheckMarkTemplateDropDownThemeCanvasManager;
    [Tooltip("Label Template DropDown Theme of the Canvas Manager.")]
    [SerializeField] GameObject goLabelTemplateDropDownThemeCanvasManager;
    [Header("DropDown Language")]
    [Tooltip("DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goDropDownLanguageCanvasManager;
    [Tooltip("Label DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goLabelDropDownLanguageCanvasManager;
    [Tooltip("Arrow DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goArrowDropDownLanguageCanvasManager;
    [Tooltip("Background Template DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goBackgroundTemplateDropDownLanguageCanvasManager;
    [Tooltip("CheckMark Template DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goCheckMarkTemplateDropDownLanguageCanvasManager;
    [Tooltip("Label Template DropDown Language of the Canvas Manager.")]
    [SerializeField] GameObject goLabelTemplateDropDownLanguageCanvasManager;
    [Header("Button Credit")]
    [Tooltip("Button Credit.")]
    [SerializeField] GameObject goBtnCreditCanvasManager;
    [Tooltip("Text Button Credit.")]
    [SerializeField] GameObject goTxtBtnCreditCanvasManager;
    [Header("PopUp Credit")]
    [Tooltip("PopUp Credit.")]
    [SerializeField] GameObject goPopUpCreditCanvasManager;
    [Tooltip("Background PopUp Credit.")]
    [SerializeField] GameObject goBackImgPopUpCreditCanvasManager;
    [Tooltip("Scrollview of Credit.")]
    [SerializeField] GameObject goSVPopUpCreditCanvasManager;
    [Tooltip("Scrollbar vertical of Credit.")]
    [SerializeField] GameObject goSBVPopUpCreditCanvasManager;
    [Tooltip("Handle Scrollbar vertical of Credit.")]
    [SerializeField] GameObject goHandleSBVPopUpCreditCanvasManager;
    [Tooltip("Text of credits.")]
    [SerializeField] GameObject[] goTxtPopUpCreditsCanvasManager;
    [Tooltip("Button Close.")]
    [SerializeField] GameObject goBtnClosePopUpCreditCanvasManager;
    [Tooltip("Text Button Close.")]
    [SerializeField] GameObject goTxtBtnClosePopUpCreditCanvasManager;
    [Header("Button Quit")]
    [Tooltip("Button Quit.")]
    [SerializeField] GameObject goBtnQuitCanvasManager;
    [Tooltip("Text Button Quit.")]
    [SerializeField] GameObject goTxtBtnQuitCanvasManager;
    [Header("Pop Up Quit")]
    [Tooltip("GameObject Pop up Quit.")]
    [SerializeField] GameObject goPopUpQuitCanvasManager;
    [Tooltip("Sprite Img back PopUp Quit.")]
    [SerializeField] GameObject goBackImgPopUpQuitCanvasManager;
    [Tooltip("Text PopUp Quit.")]
    [SerializeField] GameObject goTxtPopUpQuitCanvasManager;
    [Tooltip("Button Yes PopUp Quit.")]
    [SerializeField] GameObject goBtnYesPopUpQuitCanvasManager;
    [Tooltip("Text Button Yes PopUp Quit.")]
    [SerializeField] GameObject goTxtBtnYesPopUpQuitCanvasManager;
    [Tooltip("Button Yes PopUp Quit.")]
    [SerializeField] GameObject goBtnNoPopUpQuitCanvasManager;
    [Tooltip("Text Button Yes PopUp Quit.")]
    [SerializeField] GameObject goTxtBtnNoPopUpQuitCanvasManager;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasManager { get { return goCanvasManager; } }
    public GameObject m_goPopUpCredit{ get { return goPopUpCreditCanvasManager; } }
    public GameObject m_goPopUpQuit { get { return goPopUpQuitCanvasManager; } }

    public RectTransform m_transformBackgroundCanvasManager { get { return _transformBackgroundCanvasManager; } }
    public RectTransform m_transformTitleCanvasManager { get { return _transformTitleCanvasManager; } }
    public RectTransform m_transformToggleMuteCanvasManager { get { return _transformToggleMuteCanvasManager; } }
    public RectTransform m_transformDropDownThemeCanvasManager { get { return _transformDropDownThemeCanvasManager; } }
    public RectTransform m_transformDropDownLanguageCanvasManager { get { return _transformDropDownLanguageCanvasManager; } }
    public RectTransform m_transformBtnCreditCanvasManager { get { return _transformBtnCreditCanvasManager; } }
    public RectTransform m_transformBackImgPopUpCreditCanvasManager { get { return _transformBackImgPopUpCreditCanvasManager; } }
    public RectTransform m_transformSVPopUpCreditCanvasManager { get { return _transformSVPopUpCreditCanvasManager; } }
    public RectTransform m_transformBtnClosePopUpCreditCanvasManager { get { return _transformBtnClosePopUpCreditCanvasManager; } }
    public RectTransform m_transformBtnQuitCanvasManager { get { return _transformBtnQuitCanvasManager; } }
    public RectTransform m_transformBackImgPopUpQuitCanvasManager { get { return _transformBackImgPopUpQuitCanvasManager; } }
    public RectTransform m_transformTxtPopUpQuitCanvasManager { get { return _transformTxtPopUpQuitCanvasManager; } }
    public RectTransform m_transformBtnYesPopUpQuitCanvasManager { get { return _transformBtnYesPopUpQuitCanvasManager; } }
    public RectTransform m_transformBtnNoPopUpQuitCanvasManager { get { return _transformBtnNoPopUpQuitCanvasManager; } }

    public Image m_imgBackgroundCanvasManager { get { return _imgBackgroundCanvasManager; } }
    public Image m_imgBackgroundToggleMuteCanvasManager { get { return _imgBackgroundToggleMuteCanvasManager; } }
    public Image m_imgCheckMarkToggleMuteCanvasManager { get { return _imgCheckMarkToggleMuteCanvasManager; } }
    public Image m_imgDropDownThemeCanvasManager { get { return _imgDropDownThemeCanvasManager; } }
    public Image m_imgArrowDropDownThemeCanvasManager { get { return _imgArrowDropDownThemeCanvasManager; } }
    public Image m_imgBackgroundTemplateDropDownThemeCanvasManager { get { return _imgBackgroundTemplateDropDownThemeCanvasManager; } }
    public Image m_imgCheckMarkTemplateDropDownThemeCanvasManager { get { return _imgCheckMarkTemplateDropDownThemeCanvasManager; } }
    public Image m_imgDropDownLanguageCanvasManager { get { return _imgDropDownLanguageCanvasManager; } }
    public Image m_imgArrowDropDownLanguageCanvasManager { get { return _imgArrowDropDownLanguageCanvasManager; } }
    public Image m_imgBackgroundTemplateDropDownLanguageCanvasManager { get { return _imgBackgroundTemplateDropDownLanguageCanvasManager; } }
    public Image m_imgCheckMarkTemplateDropDownLanguageCanvasManager { get { return _imgCheckMarkTemplateDropDownLanguageCanvasManager; } }
    public Image m_imgBtnCreditCanvasManager { get { return _imgBtnCreditCanvasManager; } }
    public Image m_imgBackPopUpCreditCanvasManager { get { return _imgBackPopUpCreditCanvasManager; } }
    public Image m_imgSBVPopUpCreditCanvasManager { get { return _imgSBVPopUpCreditCanvasManager; } }
    public Image m_imgHandleSBVPopUpCreditCanvasManager { get { return _imgHandleSBVPopUpCreditCanvasManager; } }
    public Image m_imgBtnClosePopUpCreditCanvasManager { get { return _imgBtnClosePopUpCreditCanvasManager; } }
    public Image m_imgBtnQuitCanvasManager { get { return _imgBtnQuitCanvasManager; } }
    public Image m_imgBackImgPopUpQuitCanvasManager { get { return _imgBackImgPopUpQuitCanvasManager; } }
    public Image m_imgBtnYesPopUpQuitCanvasManager { get { return _imgBtnYesPopUpQuitCanvasManager; } }
    public Image m_imgBtnNoPopUpQuitCanvasManager { get { return _imgBtnNoPopUpQuitCanvasManager; } }

    public TextMeshProUGUI m_tmpTitleCanvasManager { get { return _tmpTitleCanvasManager; } }
    public TextMeshProUGUI m_tmpLabelToggleMuteCanvasManager { get { return _tmpLabelToggleMuteCanvasManager; } }
    public TextMeshProUGUI m_tmpLabelDropDownThemeCanvasManager { get { return _tmpLabelDropDownThemeCanvasManager; } }
    public TextMeshProUGUI m_tmpLabelTemplateDropDownThemeCanvasManager { get { return _tmpLabelTemplateDropDownThemeCanvasManager; } }
    public TextMeshProUGUI m_tmpLabelDropDownLanguageCanvasManager { get { return _tmpLabelDropDownLanguageCanvasManager; } }
    public TextMeshProUGUI m_tmpLabelTemplateDropDownLanguageCanvasManager { get { return _tmpLabelTemplateDropDownLanguageCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnCreditCanvasManager { get { return _tmpTxtBtnCreditCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnClosePopUpCreditCanvasManager { get { return _tmpTxtBtnClosePopUpCreditCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnQuitCanvasManager { get { return _tmpTxtBtnQuitCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtPopUpQuitCanvasManager { get { return _tmpTxtPopUpQuitCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnYesPopUpQuitCanvasManager { get { return _tmpTxtBtnYesPopUpQuitCanvasManager; } }
    public TextMeshProUGUI m_tmpTxtBtnNoPopUpQuitCanvasManager { get { return _tmpTxtBtnNoPopUpQuitCanvasManager; } }

    public TextMeshProUGUI[] m_tmpTabTxtCreditsPopUpCreditCanvasManager { get { return _tmpTabTxtCreditsPopUpCreditCanvasManager; } }

    public TMP_Dropdown m_dropDownThemeCanvasManager { get { return _dropDownThemeCanvasManager; } }
    public TMP_Dropdown m_dropDownLanguageCanvasManager { get { return _dropDownLanguageCanvasManager; } }
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    RectTransform _transformBackgroundCanvasManager = null, _transformTitleCanvasManager = null, _transformToggleMuteCanvasManager = null,
        _transformDropDownThemeCanvasManager = null, _transformDropDownLanguageCanvasManager = null, _transformBtnCreditCanvasManager = null,
        _transformBackImgPopUpCreditCanvasManager = null, _transformSVPopUpCreditCanvasManager = null, _transformBtnClosePopUpCreditCanvasManager = null, 
        _transformBtnQuitCanvasManager = null, _transformBackImgPopUpQuitCanvasManager = null, _transformTxtPopUpQuitCanvasManager = null,
        _transformBtnYesPopUpQuitCanvasManager = null, _transformBtnNoPopUpQuitCanvasManager = null;
    Image _imgBackgroundCanvasManager = null, _imgToggleMuteCanvasManager = null, _imgBackgroundToggleMuteCanvasManager = null,
        _imgCheckMarkToggleMuteCanvasManager = null, _imgDropDownThemeCanvasManager = null, _imgArrowDropDownThemeCanvasManager = null,
        _imgBackgroundTemplateDropDownThemeCanvasManager = null, _imgCheckMarkTemplateDropDownThemeCanvasManager = null, _imgDropDownLanguageCanvasManager = null,
        _imgArrowDropDownLanguageCanvasManager = null, _imgBackgroundTemplateDropDownLanguageCanvasManager = null, _imgCheckMarkTemplateDropDownLanguageCanvasManager = null,
        _imgBtnCreditCanvasManager = null, _imgBackPopUpCreditCanvasManager = null, _imgSBVPopUpCreditCanvasManager = null,
        _imgHandleSBVPopUpCreditCanvasManager = null, _imgBtnClosePopUpCreditCanvasManager = null, _imgBtnQuitCanvasManager = null,
        _imgBackImgPopUpQuitCanvasManager = null, _imgBtnYesPopUpQuitCanvasManager = null, _imgBtnNoPopUpQuitCanvasManager = null;
    TextMeshProUGUI _tmpTitleCanvasManager = null, _tmpLabelToggleMuteCanvasManager = null, _tmpLabelDropDownThemeCanvasManager = null,
        _tmpLabelTemplateDropDownThemeCanvasManager = null, _tmpLabelDropDownLanguageCanvasManager = null, _tmpLabelTemplateDropDownLanguageCanvasManager = null,
        _tmpTxtBtnCreditCanvasManager = null, _tmpTxtBtnClosePopUpCreditCanvasManager = null, _tmpTxtBtnQuitCanvasManager = null,
        _tmpTxtPopUpQuitCanvasManager = null, _tmpTxtBtnYesPopUpQuitCanvasManager = null, _tmpTxtBtnNoPopUpQuitCanvasManager = null;
    TextMeshProUGUI[] _tmpTabTxtCreditsPopUpCreditCanvasManager = null;
    TMP_Dropdown _dropDownThemeCanvasManager = null, _dropDownLanguageCanvasManager = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformBackgroundCanvasManager = goBackgroundCanvasManager.GetComponent<RectTransform>();
        _transformTitleCanvasManager = goTitleCanvasManager.GetComponent<RectTransform>();
        _transformToggleMuteCanvasManager = goToggleMuteCanvasManager.GetComponent<RectTransform>();
        _transformDropDownThemeCanvasManager = goDropDownThemeCanvasManager.GetComponent<RectTransform>();
        _transformDropDownLanguageCanvasManager = goDropDownLanguageCanvasManager.GetComponent<RectTransform>();
        _transformBtnCreditCanvasManager = goBtnCreditCanvasManager.GetComponent<RectTransform>();
        _transformBackImgPopUpCreditCanvasManager = goBackImgPopUpCreditCanvasManager.GetComponent<RectTransform>();
        _transformSVPopUpCreditCanvasManager = goSVPopUpCreditCanvasManager.GetComponent<RectTransform>();
        _transformBtnClosePopUpCreditCanvasManager = goBtnClosePopUpCreditCanvasManager.GetComponent<RectTransform>();
        _transformBtnQuitCanvasManager = goBtnQuitCanvasManager.GetComponent<RectTransform>();
        _transformBackImgPopUpQuitCanvasManager = goBackImgPopUpQuitCanvasManager.GetComponent<RectTransform>();
        _transformTxtPopUpQuitCanvasManager = goTxtPopUpQuitCanvasManager.GetComponent<RectTransform>();
        _transformBtnYesPopUpQuitCanvasManager = goBtnYesPopUpQuitCanvasManager.GetComponent<RectTransform>();
        _transformBtnNoPopUpQuitCanvasManager = goBtnNoPopUpQuitCanvasManager.GetComponent<RectTransform>();

        _imgBackgroundCanvasManager = goBackgroundCanvasManager.GetComponent<Image>();
        _imgBackgroundToggleMuteCanvasManager = goBackgroundToggleMuteCanvasManager.GetComponent<Image>();
        _imgCheckMarkToggleMuteCanvasManager = goCheckMarkToggleMuteCanvasManager.GetComponent<Image>();
        _imgDropDownThemeCanvasManager = goDropDownThemeCanvasManager.GetComponent<Image>();
        _imgArrowDropDownThemeCanvasManager = goArrowDropDownThemeCanvasManager.GetComponent<Image>();
        _imgBackgroundTemplateDropDownThemeCanvasManager = goBackgroundTemplateDropDownThemeCanvasManager.GetComponent<Image>();
        _imgCheckMarkTemplateDropDownThemeCanvasManager = goCheckMarkTemplateDropDownThemeCanvasManager.GetComponent<Image>();
        _imgDropDownLanguageCanvasManager = goDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgArrowDropDownLanguageCanvasManager = goArrowDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgBackgroundTemplateDropDownLanguageCanvasManager = goBackgroundTemplateDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgCheckMarkTemplateDropDownLanguageCanvasManager = goCheckMarkTemplateDropDownLanguageCanvasManager.GetComponent<Image>();
        _imgBtnCreditCanvasManager = goBtnCreditCanvasManager.GetComponent<Image>();
        _imgBackPopUpCreditCanvasManager = goBackImgPopUpCreditCanvasManager.GetComponent<Image>();
        _imgSBVPopUpCreditCanvasManager = goSBVPopUpCreditCanvasManager.GetComponent<Image>();
        _imgHandleSBVPopUpCreditCanvasManager = goHandleSBVPopUpCreditCanvasManager.GetComponent<Image>();
        _imgBtnClosePopUpCreditCanvasManager = goBtnClosePopUpCreditCanvasManager.GetComponent<Image>();
        _imgBtnQuitCanvasManager = goBtnQuitCanvasManager.GetComponent<Image>();
        _imgBackImgPopUpQuitCanvasManager = goBackImgPopUpQuitCanvasManager.GetComponent<Image>();
        _imgBtnYesPopUpQuitCanvasManager = goBtnYesPopUpQuitCanvasManager.GetComponent<Image>();
        _imgBtnNoPopUpQuitCanvasManager = goBtnNoPopUpQuitCanvasManager.GetComponent<Image>();

        _tmpTitleCanvasManager = goTitleCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpLabelToggleMuteCanvasManager = goLabelToggleMuteCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpLabelDropDownThemeCanvasManager = goLabelDropDownThemeCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpLabelTemplateDropDownThemeCanvasManager = goLabelTemplateDropDownThemeCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpLabelDropDownLanguageCanvasManager = goLabelDropDownLanguageCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpLabelTemplateDropDownLanguageCanvasManager = goLabelTemplateDropDownLanguageCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnCreditCanvasManager = goTxtBtnCreditCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnClosePopUpCreditCanvasManager = goTxtBtnClosePopUpCreditCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnQuitCanvasManager = goTxtBtnQuitCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtPopUpQuitCanvasManager = goTxtPopUpQuitCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnYesPopUpQuitCanvasManager = goTxtBtnYesPopUpQuitCanvasManager.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnNoPopUpQuitCanvasManager = goTxtBtnNoPopUpQuitCanvasManager.GetComponent<TextMeshProUGUI>();

        _tmpTabTxtCreditsPopUpCreditCanvasManager = new TextMeshProUGUI[goTxtPopUpCreditsCanvasManager.Length];
        for(int i = 0; i < goTxtPopUpCreditsCanvasManager.Length; i++)
        {
            _tmpTabTxtCreditsPopUpCreditCanvasManager[i] = goTxtPopUpCreditsCanvasManager[i].GetComponent<TextMeshProUGUI>();
        }

        _dropDownThemeCanvasManager = goDropDownThemeCanvasManager.GetComponent<TMP_Dropdown>();
        _dropDownLanguageCanvasManager = goDropDownLanguageCanvasManager.GetComponent<TMP_Dropdown>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will reinitialize info text and input block Color for the Canvas Manager.
    /// </summary>
    public void ReinitializeAllCanvasManager()
    {

    }
    #endregion
}
