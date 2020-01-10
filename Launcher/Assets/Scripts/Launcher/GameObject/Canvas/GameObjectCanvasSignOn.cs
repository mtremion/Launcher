using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Sign On.
/// </summary>
[Serializable]
public class GameObjectCanvasSignOn
{
    #region SerializeField
    [Header("Canvas Sign On")]
    [Tooltip("GameObject Canvas Sign On.")]
    [SerializeField] GameObject goCanvasSignOn;
    [Header("Background")]
    [Tooltip("Background of the Canvas Sign On.")]
    [SerializeField] GameObject goBackgroundCanvasSignOn;
    [Header("Title")]
    [Tooltip("Title of the Canvas Sign On.")]
    [SerializeField] GameObject goTitleCanvasSignOn;
    [Header("Input Pseudo")]
    [Tooltip("Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goInputPseudoCanvasSignOn;
    [Tooltip("Placeholder Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goPHInputPseudoCanvasSignOn;
    [Tooltip("Text Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputPseudoCanvasSignOn;
    [Header("Button Pseudo")]
    [Tooltip("Button pseudo exist of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnPseudoExistCanvasSignOn;
    [Header("Info Pseudo")]
    [Tooltip("Text info pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoPseudoCanvasSignOn;
    [Header("Input Password")]
    [Tooltip("Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goInputPasswordCanvasSignOn;
    [Tooltip("Placeholder Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goPHInputPasswordCanvasSignOn;
    [Tooltip("Text Input pseudo of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputPasswordCanvasSignOn;
    [Header("Button Password")]
    [Tooltip("Button password visible of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnPasswordVisibleCanvasSignOn;
    [Header("Info Password")]
    [Tooltip("Text info password of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoPasswordCanvasSignOn;
    [Header("Input Email")]
    [Tooltip("Input email of the Canvas Sign On.")]
    [SerializeField] GameObject goInputEmailCanvasSignOn;
    [Tooltip("Placeholder Input email of the Canvas Sign On.")]
    [SerializeField] GameObject goPHInputEmailCanvasSignOn;
    [Tooltip("Text Input email of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputEmailCanvasSignOn;
    [Header("Info Email")]
    [Tooltip("Text info email of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoEmailCanvasSignOn;
    [Header("Input First Name")]
    [Tooltip("Input First Name of the Canvas Sign On.")]
    [SerializeField] GameObject goInputFirstNameCanvasSignOn;
    [Tooltip("Placeholder Input First Name of the Canvas Sign On.")]
    [SerializeField] GameObject goPHInputFirstNameCanvasSignOn;
    [Tooltip("Text Input First Name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputFirstNameCanvasSignOn;
    [Header("Info First Name")]
    [Tooltip("Text info first name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoFirstNameCanvasSignOn;
    [Header("Input Last Name")]
    [Tooltip("Input Last Name of the Canvas Sign On.")]
    [SerializeField] GameObject goInputLastNameCanvasSignOn;
    [Tooltip("Placeholder Input Last Name of the Canvas Sign On.")]
    [SerializeField] GameObject goPHInputLastNameCanvasSignOn;
    [Tooltip("Text Input Last Name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInputLastNameCanvasSignOn;
    [Header("Info Last Name")]
    [Tooltip("Text info last name of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtInfoLastNameCanvasSignOn;
    [Header("Register")]
    [Tooltip("Button Register of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnRegisterCanvasSignOn;
    [Tooltip("Text Button Register of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtBtnRegisterCanvasSignOn;
    [Header("Back")]
    [Tooltip("Button Back of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnBackCanvasSignOn;
    [Tooltip("Text Button Back of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtBtnBackCanvasSignOn;
    [Header("PopUp Register")]
    [Tooltip("PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goPopUpRegisterCanvasSignOn;
    [Tooltip("PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goImgPopUpRegisterCanvasSignOn;
    [Tooltip("Text PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtPopUpRegisterCanvasSignOn;
    [Tooltip("Button PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goBtnPopUpRegisterCanvasSignOn;
    [Tooltip("Button PopUp Register of the Canvas Sign On.")]
    [SerializeField] GameObject goTxtBtnPopUpRegisterCanvasSignOn;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasSignOn { get { return goCanvasSignOn; } }
    public GameObject m_goPopUpRegisterCanvasSignOn { get { return goPopUpRegisterCanvasSignOn; } }

    public RectTransform m_transformBackgroundCanvasSignOn { get { return _transformBackgroundCanvasSignOn; } }
    public RectTransform m_transformTitleCanvasSignOn { get { return _transformTitleCanvasSignOn; } }
    public RectTransform m_transformInputPseudoCanvasSignOn { get { return _transformInputPseudoCanvasSignOn; } }
    public RectTransform m_transformBtnPseudoExistCanvasSignOn { get { return _transformBtnPseudoExistCanvasSignOn; } }
    public RectTransform m_transformTxtInfoPseudoCanvasSignOn { get { return _transformTxtInfoPseudoCanvasSignOn; } }
    public RectTransform m_transformInputPasswordCanvasSignOn { get { return _transformInputPasswordCanvasSignOn; } }
    public RectTransform m_transformBtnPasswordVisibleCanvasSignOn { get { return _transformBtnPasswordVisibleCanvasSignOn; } }
    public RectTransform m_transformTxtInfoPasswordCanvasSignOn { get { return _transformTxtInfoPasswordCanvasSignOn; } }
    public RectTransform m_transformInputEmailCanvasSignOn { get { return _transformInputEmailCanvasSignOn; } }
    public RectTransform m_transformTxtInfoEmailCanvasSignOn { get { return _transformTxtInfoEmailCanvasSignOn; } }
    public RectTransform m_transformInputFirstNameCanvasSignOn { get { return _transformInputFirstNameCanvasSignOn; } }
    public RectTransform m_transformTxtInfoFirstNameCanvasSignOn { get { return _transformTxtInfoFirstNameCanvasSignOn; } }
    public RectTransform m_transformInputLastNameCanvasSignOn { get { return _transformInputLastNameCanvasSignOn; } }
    public RectTransform m_transformTxtInfoLastNameCanvasSignOn { get { return _transformTxtInfoLastNameCanvasSignOn; } }
    public RectTransform m_transformBtnRegisterCanvasSignOn { get { return _transformBtnRegisterCanvasSignOn; } }
    public RectTransform m_transformBtnBackCanvasSignOn { get { return _transformBtnBackCanvasSignOn; } }
    public RectTransform m_transformPopUpRegisterCanvasSignOn { get { return _transformPopUpRegisterCanvasSignOn; } }
    public RectTransform m_transformImgPopUpRegisterCanvasSignOn { get { return _transformImgPopUpRegisterCanvasSignOn; } }
    public RectTransform m_transformTxtPopUpRegisterCanvasSignOn { get { return _transformTxtPopUpRegisterCanvasSignOn; } }
    public RectTransform m_transformBtnPopUpRegisterCanvasSignOn { get { return _transformBtnPopUpRegisterCanvasSignOn; } }

    public Image m_imgBackgroundCanvasSignOn { get { return _imgBackgroundCanvasSignOn; } }
    public Image m_imgInputPseudoCanvasSignOn { get { return _imgInputPseudoCanvasSignOn; } }
    public Image m_imgBtnPseudoExistCanvasSignOn { get { return _imgBtnPseudoExistCanvasSignOn; } }
    public Image m_imgInputPasswordCanvasSignOn { get { return _imgInputPasswordCanvasSignOn; } }
    public Image m_imgBtnPasswordVisibleCanvasSignOn { get { return _imgBtnPasswordVisibleCanvasSignOn; } }
    public Image m_imgInputEmailCanvasSignOn { get { return _imgInputEmailCanvasSignOn; } }
    public Image m_imgInputFirstNameCanvasSignOn { get { return _imgInputFirstNameCanvasSignOn; } }
    public Image m_imgInputLastNameCanvasSignOn { get { return _imgInputLastNameCanvasSignOn; }  }
    public Image m_imgBtnRegisterCanvasSignOn { get { return _imgBtnRegisterCanvasSignOn; }  }
    public Image m_imgBtnBackCanvasSignOn { get { return _imgBtnBackCanvasSignOn; } }
    public Image m_imgPopUpRegisterCanvasSignOn { get { return _imgPopUpRegisterCanvasSignOn; } }
    public Image m_imgBtnPopUpRegisterCanvasSignOn { get { return _imgBtnPopUpRegisterCanvasSignOn; } }

    public TMP_InputField m_inputPseudoCanvasSignOn { get { return _inputPseudoCanvasSignOn; } }
    public TMP_InputField m_inputPasswordCanvasSignOn { get { return _inputPasswordCanvasSignOn; } }
    public TMP_InputField m_inputEmailCanvasSignOn { get { return _inputEmailCanvasSignOn; } }
    public TMP_InputField m_inputFirstNameCanvasSignOn { get { return _inputFirstNameCanvasSignOn; } }
    public TMP_InputField m_inputLastNameCanvasSignOn { get { return _inputLastNameCanvasSignOn; } }

    public TextMeshProUGUI m_tmpTitleCanvasSignOn { get { return _tmpTitleCanvasSignOn; } }
    public TextMeshProUGUI m_tmpPHInputPseudoCanvasSignOn { get { return _tmpPHInputPseudoCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputPseudoCanvasSignOn { get { return _tmpTxtInputPseudoCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoPseudoCanvasSignOn { get { return _tmpTxtInfoPseudoCanvasSignOn; } }
    public TextMeshProUGUI m_tmpPHInputPasswordCanvasSignOn { get { return _tmpPHInputPasswordCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputPasswordCanvasSignOn { get { return _tmpTxtInputPasswordCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoPasswordCanvasSignOn { get { return _tmpTxtInfoPasswordCanvasSignOn; } }
    public TextMeshProUGUI m_tmpPHInputEmailCanvasSignOn { get { return _tmpPHInputEmailCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputEmailCanvasSignOn { get { return _tmpTxtInputEmailCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoEmailCanvasSignOn { get { return _tmpTxtInfoEmailCanvasSignOn; } }
    public TextMeshProUGUI m_tmpPHInputFirstNameCanvasSignOn { get { return _tmpPHInputFirstNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputFirstNameCanvasSignOn { get { return _tmpTxtInputFirstNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoFirstNameCanvasSignOn { get { return _tmpTxtInfoFirstNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpPHInputLastNameCanvasSignOn { get { return _tmpPHInputLastNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInputLastNameCanvasSignOn { get { return _tmpTxtInputLastNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtInfoLastNameCanvasSignOn { get { return _tmpTxtInfoLastNameCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtBtnRegisterCanvasSignOn { get { return _tmpTxtBtnRegisterCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtBtnBackCanvasSignOn { get { return _tmpTxtBtnBackCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtPopUpRegisterCanvasSignOn { get { return _tmpTxtPopUpRegisterCanvasSignOn; } }
    public TextMeshProUGUI m_tmpTxtBtnPopUpRegisterCanvasSignOn { get { return _tmpTxtBtnPopUpRegisterCanvasSignOn; } }
    #endregion

    #region private
    DataBaseManager _dbManager = null;
    RectTransform _transformBackgroundCanvasSignOn = null, _transformTitleCanvasSignOn = null, _transformInputPseudoCanvasSignOn = null,
        _transformBtnPseudoExistCanvasSignOn = null, _transformTxtInfoPseudoCanvasSignOn = null, _transformInputPasswordCanvasSignOn = null,
        _transformBtnPasswordVisibleCanvasSignOn = null, _transformTxtInfoPasswordCanvasSignOn = null, _transformInputEmailCanvasSignOn = null,
        _transformTxtInfoEmailCanvasSignOn = null, _transformInputFirstNameCanvasSignOn = null, _transformTxtInfoFirstNameCanvasSignOn = null,
        _transformInputLastNameCanvasSignOn = null, _transformTxtInfoLastNameCanvasSignOn = null, _transformBtnRegisterCanvasSignOn = null,
        _transformBtnBackCanvasSignOn = null, _transformPopUpRegisterCanvasSignOn = null, _transformImgPopUpRegisterCanvasSignOn = null,
        _transformTxtPopUpRegisterCanvasSignOn = null, _transformBtnPopUpRegisterCanvasSignOn = null;
    Image _imgBackgroundCanvasSignOn = null, _imgInputPseudoCanvasSignOn = null, _imgBtnPseudoExistCanvasSignOn = null,
        _imgInputPasswordCanvasSignOn = null, _imgBtnPasswordVisibleCanvasSignOn = null, _imgInputEmailCanvasSignOn = null,
        _imgInputFirstNameCanvasSignOn = null, _imgInputLastNameCanvasSignOn = null, _imgBtnRegisterCanvasSignOn = null,
        _imgBtnBackCanvasSignOn = null, _imgPopUpRegisterCanvasSignOn = null, _imgBtnPopUpRegisterCanvasSignOn;
    TMP_InputField _inputPseudoCanvasSignOn = null, _inputPasswordCanvasSignOn = null, _inputEmailCanvasSignOn = null,
        _inputFirstNameCanvasSignOn = null, _inputLastNameCanvasSignOn = null;
    TextMeshProUGUI _tmpTitleCanvasSignOn = null, _tmpPHInputPseudoCanvasSignOn = null, _tmpTxtInputPseudoCanvasSignOn = null,
        _tmpTxtInfoPseudoCanvasSignOn = null, _tmpPHInputPasswordCanvasSignOn = null, _tmpTxtInputPasswordCanvasSignOn = null,
        _tmpTxtInfoPasswordCanvasSignOn = null, _tmpPHInputEmailCanvasSignOn = null, _tmpTxtInputEmailCanvasSignOn = null,
        _tmpTxtInfoEmailCanvasSignOn = null, _tmpPHInputFirstNameCanvasSignOn = null, _tmpTxtInputFirstNameCanvasSignOn = null,
        _tmpTxtInfoFirstNameCanvasSignOn = null, _tmpPHInputLastNameCanvasSignOn = null, _tmpTxtInputLastNameCanvasSignOn = null,
        _tmpTxtInfoLastNameCanvasSignOn = null, _tmpTxtBtnRegisterCanvasSignOn = null, _tmpTxtBtnBackCanvasSignOn = null,
        _tmpTxtPopUpRegisterCanvasSignOn = null, _tmpTxtBtnPopUpRegisterCanvasSignOn = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformBackgroundCanvasSignOn = goBackgroundCanvasSignOn.GetComponent<RectTransform>();
        _transformTitleCanvasSignOn = goTitleCanvasSignOn.GetComponent<RectTransform>();
        _transformInputPseudoCanvasSignOn = goInputPseudoCanvasSignOn.GetComponent<RectTransform>();
        _transformBtnPseudoExistCanvasSignOn = goBtnPseudoExistCanvasSignOn.GetComponent<RectTransform>();
        _transformTxtInfoPseudoCanvasSignOn = goTxtInfoPseudoCanvasSignOn.GetComponent<RectTransform>();
        _transformInputPasswordCanvasSignOn = goInputPasswordCanvasSignOn.GetComponent<RectTransform>();
        _transformBtnPasswordVisibleCanvasSignOn = goBtnPasswordVisibleCanvasSignOn.GetComponent<RectTransform>();
        _transformTxtInfoPasswordCanvasSignOn = goTxtInfoPasswordCanvasSignOn.GetComponent<RectTransform>();
        _transformInputEmailCanvasSignOn = goInputEmailCanvasSignOn.GetComponent<RectTransform>();
        _transformTxtInfoEmailCanvasSignOn = goTxtInfoEmailCanvasSignOn.GetComponent<RectTransform>();
        _transformInputFirstNameCanvasSignOn = goInputFirstNameCanvasSignOn.GetComponent<RectTransform>();
        _transformTxtInfoFirstNameCanvasSignOn = goTxtInfoFirstNameCanvasSignOn.GetComponent<RectTransform>();
        _transformInputLastNameCanvasSignOn = goInputLastNameCanvasSignOn.GetComponent<RectTransform>();
        _transformTxtInfoLastNameCanvasSignOn = goTxtInfoLastNameCanvasSignOn.GetComponent<RectTransform>();
        _transformBtnRegisterCanvasSignOn = goBtnRegisterCanvasSignOn.GetComponent<RectTransform>();
        _transformBtnBackCanvasSignOn = goBtnBackCanvasSignOn.GetComponent<RectTransform>();
        _transformPopUpRegisterCanvasSignOn = goPopUpRegisterCanvasSignOn.GetComponent<RectTransform>();
        _transformImgPopUpRegisterCanvasSignOn = goImgPopUpRegisterCanvasSignOn.GetComponent<RectTransform>();
        _transformTxtPopUpRegisterCanvasSignOn = goTxtPopUpRegisterCanvasSignOn.GetComponent<RectTransform>();
        _transformBtnPopUpRegisterCanvasSignOn = goBtnPopUpRegisterCanvasSignOn.GetComponent<RectTransform>();

        _imgBackgroundCanvasSignOn = goBackgroundCanvasSignOn.GetComponent<Image>();
        _imgInputPseudoCanvasSignOn = goInputPseudoCanvasSignOn.GetComponent<Image>();
        _imgBtnPseudoExistCanvasSignOn = goBtnPseudoExistCanvasSignOn.GetComponent<Image>();
        _imgInputPasswordCanvasSignOn = goInputPasswordCanvasSignOn.GetComponent<Image>();
        _imgBtnPasswordVisibleCanvasSignOn = goBtnPasswordVisibleCanvasSignOn.GetComponent<Image>();
        _imgInputEmailCanvasSignOn = goInputEmailCanvasSignOn.GetComponent<Image>();
        _imgInputFirstNameCanvasSignOn = goInputFirstNameCanvasSignOn.GetComponent<Image>();
        _imgInputLastNameCanvasSignOn = goInputLastNameCanvasSignOn.GetComponent<Image>();
        _imgBtnRegisterCanvasSignOn = goBtnRegisterCanvasSignOn.GetComponent<Image>();
        _imgBtnBackCanvasSignOn = goBtnBackCanvasSignOn.GetComponent<Image>();
        _imgPopUpRegisterCanvasSignOn = goImgPopUpRegisterCanvasSignOn.GetComponent<Image>();
        _imgBtnPopUpRegisterCanvasSignOn = goBtnPopUpRegisterCanvasSignOn.GetComponent<Image>();

        _inputPseudoCanvasSignOn = goInputPseudoCanvasSignOn.GetComponent<TMP_InputField>();
        _inputPasswordCanvasSignOn = goInputPasswordCanvasSignOn.GetComponent<TMP_InputField>();
        _inputEmailCanvasSignOn = goInputEmailCanvasSignOn.GetComponent<TMP_InputField>();
        _inputFirstNameCanvasSignOn = goInputFirstNameCanvasSignOn.GetComponent<TMP_InputField>();
        _inputLastNameCanvasSignOn = goInputLastNameCanvasSignOn.GetComponent<TMP_InputField>();

        _tmpTitleCanvasSignOn = goTitleCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpPHInputPseudoCanvasSignOn = goPHInputPseudoCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputPseudoCanvasSignOn = goTxtInputPseudoCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoPseudoCanvasSignOn = goTxtInfoPseudoCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpPHInputPasswordCanvasSignOn = goPHInputPasswordCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputPasswordCanvasSignOn = goTxtInputPasswordCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoPasswordCanvasSignOn = goTxtInfoPasswordCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpPHInputEmailCanvasSignOn = goPHInputEmailCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputEmailCanvasSignOn = goTxtInputEmailCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoEmailCanvasSignOn = goTxtInfoEmailCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpPHInputFirstNameCanvasSignOn = goPHInputFirstNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputFirstNameCanvasSignOn = goTxtInputFirstNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoFirstNameCanvasSignOn = goTxtInfoFirstNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpPHInputLastNameCanvasSignOn = goPHInputLastNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputLastNameCanvasSignOn = goTxtInputLastNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoLastNameCanvasSignOn = goTxtInfoLastNameCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnRegisterCanvasSignOn = goTxtBtnRegisterCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnBackCanvasSignOn = goTxtBtnBackCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtPopUpRegisterCanvasSignOn = goTxtPopUpRegisterCanvasSignOn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnPopUpRegisterCanvasSignOn = goTxtBtnPopUpRegisterCanvasSignOn.GetComponent<TextMeshProUGUI>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will reinitialize info text and input block Color for the Canvas Sign On.
    /// </summary>
    public void ReinitializeRegisterCanvasSignOn()
    {
        _tmpTxtInfoPseudoCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoPasswordCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoEmailCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoFirstNameCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoLastNameCanvasSignOn.text = _dbManager.m_message.BaseMessage();
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputPseudoCanvasSignOn, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputPasswordCanvasSignOn, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputEmailCanvasSignOn, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputFirstNameCanvasSignOn, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputLastNameCanvasSignOn, Color.white);
        _tmpTxtInputPseudoCanvasSignOn.text = "";
        _tmpTxtInputPasswordCanvasSignOn.text = "";
        _tmpTxtInputEmailCanvasSignOn.text = "";
        _tmpTxtInputFirstNameCanvasSignOn.text = "";
        _tmpTxtInputLastNameCanvasSignOn.text = "";
    }
    #endregion
}
