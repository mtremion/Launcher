using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Profile.
/// </summary>
[Serializable]
public class LanguageCanvasProfile
{
    #region SerializeField
    [Header("Canvas Profile.")]
    [Tooltip("Text : Personals Informations")]
    [SerializeField] protected string txtPersonnalsInformationsCanvasProfile;
    [Tooltip("Text : Pseudo :")]
    [SerializeField] protected string txtPseudoCanvasProfile;
    [Tooltip("Text : Last name :")]
    [SerializeField] protected string txtLastNameCanvasProfile;
    [Tooltip("Text : First name :")]
    [SerializeField] protected string txtFirstNameCanvasProfile;
    [Tooltip("Text : Email :")]
    [SerializeField] protected string txtEmailCanvasProfile;
    [Tooltip("Text : Change")]
    [SerializeField] protected string txtBtnChangeProfileCanvasProfile;
    [Tooltip("Text : Change password")]
    [SerializeField] protected string txtChangePasswordCanvasProfile;
    [Tooltip("Text : New password ...")]
    [SerializeField] protected string txtPHInputNewPasswordCanvasProfile;
    [Tooltip("Text : Confirm password ...")]
    [SerializeField] protected string txtPHInputConfirmPasswordCanvasProfile;
    [Tooltip("Text : Change")]
    [SerializeField] protected string txtBtnChangePasswordCanvasProfile;
    [Tooltip("Text : Password change")]
    [TextArea]
    [SerializeField] protected string txtPopUpChangePasswordCanvasProfile;
    [Tooltip("Text : Ok")]
    [SerializeField] protected string txtBtnOkPopUpChangePasswordCanvasProfile;
    [Tooltip("Text : Delete account")]
    [SerializeField] protected string txtDeleteAccountCanvasProfile;
    [Tooltip("Text : Delete")]
    [SerializeField] protected string txtBtnDeleteAccountPasswordCanvasProfile;
    [Tooltip("Text : Are you sure ?")]
    [TextArea]
    [SerializeField] protected string txtPopUpDeleteAccountCanvasProfile;
    [Tooltip("Text : Yes")]
    [SerializeField] protected string txtBtnYesPopUpDeleteAccountCanvasProfile;
    [Tooltip("Text : Cancel")]
    [SerializeField] protected string txtBtnCancelPopUpDeleteAccountCanvasProfile;
    #endregion

    #region Private
    GameObjectManager _goManager = null;
    DataBaseManager _dbManager = null;
    #endregion

    #region System
    public void Awake()
    {
        _goManager = GameObject.Find("GameObjectManager").GetComponent<GameObjectManager>();
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function is use to Change the language of data(s) for the Canvas Profile.
    /// </summary>
    public void ChangeLanguageCanvasProfile()
    {
        _goManager.m_goCanvasProfile.m_tmpTxtPersonnalsInformationsCanvasProfile.text = txtPersonnalsInformationsCanvasProfile;
        SetProfile();
        _goManager.m_goCanvasProfile.m_tmpTxtBtnChangeProfileCanvasProfile.text = txtBtnChangeProfileCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtChangePasswordCanvasProfile.text = txtChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPHInputNewPasswordCanvasProfile.text = txtPHInputNewPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPHInputConfirmPasswordCanvasProfile.text = txtPHInputConfirmPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnChangePasswordCanvasProfile.text = txtBtnChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPopUpChangePasswordCanvasProfile.text = txtPopUpChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnOkPopUpChangePasswordCanvasProfile.text = txtBtnOkPopUpChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtDeleteAccountCanvasProfile.text = txtDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnDeleteAccountPasswordCanvasProfile.text = txtBtnDeleteAccountPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPopUpDeleteAccountCanvasProfile.text = txtPopUpDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnYesPopUpDeleteAccountCanvasProfile.text = txtBtnYesPopUpDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnCancelPopUpDeleteAccountCanvasProfile.text = txtBtnCancelPopUpDeleteAccountCanvasProfile;
    }

    public void SetProfile()
    {
        _goManager.m_goCanvasProfile.m_tmpTxtPseudoCanvasProfile.text = txtPseudoCanvasProfile + _dbManager.m_actualPseudo;
        _goManager.m_goCanvasProfile.m_tmpTxtLastNameCanvasProfile.text = txtLastNameCanvasProfile + _dbManager.m_actualLastName;
        _goManager.m_goCanvasProfile.m_tmpTxtFirstNameCanvasProfile.text = txtFirstNameCanvasProfile + _dbManager.m_actualFirstName;
        _goManager.m_goCanvasProfile.m_tmpTxtEmailCanvasProfile.text = txtEmailCanvasProfile + _dbManager.m_actualEmail;
    }
    #endregion
}
