using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Sign In.
/// </summary>
[Serializable]
public class GameObjectCanvasSignIn
{
    #region SerializeField
    [Header("Canvas Sign In")]
    [Tooltip("GameObject Canvas Sign In.")]
    [SerializeField] GameObject goCanvasSignIn;
    [Header("Background")]
    [Tooltip("Background of the Canvas Sign In.")]
    [SerializeField] GameObject goBackgroundCanvasSignIn;
    [Header("Title")]
    [Tooltip("Title of the Canvas Sign In.")]
    [SerializeField] GameObject goTitleCanvasSignIn;
    [Header("Input Pseudo")]
    [Tooltip("Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goInputPseudoCanvasSignIn;
    [Tooltip("Placeholder Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goPHInputPseudoCanvasSignIn;
    [Tooltip("Text Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtInputPseudoCanvasSignIn;
    [Header("Input Password")]
    [Tooltip("Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goInputPasswordCanvasSignIn;
    [Tooltip("Placeholder Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goPHInputPasswordCanvasSignIn;
    [Tooltip("Text Input pseudo of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtInputPasswordCanvasSignIn;
    [Header("Info connection")]
    [Tooltip("Text Info connection of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtInfoConnectionCanvasSignIn;
    [Header("Forgot Password")]
    [Tooltip("Button Forgot Password of the Canvas Sign In.")]
    [SerializeField] GameObject goBtnForgotPasswordCanvasSignIn;
    [Tooltip("Text Button Forgot Password of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtBtnForgotPasswordCanvasSignIn;
    [Header("New Account")]
    [Tooltip("Button New Account of the Canvas Sign In.")]
    [SerializeField] GameObject goBtnNewAccountCanvasSignIn;
    [Tooltip("Text New Account Password of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtBtnNewAccountCanvasSignIn;
    [Header("Connection")]
    [Tooltip("Button Connection of the Canvas Sign In.")]
    [SerializeField] GameObject goBtnConnectionCanvasSignIn;
    [Tooltip("Text Button Connection of the Canvas Sign In.")]
    [SerializeField] GameObject goTxtBtnConnectionCanvasSignIn;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasSignIn { get { return goCanvasSignIn; } }

    public RectTransform m_transformBackgroundCanvasSignIn { get { return _transformBackgroundCanvasSignIn; } }
    public RectTransform m_transformTitleCanvasSignIn { get { return _transformTitleCanvasSignIn; } }
    public RectTransform m_transformInputPseudoCanvasSignIn { get { return _transformInputPseudoCanvasSignIn; } }
    public RectTransform m_transformInputPasswordCanvasSignIn { get { return _transformInputPasswordCanvasSignIn; } }
    public RectTransform m_transformTxtInfoConnectionCanvasSignIn { get { return _transformTxtInfoConnectionCanvasSignIn; } }
    public RectTransform m_transformBtnForgotPasswordCanvasSignIn { get { return _transformBtnForgotPasswordCanvasSignIn; } }
    public RectTransform m_transformBtnNewAccountCanvasSignIn { get { return _transformBtnNewAccountCanvasSignIn; } }
    public RectTransform m_transformBtnConnectionCanvasSignIn { get { return _transformBtnConnectionCanvasSignIn; } }

    public Image m_imgBackgroundCanvasSignIn { get { return _imgBackgroundCanvasSignIn; } }
    public Image m_imgInputPseudoCanvasSignIn { get { return _imgInputPseudoCanvasSignIn; } }
    public Image m_imgInputPasswordCanvasSignIn { get { return _imgInputPasswordCanvasSignIn; } }

    public TMP_InputField m_inputPseudoCanvasSignIn { get { return _inputPseudoCanvasSignIn; } }
    public TMP_InputField m_inputPasswordCanvasSignIn { get { return _inputPasswordCanvasSignIn; } }

    public TextMeshProUGUI m_tmpTitleCanvasSignIn { get { return _tmpTitleCanvasSignIn; } }
    public TextMeshProUGUI m_tmpPHInputPseudoCanvasSignIn { get { return _tmpPHInputPseudoCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtInputPseudoCanvasSignIn { get { return _tmpTxtInputPseudoCanvasSignIn; } }
    public TextMeshProUGUI m_tmpPHInputPasswordCanvasSignIn { get { return _tmpPHInputPasswordCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtInputPasswordCanvasSignIn { get { return _tmpTxtInputPasswordCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtInfoConnectionCanvasSignIn { get { return _tmpTxtInfoConnectionCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtBtnForgotPasswordCanvasSignIn { get { return _tmpTxtBtnForgotPasswordCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtBtnNewAccountCanvasSignIn { get { return _tmpTxtBtnNewAccountCanvasSignIn; } }
    public TextMeshProUGUI m_tmpTxtBtnConnectionCanvasSignIn { get { return _tmpTxtBtnConnectionCanvasSignIn; } }
    #endregion

    #region private
    DataBaseManager _dbManager = null;
    RectTransform _transformBackgroundCanvasSignIn = null, _transformTitleCanvasSignIn = null, _transformInputPseudoCanvasSignIn = null,
        _transformInputPasswordCanvasSignIn = null, _transformTxtInfoConnectionCanvasSignIn = null, _transformBtnForgotPasswordCanvasSignIn = null,
        _transformBtnNewAccountCanvasSignIn = null, _transformBtnConnectionCanvasSignIn = null;
    Image _imgBackgroundCanvasSignIn = null, _imgInputPseudoCanvasSignIn = null, _imgInputPasswordCanvasSignIn = null;
    TMP_InputField _inputPseudoCanvasSignIn = null, _inputPasswordCanvasSignIn = null;
    TextMeshProUGUI _tmpTitleCanvasSignIn = null, _tmpPHInputPseudoCanvasSignIn = null, _tmpTxtInputPseudoCanvasSignIn = null,
        _tmpPHInputPasswordCanvasSignIn = null, _tmpTxtInputPasswordCanvasSignIn = null, _tmpTxtInfoConnectionCanvasSignIn = null,
        _tmpTxtBtnForgotPasswordCanvasSignIn = null, _tmpTxtBtnNewAccountCanvasSignIn = null, _tmpTxtBtnConnectionCanvasSignIn = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformBackgroundCanvasSignIn = goBackgroundCanvasSignIn.GetComponent<RectTransform>();
        _transformTitleCanvasSignIn = goTitleCanvasSignIn.GetComponent<RectTransform>();
        _transformInputPseudoCanvasSignIn = goInputPseudoCanvasSignIn.GetComponent<RectTransform>();
        _transformInputPasswordCanvasSignIn = goInputPasswordCanvasSignIn.GetComponent<RectTransform>();
        _transformTxtInfoConnectionCanvasSignIn = goTxtInfoConnectionCanvasSignIn.GetComponent<RectTransform>();
        _transformBtnForgotPasswordCanvasSignIn = goBtnForgotPasswordCanvasSignIn.GetComponent<RectTransform>();
        _transformBtnNewAccountCanvasSignIn = goBtnNewAccountCanvasSignIn.GetComponent<RectTransform>();
        _transformBtnConnectionCanvasSignIn = goBtnConnectionCanvasSignIn.GetComponent<RectTransform>();

        _imgBackgroundCanvasSignIn = goBackgroundCanvasSignIn.GetComponent<Image>();
        _imgInputPseudoCanvasSignIn = goInputPseudoCanvasSignIn.GetComponent<Image>();
        _imgInputPasswordCanvasSignIn = goInputPasswordCanvasSignIn.GetComponent<Image>();

        _inputPseudoCanvasSignIn = goInputPseudoCanvasSignIn.GetComponent<TMP_InputField>();
        _inputPasswordCanvasSignIn = goInputPasswordCanvasSignIn.GetComponent<TMP_InputField>();

        _tmpTitleCanvasSignIn = goTitleCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpPHInputPseudoCanvasSignIn = goPHInputPseudoCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputPseudoCanvasSignIn = goTxtInputPseudoCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpPHInputPasswordCanvasSignIn = goPHInputPasswordCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputPasswordCanvasSignIn = goTxtInputPasswordCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoConnectionCanvasSignIn = goTxtInfoConnectionCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnForgotPasswordCanvasSignIn = goTxtBtnForgotPasswordCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnNewAccountCanvasSignIn = goTxtBtnNewAccountCanvasSignIn.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnConnectionCanvasSignIn = goTxtBtnConnectionCanvasSignIn.GetComponent<TextMeshProUGUI>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will reinitialize info text and input block Color for the Canvas Sign In.
    /// </summary>
    public void ReinitializeAllCanvasSignIn()
    {
        _tmpTxtInfoConnectionCanvasSignIn.text = _dbManager.m_message.BaseMessage();
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputPseudoCanvasSignIn, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_inputPasswordCanvasSignIn, Color.white);
        _inputPseudoCanvasSignIn.text = "";
        _inputPasswordCanvasSignIn.text = "";
    }
    #endregion
}
