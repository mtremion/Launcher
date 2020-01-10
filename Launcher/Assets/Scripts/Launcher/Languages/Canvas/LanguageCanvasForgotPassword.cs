using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Forgot Password.
/// </summary>
[Serializable]
public class LanguageCanvasForgotPassword 
{
    #region SerializeField
    [Header("Canvas Forgot Password.")]
    [Tooltip("Text in the Canvas Forgot Password.")]
    [SerializeField] protected string titleCanvasForgotPassword;
    [Tooltip("Default text in the input Email.")]
    [SerializeField] protected string txtPHInputEmailCanvasForgotPassword;
    [Tooltip("Text in the button Send Email.")]
    [SerializeField] protected string txtBtnSendEmailForgotPassword;
    [Tooltip("Text in the button Back.")]
    [SerializeField] protected string txtBtnBackCanvasForgotPassword;
    [Header("Pop up Verification.")]
    [Tooltip("Text in the Pop Up Verification of the Canvas Forgot Password.")]
    [SerializeField] protected string titlePopUpVerificationCanvasForgotPassword;
    [Tooltip("Default text in the input Code of the Pop Up Verification.")]
    [SerializeField] protected string txtPHInputCodePopUpVerificationCanvasForgotPassword;
    [Tooltip("Default text in the button Verify of the Pop Up Verification.")]
    [SerializeField] protected string txtBtnVerifyPopUpVerificationForgotPassword;
    [Tooltip("Default text in the input Back of the Pop Up Verification.")]
    [SerializeField] protected string txtBtnBackPopUpVerificationCanvasForgotPassword;
    [Header("Pop up Change Password.")]
    [Tooltip("Text in the Pop Up Change Password of the Canvas Forgot Password.")]
    [SerializeField] protected string titlePopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Default text in the input New Password of the Pop Up Change Password.")]
    [SerializeField] protected string txtPHInputNewPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Default text in the input Confirm Password of the Pop Up Change Password.")]
    [SerializeField] protected string txtPHInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
    [Tooltip("Default text in the button Confirm of the Pop Up Change Password.")]
    [SerializeField] protected string txtBtnConfirmPopUpChangePasswordForgotPassword;
    [Tooltip("Default text in the input Cancel of the Pop Up Change Password.")]
    [SerializeField] protected string txtBtnCancelPopUpChangePasswordCanvasForgotPassword;
    [Header("Pop up Password Change.")]
    [Tooltip("Text in the Pop Up Password Change of the Canvas Forgot Password.")]
    [SerializeField] protected string titlePopUpPasswordChangeCanvasForgotPassword;
    [Tooltip("Default text in the input Sign In of the Pop Up Change Password.")]
    [SerializeField] protected string txtBtnSignInPopUpPasswordChangeCanvasForgotPassword;
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
    /// This function is use to Change the language of data(s) for the Canvas Forgot Password.
    /// </summary>
    public void ChangeLanguageCanvasForgotPassword()
    {
        _goManager.m_goCanvasForgotPassword.m_tmpTitleForgotPassword.text = titleCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputEmailForgotPassword.text = txtPHInputEmailCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnSendForgotPassword.text = txtBtnSendEmailForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackForgotPassword.text = txtBtnBackCanvasForgotPassword;

        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpVerification.text = titlePopUpVerificationCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputCodePopUpVerification.text = txtPHInputCodePopUpVerificationCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnVerifyPopUpVerification.text = txtBtnVerifyPopUpVerificationForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackPopUpVerification.text = txtBtnBackPopUpVerificationCanvasForgotPassword;

        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpChangePassword.text = titlePopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputNewPasswordPopUpChangePassword.text = txtPHInputNewPasswordPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpPHInputConfirmPasswordPopUpChangePassword.text = txtPHInputConfirmPasswordPopUpChangePasswordCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnConfirmPopUpChangePassword.text = txtBtnConfirmPopUpChangePasswordForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnBackPopUpChangePassword.text = txtBtnCancelPopUpChangePasswordCanvasForgotPassword;

        _goManager.m_goCanvasForgotPassword.m_tmpTitlePopUpPasswordChange.text = titlePopUpPasswordChangeCanvasForgotPassword;
        _goManager.m_goCanvasForgotPassword.m_tmpTxtBtnSignInPopUpChangePassword.text = txtBtnSignInPopUpPasswordChangeCanvasForgotPassword;
    }
    #endregion
}
