using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Forgot Password.
/// </summary>
[Serializable]
public class ThemeCanvasForgotPassword 
{
    #region Static
    static bool NEW_PASSWORD_VISIBLE = false;
    static bool CONFIRM_PASSWORD_VISIBLE = false;
    #endregion

    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Background")]
    [Tooltip("Sprite of the background.")]
    [SerializeField] Sprite imgBackgroundCanvasForgotPassword;
    [Tooltip("Position of the background.")]
    [SerializeField] RectTransform transformBackgroundCanvasForgotPassword;
    [Header("Title")]
    [Tooltip("Position of the title of the canvas forgot password.")]
    [SerializeField] RectTransform transformTitleCanvasForgotPassword;
    [Tooltip("Color of the title of the canvas forgot password.")]
    [SerializeField] Color colorTitleCanvasForgotPassword;
    [Header("Input Email")]
    [Tooltip("Position of the input email.")]
    [SerializeField] RectTransform transformInputEmailCanvasForgotPassword;
    [Tooltip("Sprite of the input email.")]
    [SerializeField] Sprite imgInputEmailCanvasForgotPassword;
    [Tooltip("Color of the placeholder of the input email.")]
    [SerializeField] Color colorTxtPHInputEmailCanvasForgotPassword;
    [Tooltip("Color of the txt of the input email.")]
    [SerializeField] Color colorTxtInputEmailCanvasForgotPassword;
    [Header("Info Email")]
    [Tooltip("Position of the info email.")]
    [SerializeField] RectTransform transformTxtInfoEmailCanvasForgotPassword;
    [Header("Button Send")]
    [Tooltip("Position of the button Send.")]
    [SerializeField] RectTransform transformBtnSendCanvasForgotPassword;
    [Tooltip("Sprite of the button Send.")]
    [SerializeField] Sprite imgBtnSendCanvasForgotPassword;
    [Tooltip("Color of the text of the button Send.")]
    [SerializeField] Color colorTxtBtnSendCanvasForgotPassword;
    [Header("Button Back")]
    [Tooltip("Position of the button Back.")]
    [SerializeField] RectTransform transformBtnBackCanvasForgotPassword;
    [Tooltip("Sprite of the button Back.")]
    [SerializeField] Sprite imgBtnBackCanvasForgotPassword;
    [Tooltip("Color of the text of the button Back.")]
    [SerializeField] Color colorTxtBtnBackCanvasForgotPassword;
    [Header("Pop Up Verification / Background")]
    [Tooltip("Sprite of the background.")]
    [SerializeField] Sprite imgBackgroundPopUpVerificationCanvasForgotPassword;
    [Tooltip("Position of the background.")]
    [SerializeField] RectTransform transformBackgroundPopUpVerificationCanvasForgotPassword;
    [Header("Pop Up Verification / Title")]
    [Tooltip("Position of the title of the Pop Up Verification.")]
    [SerializeField] RectTransform transformTitlePopUpVerificationCanvasForgotPassword;
    [Tooltip("Color of the title of the Pop Up Verification.")]
    [SerializeField] Color colorTitlePopUpVerificationCanvasForgotPassword;
    [Header("Pop Up Verification / Input Code")]
    [Tooltip("Position of the input code.")]
    [SerializeField] RectTransform transformInputCodePopUpVerificationCanvasForgotPassword;
    [Tooltip("Sprite of the input code.")]
    [SerializeField] Sprite imgInputCodePopUpVerificationCanvasForgotPassword;
    [Tooltip("Color of the placeholder of the input code.")]
    [SerializeField] Color colorTxtPHInputCodePopUpVerificationCanvasForgotPassword;
    [Tooltip("Color of the txt of the input code.")]
    [SerializeField] Color colorTxtInputCodePopUpVerificationCanvasForgotPassword;
    [Header("Pop Up Verification / Info Code")]
    [Tooltip("Position of the info code.")]
    [SerializeField] RectTransform transformTxtInfoCodePopUpVerificationCanvasForgotPassword;
    [Header("Pop Up Verification / Button Verify")]
    [Tooltip("Position of the button Verify.")]
    [SerializeField] RectTransform transformBtnVerifyPopUpVerificationCanvasForgotPassword;
    [Tooltip("Sprite of the button Verify.")]
    [SerializeField] Sprite imgBtnVerifyPopUpVerificationCanvasForgotPassword;
    [Tooltip("Color of the text of the button Verify.")]
    [SerializeField] Color colorTxtBtnVerifyPopUpVerificationCanvasForgotPassword;
    [Header("Pop Up Verification / Button Back")]
    [Tooltip("Position of the button Back.")]
    [SerializeField] RectTransform transformBtnBackPopUpVerificationCanvasForgotPassword;
    [Tooltip("Sprite of the button Back.")]
    [SerializeField] Sprite imgBtnBackPopUpVerificationCanvasForgotPassword;
    [Tooltip("Color of the text of the button Back.")]
    [SerializeField] Color colorTxtBtnBackPopUpVerificationCanvasForgotPassword;
    [Header("Pop Up Change Password / Background")]
    [Tooltip("Sprite of the background.")]
    [SerializeField] Sprite imgBackgroundPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Position of the background.")]
    [SerializeField] RectTransform transformBackgroundPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Change Password / Title")]
    [Tooltip("Position of the title of the Pop Up Change Password.")]
    [SerializeField] RectTransform transformTitlePopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Color of the title of the Pop Up Change Password.")]
    [SerializeField] Color colorTitlePopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Change Password / Input New Password")]
    [Tooltip("Position of the input new password.")]
    [SerializeField] RectTransform transformInputNewPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Sprite of the input new password.")]
    [SerializeField] Sprite imgInputNewPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Color of the placeholder of the input new password.")]
    [SerializeField] Color colorTxtPHInputNewPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Color of the txt of the input new password.")]
    [SerializeField] Color colorTxtInputNewPasswordPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Change Password / Visibility new password")]
    [Tooltip("Position of the button Visibility new password.")]
    [SerializeField] RectTransform transformBtnVisibilityNewPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Sprite visible of the button  Visibility new password.")]
    [SerializeField] Sprite imgBtnVisibleNewPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Sprite not visible of the button  Visibility new password.")]
    [SerializeField] Sprite imgBtnNotVisibleNewPasswordPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Change Password / Input Confirm Password")]
    [Tooltip("Position of the input Confirm password.")]
    [SerializeField] RectTransform transformInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Sprite of the input Confirm password.")]
    [SerializeField] Sprite imgInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Color of the placeholder of the input Confirm password.")]
    [SerializeField] Color colorTxtPHInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Color of the txt of the input Confirm password.")]
    [SerializeField] Color colorTxtInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Change Password / Visibility Confirm password")]
    [Tooltip("Position of the button Visibility Confirm password.")]
    [SerializeField] RectTransform transformBtnVisibilityConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Sprite visible of the button Visibility Confirm password.")]
    [SerializeField] Sprite imgBtnVisibleConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Sprite not visible of the button Visibility Confirm password.")]
    [SerializeField] Sprite imgBtnNotVisibleConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Change Password / Info Password")]
    [Tooltip("Position of the info Password.")]
    [SerializeField] RectTransform transformTxtInfoPasswordPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Change Password / Button Confirm")]
    [Tooltip("Position of the button Confirm.")]
    [SerializeField] RectTransform transformBtnConfirmPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Sprite of the button Confirm.")]
    [SerializeField] Sprite imgBtnConfirmPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Color of the text of the button Confirm.")]
    [SerializeField] Color colorTxtBtnConfirmPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Change Password / Button Cancel")]
    [Tooltip("Position of the button Cancel.")]
    [SerializeField] RectTransform transformBtnCancelPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Sprite of the button Cancel.")]
    [SerializeField] Sprite imgBtnCancelPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Color of the text of the button Cancel.")]
    [SerializeField] Color colorTxtBtnCancelPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop Up Password Change/ Background")]
    [Tooltip("Sprite of the background.")]
    [SerializeField] Sprite imgBackgroundPopUpPasswordChangeCanvasForgotPassword;
    [Tooltip("Position of the background.")]
    [SerializeField] RectTransform transformBackgroundPopUpPasswordChangeCanvasForgotPassword;
    [Header("Pop Up Password Change / Title")]
    [Tooltip("Position of the title of the Pop Up Password Change.")]
    [SerializeField] RectTransform transformTitlePopUpPasswordChangeCanvasForgotPassword;
    [Tooltip("Color of the title of the Pop Up Password Change.")]
    [SerializeField] Color colorTitlePopUpPasswordChangeCanvasForgotPassword;
    [Header("Pop Up Password Change  / Button Sign In")]
    [Tooltip("Position of the button Sign In.")]
    [SerializeField] RectTransform transformBtnSignInPopUpPasswordChangeCanvasForgotPassword;
    [Tooltip("Sprite of the button Sign In.")]
    [SerializeField] Sprite imgBtnSignInPopUpPasswordChangeCanvasForgotPassword;
    [Tooltip("Color of the text of the button Sign In.")]
    [SerializeField] Color colorTxtBtnSignInPopUpPasswordChangeCanvasForgotPassword;
    #endregion

    #region Getters & Setters
    public bool m_newPasswordVisible { get { return NEW_PASSWORD_VISIBLE; } set {NEW_PASSWORD_VISIBLE = value; } }
    public bool m_confirmPasswordVisible { get { return CONFIRM_PASSWORD_VISIBLE; } set { CONFIRM_PASSWORD_VISIBLE = value; } }
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
    /// Function use to change the theme on the Canvas Forgot Password.
    /// </summary>
    public void ChangeThemeCanvasForgotPassword()
    {
        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBackgroundForgotPassword, transformBackgroundCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBackgroundForgotPassword.sprite = imgBackgroundCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformTitleForgotPassword, transformTitleCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_tmpTitleForgotPassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTitleForgotPassword.color = colorTitleCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformInputEmailForgotPassword, transformInputEmailCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgInputEmailForgotPassword.sprite = imgInputEmailCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputEmailForgotPassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputEmailForgotPassword.color = colorTxtPHInputEmailCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInputEmailForgotPassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInputEmailForgotPassword.color = colorTxtInputEmailCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformTxtInfoInputEmailForgotPassword, transformTxtInfoEmailCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoInputEmailForgotPassword.font = font;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnSendForgotPassword, transformBtnSendCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBtnSendForgotPassword.sprite = imgBtnSendCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnSendForgotPassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnSendForgotPassword.color = colorTxtBtnSendCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnBackForgotPassword, transformBtnBackCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBtnBackForgotPassword.sprite = imgBtnBackCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackForgotPassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackForgotPassword.color = colorTxtBtnBackCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBackgroundPopUpVerification, transformBackgroundPopUpVerificationCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBackgroundPopUpVerification.sprite = imgBackgroundPopUpVerificationCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformTitlePopUpVerification, transformTitlePopUpVerificationCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpVerification.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpVerification.color = colorTitlePopUpVerificationCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformInputCodePopUpVerification, transformInputCodePopUpVerificationCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgInputCodePopUpVerification.sprite = imgInputCodePopUpVerificationCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputCodePopUpVerification.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputCodePopUpVerification.color = colorTxtPHInputCodePopUpVerificationCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInputCodePopUpVerification.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInputCodePopUpVerification.color = colorTxtInputCodePopUpVerificationCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformTxtInfoInputCodePopUpVerification, transformTxtInfoCodePopUpVerificationCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoInputCodePopUpVerification.font = font;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnVerifyPopUpVerification, transformBtnVerifyPopUpVerificationCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBtnVerifyPopUpVerification.sprite = imgBtnVerifyPopUpVerificationCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnVerifyPopUpVerification.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnVerifyPopUpVerification.color = colorTxtBtnVerifyPopUpVerificationCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnBackPopUpVerification, transformBtnBackPopUpVerificationCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBtnBackPopUpVerification.sprite = imgBtnBackPopUpVerificationCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackPopUpVerification.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackPopUpVerification.color = colorTxtBtnBackPopUpVerificationCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBackgroundPopUpChangePassword, transformBackgroundPopUpChangePasswordCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBackgroundPopUpChangePassword.sprite = imgBackgroundPopUpChangePasswordCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformTitlePopUpChangePassword, transformTitlePopUpChangePasswordCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpChangePassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpChangePassword.color = colorTitlePopUpChangePasswordCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformInputNewPasswordPopUpChangePassword, transformInputNewPasswordPopUpChangePasswordCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgInputNewPasswordPopUpChangePassword.sprite = imgInputNewPasswordPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputNewPasswordPopUpChangePassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputNewPasswordPopUpChangePassword.color = colorTxtPHInputNewPasswordPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInputNewPasswordPopUpChangePassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInputNewPasswordPopUpChangePassword.color = colorTxtInputNewPasswordPopUpChangePasswordCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnNewPasswordVisibilityPopUpChangePassword, transformBtnVisibilityNewPasswordPopUpChangePasswordCanvasForgotPassword);
        if (NEW_PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasForgotPassword.m_imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = imgBtnVisibleNewPasswordPopUpChangePasswordCanvasForgotPassword;
            _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Alphanumeric;
        }
        else
        {
            _goManager.m_goCanvasForgotPassword.m_imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = imgBtnNotVisibleNewPasswordPopUpChangePasswordCanvasForgotPassword;
            _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        }

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformInputConfirmPasswordPopUpChangePassword, transformInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgInputConfirmPasswordPopUpChangePassword.sprite = imgInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputConfirmPasswordPopUpChangePassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputConfirmPasswordPopUpChangePassword.color = colorTxtPHInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInputConfirmPasswordPopUpChangePassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInputConfirmPasswordPopUpChangePassword.color = colorTxtInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnConfirmPasswordVisibilityPopUpChangePassword, transformBtnVisibilityConfirmPasswordPopUpChangePasswordCanvasForgotPassword);
        if (CONFIRM_PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasForgotPassword.m_imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = imgBtnVisibleConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
            _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Alphanumeric;
        }
        else
        {
            _goManager.m_goCanvasForgotPassword.m_imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = imgBtnNotVisibleConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
            _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        }

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformTxtInfoPasswordPopUpChangePassword, transformTxtInfoPasswordPopUpChangePasswordCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoPasswordPopUpChangePassword.font = font;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnConfirmPopUpChangePassword, transformBtnConfirmPopUpChangePasswordCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBtnConfirmPopUpChangePassword.sprite = imgBtnConfirmPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnConfirmPopUpChangePassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnConfirmPopUpChangePassword.color = colorTxtBtnConfirmPopUpChangePasswordCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnBackPopUpChangePassword, transformBtnCancelPopUpChangePasswordCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBtnBackPopUpChangePassword.sprite = imgBtnCancelPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackPopUpChangePassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackPopUpChangePassword.color = colorTxtBtnCancelPopUpChangePasswordCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBackgroundPopUpPasswordChange, transformBackgroundPopUpPasswordChangeCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBackgroundPopUpPasswordChange.sprite = imgBackgroundPopUpPasswordChangeCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformTitlePopUpPasswordChange, transformTitlePopUpPasswordChangeCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpPasswordChange.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpPasswordChange.color = colorTitlePopUpPasswordChangeCanvasForgotPassword;

        ChangeRectTransform(_goManager.m_goCanvasForgotPassword.m_transformBtnSignInPopUpPasswordChange, transformBtnSignInPopUpPasswordChangeCanvasForgotPassword);
        _goManager.m_goCanvasForgotPassword.m_imgBtnSignInPopUpChangePassword.sprite = imgBtnSignInPopUpPasswordChangeCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnSignInPopUpChangePassword.font = font;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnSignInPopUpChangePassword.color = colorTxtBtnSignInPopUpPasswordChangeCanvasForgotPassword;
    }

    /// <summary>
    /// Function use to change the position of data(s) on the Canvas Forgot Password.
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
    /// Function use to change the visibilty of the new password for the Canvas Forgot Password.
    /// </summary>
    public void ChangeNewPasswordVisibility()
    {
        NEW_PASSWORD_VISIBLE = !NEW_PASSWORD_VISIBLE;

        if (NEW_PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasForgotPassword.m_imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = imgBtnVisibleNewPasswordPopUpChangePasswordCanvasForgotPassword;
            _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Alphanumeric;
            _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.ForceLabelUpdate();
        }
        else
        {
            _goManager.m_goCanvasForgotPassword.m_imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = imgBtnNotVisibleNewPasswordPopUpChangePasswordCanvasForgotPassword;
            _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
            _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.ForceLabelUpdate();
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the confirm password for the Canvas Forgot Password.
    /// </summary>
    public void ChangeConfirmPasswordVisibility()
    {
        CONFIRM_PASSWORD_VISIBLE = !CONFIRM_PASSWORD_VISIBLE;

        if (CONFIRM_PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasForgotPassword.m_imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = imgBtnVisibleConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
            _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Alphanumeric;
            _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.ForceLabelUpdate();
        }
        else
        {
            _goManager.m_goCanvasForgotPassword.m_imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = imgBtnNotVisibleConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
            _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
            _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.ForceLabelUpdate();
        }
    }
    /// <summary>
    /// Function use to reinitialize the visibilty button to not visible for Canvas forgot password.
    /// </summary>
    public void ReinitializeVisibilityButtonCanvasForgotPassword()
    {
        NEW_PASSWORD_VISIBLE = false;
        CONFIRM_PASSWORD_VISIBLE = false;

        _goManager.m_goCanvasForgotPassword.m_imgBtnNewPasswordVisibilityPopUpChangePassword.sprite = imgBtnNotVisibleNewPasswordPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.ForceLabelUpdate();

        _goManager.m_goCanvasForgotPassword.m_imgBtnConfirmPasswordVisibilityPopUpChangePassword.sprite = imgBtnNotVisibleConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.ForceLabelUpdate();
    }
    #endregion
}
