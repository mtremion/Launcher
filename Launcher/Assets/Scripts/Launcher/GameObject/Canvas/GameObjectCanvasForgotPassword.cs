using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Forgot Password.
/// </summary>
[Serializable]
public class GameObjectCanvasForgotPassword
{
    #region SerializeField
    [Header("Canvas Forgot Password")]
    [Tooltip("GameObject Canvas Forgot Password")]
    [SerializeField] GameObject goCanvasForgotPassword;
    [Header("Background")]
    [Tooltip("Background of the Canvas Forgot Password.")]
    [SerializeField] GameObject goBackgroundForgotPassword;
    [Header("Title")]
    [Tooltip("Title of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTitleForgotPassword;
    [Header("Input Email")]
    [Tooltip("Input Email of the Canvas Forgot Password.")]
    [SerializeField] GameObject goInputEmailForgotPassword;
    [Tooltip("Placeholder Input Email of the Canvas Forgot Password.")]
    [SerializeField] GameObject goPHInputEmailForgotPassword;
    [Tooltip("Txt Input Email of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtInputEmailForgotPassword;
    [Header("Info Input Email")]
    [Tooltip("Txt Info Input Email of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtInfoInputEmailForgotPassword;
    [Header("Button Send")]
    [Tooltip("Button Send of the Canvas Forgot Password.")]
    [SerializeField] GameObject goBtnSendForgotPassword;
    [Tooltip("Txt Button Send of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtBtnSendForgotPassword;
    [Header("Button Back")]
    [Tooltip("Button Back of the Canvas Forgot Password.")]
    [SerializeField] GameObject goBtnBackForgotPassword;
    [Tooltip("Txt Button Back of the Canvas Forgot Password.")]
    [SerializeField] GameObject goTxtBtnBackForgotPassword;
    [Header("Pop Up Verification / Canvas Pop Up Verification")]
    [Tooltip("GameObject Canvas Pop Up Verification of Forgot Password")]
    [SerializeField] GameObject goPopUpVerifyForgotPassword;
    [Header("Background Pop Up Verification")]
    [Tooltip("Background of the Pop Up Verification.")]
    [SerializeField] GameObject goBackgroundPopUpVerification;
    [Header("Title Pop Up Verification")]
    [Tooltip("Title of the Pop Up Verification.")]
    [SerializeField] GameObject goTitlePopUpVerification;
    [Header("Input Code Pop Up Verification")]
    [Tooltip("Input Code of the Pop Up Verification.")]
    [SerializeField] GameObject goInputCodePopUpVerification;
    [Tooltip("Placeholder Input Code of the Pop Up Verification.")]
    [SerializeField] GameObject goPHInputCodePopUpVerification;
    [Tooltip("Txt Input Code of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtInputCodePopUpVerification;
    [Header("Info Input Code Pop Up Verification")]
    [Tooltip("Txt Input Code of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtInfoInputCodePopUpVerification;
    [Header("Button Verify Pop Up Verification")]
    [Tooltip("Button Verify of the Pop Up Verification.")]
    [SerializeField] GameObject goBtnVerifyPopUpVerification;
    [Tooltip("Txt Button Back of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtBtnVerifyPopUpVerification;
    [Header("Button Back")]
    [Tooltip("Button Back of the Pop Up Verification.")]
    [SerializeField] GameObject goBtnBackPopUpVerification;
    [Tooltip("Txt Button Back of the Pop Up Verification.")]
    [SerializeField] GameObject goTxtBtnBackPopUpVerification;
    [Header("Pop Up Change Password / Canvas Pop Up Change Password")]
    [Tooltip("GameObject Canvas Pop Up Change Password of Forgot Password")]
    [SerializeField] GameObject goPopUpChangePasswordForgotPassword;
    [Header("Background Pop Up Change Password")]
    [Tooltip("Background of the Pop Up Change Password.")]
    [SerializeField] GameObject goBackgroundPopUpChangePassword;
    [Header("Title Pop Up Change Password")]
    [Tooltip("Title of the Pop Up Change Password.")]
    [SerializeField] GameObject goTitlePopUpChangePassword;
    [Header("Input New Password Pop Up Change Passwod")]
    [Tooltip("Input New Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goInputNewPasswordPopUpChangePassword;
    [Tooltip("Placeholder Input New Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goPHInputNewPasswordPopUpChangePassword;
    [Tooltip("Txt Input New Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goTxtInputNewPasswordPopUpChangePassword;
    [Header("Button New Password Visibility")]
    [Tooltip("Button New Password Visibility of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnNewPasswordPasswordPopUpChangePassword;
    [Header("Input Confirm Password Pop Up Change Passwod")]
    [Tooltip("Input Confirm Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goInputConfirmPasswordPopUpChangePassword;
    [Tooltip("Placeholder Input Confirm Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goPHInputConfirmPasswordPopUpChangePassword;
    [Tooltip("Txt Input Confirm Password Pop Up Change Passwod.")]
    [SerializeField] GameObject goTxtInputConfirmPasswordPopUpChangePassword;
    [Header("Button Confirm Password Visibility")]
    [Tooltip("Button Confirm Password Visibility of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnConfirmPasswordPasswordPopUpChangePassword;
    [Header("Txt Info Password")]
    [Tooltip("Txt Info Password of the Pop Up Change Passwod.")]
    [SerializeField] GameObject goTxtInfoPasswordPopUpChangePassword;
    [Header("Button Confirm")]
    [Tooltip("Button Confirm of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnConfirmPopUpChangePassword;
    [Tooltip("Txt Button Confirm of the Pop Up Change Password.")]
    [SerializeField] GameObject goTxtBtnConfirmPopUpChangePassword;
    [Header("Button Back")]
    [Tooltip("Button Back of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnBackPopUpChangePassword;
    [Tooltip("Txt Button Back of the Pop Up Change Password.")]
    [SerializeField] GameObject goTxtBtnBackPopUpChangePassword;
    [Header("Pop Up Password Change / Canvas Pop Up Password Change")]
    [Tooltip("GameObject Canvas Pop Up Password Change of Forgot Password")]
    [SerializeField] GameObject goPopUpPasswordChangeForgotPassword;
    [Header("Background Pop Up Change Password")]
    [Tooltip("Background of the Pop Up PasswordChange.")]
    [SerializeField] GameObject goBackgroundPopUpPasswordChange;
    [Header("Title Pop Up PasswordChange")]
    [Tooltip("Title of the Pop Up PasswordChange.")]
    [SerializeField] GameObject goTitlePopUpPasswordChange;
    [Header("Button Sign In")]
    [Tooltip("Button Sign In of the Pop Up Change Password.")]
    [SerializeField] GameObject goBtnSignInPopUpChangePassword;
    [Tooltip("Txt Button Sign In of the Pop Up Change Password.")]
    [SerializeField] GameObject goTxtBtnSignInPopUpChangePassword;
    #endregion

    #region Getters & Setters
    public GameObject m_goCanvasForgotPassword { get { return goCanvasForgotPassword; } }
    public GameObject m_goPopUpVerification { get { return goPopUpVerifyForgotPassword; } }
    public GameObject m_goPopUpChangePassword{ get { return goPopUpChangePasswordForgotPassword; } }
    public GameObject m_goPopUpPasswordChange { get { return goPopUpPasswordChangeForgotPassword; } }

    public RectTransform m_transformBackgroundForgotPassword { get { return _transformBackgroundForgotPassword; } }
    public RectTransform m_transformTitleForgotPassword { get { return _transformTitleForgotPassword; } }
    public RectTransform m_transformInputEmailForgotPassword { get { return _transformInputEmailForgotPassword; } }
    public RectTransform m_transformTxtInfoInputEmailForgotPassword { get { return _transformTxtInfoInputEmailForgotPassword; } }
    public RectTransform m_transformBtnSendForgotPassword { get { return _transformBtnSendForgotPassword; } }
    public RectTransform m_transformBtnBackForgotPassword { get { return _transformBtnBackForgotPassword; } }
    public RectTransform m_transformPopUpVerifyForgotPassword { get { return _transformPopUpVerifyForgotPassword; } }
    public RectTransform m_transformBackgroundPopUpVerification { get { return _transformBackgroundPopUpVerification; } }
    public RectTransform m_transformTitlePopUpVerification { get { return _transformTitlePopUpVerification; } }
    public RectTransform m_transformInputCodePopUpVerification { get { return _transformInputCodePopUpVerification; } }
    public RectTransform m_transformTxtInfoInputCodePopUpVerification { get { return _transformTxtInfoInputCodePopUpVerification; } }
    public RectTransform m_transformBtnVerifyPopUpVerification { get { return _transformBtnVerifyPopUpVerification; } }
    public RectTransform m_transformBtnBackPopUpVerification { get { return _transformBtnBackPopUpVerification; } }
    public RectTransform m_transformPopUpChangePasswordForgotPassword { get { return _transformPopUpChangePasswordForgotPassword; } }
    public RectTransform m_transformBackgroundPopUpChangePassword { get { return _transformBackgroundPopUpChangePassword; } }
    public RectTransform m_transformTitlePopUpChangePassword { get { return _transformTitlePopUpChangePassword; } }
    public RectTransform m_transformInputNewPasswordPopUpChangePassword { get { return _transformInputNewPasswordPopUpChangePassword; } }
    public RectTransform m_transformBtnNewPasswordVisibilityPopUpChangePassword { get { return _transformBtnNewPasswordPasswordPopUpChangePassword; } }
    public RectTransform m_transformInputConfirmPasswordPopUpChangePassword { get { return _transformInputConfirmPasswordPopUpChangePassword; } }
    public RectTransform m_transformBtnConfirmPasswordVisibilityPopUpChangePassword { get { return _transformBtnConfirmPasswordPasswordPopUpChangePassword; } }
    public RectTransform m_transformTxtInfoPasswordPopUpChangePassword { get { return _transformTxtInfoPasswordPopUpChangePassword; } }
    public RectTransform m_transformBtnConfirmPopUpChangePassword { get { return _transformBtnConfirmPopUpChangePassword; } }
    public RectTransform m_transformBtnBackPopUpChangePassword { get { return _transformBtnBackPopUpChangePassword; } }
    public RectTransform m_transformPopUpPasswordChangeForgotPassword { get { return _transformPopUpPasswordChangeForgotPassword; } }
    public RectTransform m_transformBackgroundPopUpPasswordChange { get { return _transformBackgroundPopUpPasswordChange; } }
    public RectTransform m_transformTitlePopUpPasswordChange { get { return _transformTitlePopUpPasswordChange; } }
    public RectTransform m_transformBtnSignInPopUpPasswordChange { get { return _transformBtnSignInPopUpChangePassword; } }

    public Image m_imgBackgroundForgotPassword { get { return _imgBackgroundForgotPassword; } }
    public Image m_imgInputEmailForgotPassword { get { return _imgInputEmailForgotPassword; } }
    public Image m_imgBtnSendForgotPassword { get { return _imgBtnSendForgotPassword; } }
    public Image m_imgBtnBackForgotPassword { get { return _imgBtnBackForgotPassword; } }
    public Image m_imgBackgroundPopUpVerification { get { return _imgBackgroundPopUpVerification; } }
    public Image m_imgInputCodePopUpVerification { get { return _imgInputCodePopUpVerification; } }
    public Image m_imgBtnVerifyPopUpVerification { get { return _imgBtnVerifyPopUpVerification; } }
    public Image m_imgBtnBackPopUpVerification { get { return _imgBtnBackPopUpVerification; } }
    public Image m_imgBackgroundPopUpChangePassword { get { return _imgBackgroundPopUpChangePassword; } }
    public Image m_imgInputNewPasswordPopUpChangePassword { get { return _imgInputNewPasswordPopUpChangePassword; } }
    public Image m_imgBtnNewPasswordVisibilityPopUpChangePassword { get { return _imgBtnNewPasswordPasswordPopUpChangePassword; } }
    public Image m_imgInputConfirmPasswordPopUpChangePassword { get { return _imgInputConfirmPasswordPopUpChangePassword; } }
    public Image m_imgBtnConfirmPasswordVisibilityPopUpChangePassword { get { return _imgBtnConfirmPasswordPasswordPopUpChangePassword; } }
    public Image m_imgBtnConfirmPopUpChangePassword { get { return _imgBtnConfirmPopUpChangePassword; } }
    public Image m_imgBtnBackPopUpChangePassword { get { return _imgBtnBackPopUpChangePassword; } }
    public Image m_imgBackgroundPopUpPasswordChange { get { return _imgBackgroundPopUpPasswordChange; } }
    public Image m_imgBtnSignInPopUpChangePassword { get { return _imgBtnSignInPopUpChangePassword; } }

    public TMP_InputField m_InputEmailForgotPassword { get { return _InputEmailForgotPassword; } }
    public TMP_InputField m_InputCodePopUpVerification { get { return _InputCodePopUpVerification; } }
    public TMP_InputField m_InputNewPasswordPopUpChangePassword { get { return _InputNewPasswordPopUpChangePassword; } }
    public TMP_InputField m_InputConfirmPasswordPopUpChangePassword { get { return _InputConfirmPasswordPopUpChangePassword; } }

    public TextMeshProUGUI m_tmpTitleForgotPassword { get { return _tmpTitleForgotPassword; } }
    public TextMeshProUGUI m_tmpPHInputEmailForgotPassword { get { return _tmpPHInputEmailForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtInputEmailForgotPassword { get { return _tmpTxtInputEmailForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtInfoInputEmailForgotPassword { get { return _tmpTxtInfoInputEmailForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtBtnSendForgotPassword { get { return _tmpTxtBtnSendForgotPassword; } }
    public TextMeshProUGUI m_tmpTxtBtnBackForgotPassword { get { return _tmpTxtBtnBackForgotPassword; } }
    public TextMeshProUGUI m_tmpTitlePopUpVerification { get { return _tmpTitlePopUpVerification; } }
    public TextMeshProUGUI m_tmpPHInputCodePopUpVerification { get { return _tmpPHInputCodePopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtInputCodePopUpVerification { get { return _tmpTxtInputCodePopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtInfoInputCodePopUpVerification { get { return _tmpTxtInfoInputCodePopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtBtnVerifyPopUpVerification { get { return _tmpTxtBtnVerifyPopUpVerification; } }
    public TextMeshProUGUI m_tmpTxtBtnBackPopUpVerification { get { return _tmpTxtBtnBackPopUpVerification; } }
    public TextMeshProUGUI m_tmpTitlePopUpChangePassword { get { return _tmpTitlePopUpChangePassword; } }
    public TextMeshProUGUI m_tmpPHInputNewPasswordPopUpChangePassword { get { return _tmpPHInputNewPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtInputNewPasswordPopUpChangePassword { get { return _tmpTxtInputNewPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpPHInputConfirmPasswordPopUpChangePassword { get { return _tmpPHInputConfirmPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtInputConfirmPasswordPopUpChangePassword { get { return _tmpTxtInputConfirmPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtInfoPasswordPopUpChangePassword { get { return _tmpTxtInfoPasswordPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtBtnConfirmPopUpChangePassword { get { return _tmpTxtBtnConfirmPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTxtBtnBackPopUpChangePassword { get { return _tmpTxtBtnBackPopUpChangePassword; } }
    public TextMeshProUGUI m_tmpTitlePopUpPasswordChange { get { return _tmpTitlePopUpPasswordChange; } }
    public TextMeshProUGUI m_tmpTxtBtnSignInPopUpChangePassword { get { return _tmpTxtBtnSignInPopUpChangePassword; } }
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    RectTransform _transformCanvasForgotPassword = null, _transformBackgroundForgotPassword = null, _transformTitleForgotPassword = null,
    _transformInputEmailForgotPassword = null, _transformTxtInfoInputEmailForgotPassword = null, _transformBtnSendForgotPassword = null,
    _transformBtnBackForgotPassword = null, _transformPopUpVerifyForgotPassword = null, _transformBackgroundPopUpVerification = null,
    _transformTitlePopUpVerification = null, _transformInputCodePopUpVerification = null, _transformTxtInfoInputCodePopUpVerification = null,
    _transformBtnVerifyPopUpVerification = null, _transformBtnBackPopUpVerification = null, _transformPopUpChangePasswordForgotPassword = null,
    _transformBackgroundPopUpChangePassword = null, _transformTitlePopUpChangePassword = null, _transformInputNewPasswordPopUpChangePassword = null,
    _transformBtnNewPasswordPasswordPopUpChangePassword = null, _transformInputConfirmPasswordPopUpChangePassword = null, _transformBtnConfirmPasswordPasswordPopUpChangePassword = null,
    _transformTxtInfoPasswordPopUpChangePassword = null, _transformBtnConfirmPopUpChangePassword = null, _transformBtnBackPopUpChangePassword = null,
    _transformPopUpPasswordChangeForgotPassword = null, _transformBackgroundPopUpPasswordChange = null, _transformTitlePopUpPasswordChange = null,
    _transformBtnSignInPopUpChangePassword = null;
    Image _imgBackgroundForgotPassword = null, _imgInputEmailForgotPassword = null, _imgBtnSendForgotPassword = null,
    _imgBtnBackForgotPassword = null, _imgBackgroundPopUpVerification = null, _imgInputCodePopUpVerification = null,
    _imgBtnVerifyPopUpVerification = null, _imgBtnBackPopUpVerification = null, _imgBackgroundPopUpChangePassword = null,
    _imgInputNewPasswordPopUpChangePassword = null, _imgBtnNewPasswordPasswordPopUpChangePassword = null, _imgInputConfirmPasswordPopUpChangePassword = null,
    _imgBtnConfirmPasswordPasswordPopUpChangePassword = null, _imgBtnConfirmPopUpChangePassword = null, _imgBtnBackPopUpChangePassword = null,
    _imgBackgroundPopUpPasswordChange = null, _imgBtnSignInPopUpChangePassword = null;
    TMP_InputField _InputEmailForgotPassword = null, _InputCodePopUpVerification = null, _InputNewPasswordPopUpChangePassword = null,
    _InputConfirmPasswordPopUpChangePassword = null;
    TextMeshProUGUI _tmpTitleForgotPassword = null, _tmpPHInputEmailForgotPassword = null, _tmpTxtInputEmailForgotPassword = null,
    _tmpTxtInfoInputEmailForgotPassword = null, _tmpTxtBtnSendForgotPassword = null, _tmpTxtBtnBackForgotPassword = null, _tmpTitlePopUpVerification = null,
    _tmpPHInputCodePopUpVerification = null, _tmpTxtInputCodePopUpVerification = null, _tmpTxtInfoInputCodePopUpVerification = null,
    _tmpTxtBtnVerifyPopUpVerification = null, _tmpTxtBtnBackPopUpVerification = null, _tmpTitlePopUpChangePassword = null,
    _tmpPHInputNewPasswordPopUpChangePassword = null, _tmpTxtInputNewPasswordPopUpChangePassword = null, _tmpPHInputConfirmPasswordPopUpChangePassword = null, 
        _tmpTxtInputConfirmPasswordPopUpChangePassword = null, _tmpTxtInfoPasswordPopUpChangePassword = null, _tmpTxtBtnConfirmPopUpChangePassword = null,
        _tmpTxtBtnBackPopUpChangePassword = null, _tmpTitlePopUpPasswordChange = null, _tmpTxtBtnSignInPopUpChangePassword = null;  
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformCanvasForgotPassword = goCanvasForgotPassword.GetComponent<RectTransform>();
        _transformBackgroundForgotPassword = goBackgroundForgotPassword.GetComponent<RectTransform>();
        _transformTitleForgotPassword = goTitleForgotPassword.GetComponent<RectTransform>();
        _transformInputEmailForgotPassword = goInputEmailForgotPassword.GetComponent<RectTransform>();
        _transformTxtInfoInputEmailForgotPassword = goTxtInfoInputEmailForgotPassword.GetComponent<RectTransform>();
        _transformBtnSendForgotPassword = goBtnSendForgotPassword.GetComponent<RectTransform>();
        _transformBtnBackForgotPassword = goBtnBackForgotPassword.GetComponent<RectTransform>();
        _transformPopUpVerifyForgotPassword = goPopUpVerifyForgotPassword.GetComponent<RectTransform>();
        _transformBackgroundPopUpVerification = goBackgroundPopUpVerification.GetComponent<RectTransform>();
        _transformTitlePopUpVerification = goTitlePopUpVerification.GetComponent<RectTransform>();
        _transformInputCodePopUpVerification = goInputCodePopUpVerification.GetComponent<RectTransform>();
        _transformTxtInfoInputCodePopUpVerification = goTxtInfoInputCodePopUpVerification.GetComponent<RectTransform>();
        _transformBtnVerifyPopUpVerification = goBtnVerifyPopUpVerification.GetComponent<RectTransform>();
        _transformBtnBackPopUpVerification = goBtnBackPopUpVerification.GetComponent<RectTransform>();
        _transformPopUpChangePasswordForgotPassword = goPopUpChangePasswordForgotPassword.GetComponent<RectTransform>();
        _transformBackgroundPopUpChangePassword = goBackgroundPopUpChangePassword.GetComponent<RectTransform>();
        _transformTitlePopUpChangePassword = goTitlePopUpChangePassword.GetComponent<RectTransform>();
        _transformInputNewPasswordPopUpChangePassword = goInputNewPasswordPopUpChangePassword.GetComponent<RectTransform>();
        _transformBtnNewPasswordPasswordPopUpChangePassword = goBtnNewPasswordPasswordPopUpChangePassword.GetComponent<RectTransform>();
        _transformInputConfirmPasswordPopUpChangePassword = goInputConfirmPasswordPopUpChangePassword.GetComponent<RectTransform>();
        _transformBtnConfirmPasswordPasswordPopUpChangePassword = goBtnConfirmPasswordPasswordPopUpChangePassword.GetComponent<RectTransform>();
        _transformTxtInfoPasswordPopUpChangePassword = goTxtInfoPasswordPopUpChangePassword.GetComponent<RectTransform>();
        _transformBtnConfirmPopUpChangePassword = goBtnConfirmPopUpChangePassword.GetComponent<RectTransform>();
        _transformBtnBackPopUpChangePassword = goBtnBackPopUpChangePassword.GetComponent<RectTransform>();
        _transformPopUpPasswordChangeForgotPassword = goPopUpPasswordChangeForgotPassword.GetComponent<RectTransform>();
        _transformBackgroundPopUpPasswordChange = goBackgroundPopUpPasswordChange.GetComponent<RectTransform>();
        _transformTitlePopUpPasswordChange = goTitlePopUpPasswordChange.GetComponent<RectTransform>();
        _transformBtnSignInPopUpChangePassword = goBtnSignInPopUpChangePassword.GetComponent<RectTransform>();

        _imgBackgroundForgotPassword = goBackgroundForgotPassword.GetComponent<Image>();
        _imgInputEmailForgotPassword = goInputEmailForgotPassword.GetComponent<Image>();
        _imgBtnSendForgotPassword = goBtnSendForgotPassword.GetComponent<Image>();
        _imgBtnBackForgotPassword = goBtnBackForgotPassword.GetComponent<Image>();
        _imgBackgroundPopUpVerification = goBackgroundPopUpVerification.GetComponent<Image>();
        _imgInputCodePopUpVerification = goInputCodePopUpVerification.GetComponent<Image>();
        _imgBtnVerifyPopUpVerification = goBtnVerifyPopUpVerification.GetComponent<Image>();
        _imgBtnBackPopUpVerification = goBtnBackPopUpVerification.GetComponent<Image>();
        _imgBackgroundPopUpChangePassword = goBackgroundPopUpChangePassword.GetComponent<Image>();
        _imgInputNewPasswordPopUpChangePassword = goInputNewPasswordPopUpChangePassword.GetComponent<Image>();
        _imgBtnNewPasswordPasswordPopUpChangePassword = goBtnNewPasswordPasswordPopUpChangePassword.GetComponent<Image>();
        _imgInputConfirmPasswordPopUpChangePassword = goInputConfirmPasswordPopUpChangePassword.GetComponent<Image>();
        _imgBtnConfirmPasswordPasswordPopUpChangePassword = goBtnConfirmPasswordPasswordPopUpChangePassword.GetComponent<Image>();
        _imgBtnConfirmPopUpChangePassword = goBtnConfirmPopUpChangePassword.GetComponent<Image>();
        _imgBtnBackPopUpChangePassword = goBtnBackPopUpChangePassword.GetComponent<Image>();
        _imgBackgroundPopUpPasswordChange = goBackgroundPopUpPasswordChange.GetComponent<Image>();
        _imgBtnSignInPopUpChangePassword = goBtnSignInPopUpChangePassword.GetComponent<Image>();

        _InputEmailForgotPassword = goInputEmailForgotPassword.GetComponent<TMP_InputField>();
        _InputCodePopUpVerification = goInputCodePopUpVerification.GetComponent<TMP_InputField>();
        _InputNewPasswordPopUpChangePassword = goInputNewPasswordPopUpChangePassword.GetComponent<TMP_InputField>();
        _InputConfirmPasswordPopUpChangePassword = goInputConfirmPasswordPopUpChangePassword.GetComponent<TMP_InputField>();

        _tmpTitleForgotPassword = goTitleForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpPHInputEmailForgotPassword = goPHInputEmailForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputEmailForgotPassword = goTxtInputEmailForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoInputEmailForgotPassword = goTxtInfoInputEmailForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnSendForgotPassword = goTxtBtnSendForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnBackForgotPassword = goTxtBtnBackForgotPassword.GetComponent<TextMeshProUGUI>();
        _tmpTitlePopUpVerification = goTitlePopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpPHInputCodePopUpVerification = goPHInputCodePopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputCodePopUpVerification = goTxtInputCodePopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoInputCodePopUpVerification = goTxtInfoInputCodePopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnVerifyPopUpVerification = goTxtBtnVerifyPopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnBackPopUpVerification = goTxtBtnBackPopUpVerification.GetComponent<TextMeshProUGUI>();
        _tmpTitlePopUpChangePassword = goTitlePopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpPHInputNewPasswordPopUpChangePassword = goPHInputNewPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputNewPasswordPopUpChangePassword = goTxtInputNewPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpPHInputConfirmPasswordPopUpChangePassword = goPHInputConfirmPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInputConfirmPasswordPopUpChangePassword = goTxtInputConfirmPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtInfoPasswordPopUpChangePassword = goTxtInfoPasswordPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnConfirmPopUpChangePassword = goTxtBtnConfirmPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnBackPopUpChangePassword = goTxtBtnBackPopUpChangePassword.GetComponent<TextMeshProUGUI>();
        _tmpTitlePopUpPasswordChange = goTitlePopUpPasswordChange.GetComponent<TextMeshProUGUI>();
        _tmpTxtBtnSignInPopUpChangePassword = goTxtBtnSignInPopUpChangePassword.GetComponent<TextMeshProUGUI>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function will reinitialize info text and input block Color for the Canvas Forgot Password.
    /// </summary>
    public void ReinitializeAllCanvasForgotPassword()
    {
        _tmpTxtInfoInputEmailForgotPassword.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoInputCodePopUpVerification.text = _dbManager.m_message.BaseMessage();
        _tmpTxtInfoPasswordPopUpChangePassword.text = _dbManager.m_message.BaseMessage();
        _dbManager.m_dbVerification.ChangeInputFieldColor(_InputEmailForgotPassword, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_InputCodePopUpVerification, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_InputNewPasswordPopUpChangePassword, Color.white);
        _dbManager.m_dbVerification.ChangeInputFieldColor(_InputConfirmPasswordPopUpChangePassword, Color.white);
        _tmpTxtInputEmailForgotPassword.text = "";
        _tmpTxtInputCodePopUpVerification.text = "";
        _tmpTxtInputNewPasswordPopUpChangePassword.text = "";
        _tmpTxtInputConfirmPasswordPopUpChangePassword.text = "";
    }
    #endregion
}
