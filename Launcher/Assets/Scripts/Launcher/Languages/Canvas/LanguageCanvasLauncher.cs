using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Launcher.
/// </summary>
[Serializable]
public class LanguageCanvasLauncher
{
    #region SerializeField
    [Header("Canvas Launcher.")]
    [Tooltip("Text button Home.")]
    [SerializeField] protected string txtBtnHomeCanvasLauncher;
    [Tooltip("Text button Librairy.")]
    [SerializeField] protected string txtBtnLibrairyCanvasLauncher;
    [Tooltip("Text button About Me.")]
    [SerializeField] protected string txtBtnAboutMeCanvasLauncher;
    [Tooltip("Text button Contact.")]
    [SerializeField] protected string txtBtnContactCanvasLauncher;
    [Tooltip("Text button Profil.")]
    [SerializeField] protected string txtBtnProfilCanvasLauncher;
    [Tooltip("Text Pop Up Deconnection.")]
    [TextArea]
    [SerializeField] protected string txtPopUpDeconnectionCanvasLauncher;
    [Tooltip("Text button Yes Pop Up Deconnection.")]
    [SerializeField] protected string txtBtnYesPopUpDeconnectionCanvasLauncher;
    [Tooltip("Text button No Pop Up Deconnection.")]
    [SerializeField] protected string txtBtnNoPopUpDeconnectionCanvasLauncher;
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
    /// This function is use to Change the language of data(s) for the Canvas Launcher.
    /// </summary>
    public void ChangeLanguageCanvasLauncher()
    {
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnHomeCanvasLauncher.text = txtBtnHomeCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnLibrairyCanvasLauncher.text = txtBtnLibrairyCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnAboutMeCanvasLauncher.text = txtBtnAboutMeCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnContactCanvasLauncher.text = txtBtnContactCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnProfilCanvasLauncher.text = txtBtnProfilCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtPopUpDeconnectionCanvasLauncher.text = txtPopUpDeconnectionCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnYesPopUpDeconnectionCanvasLauncher.text = txtBtnYesPopUpDeconnectionCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnNoPopUpDeconnectionCanvasLauncher.text = txtBtnNoPopUpDeconnectionCanvasLauncher;
    }
    #endregion
}
