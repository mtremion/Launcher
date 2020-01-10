using UnityEngine;

/// <summary>
/// Abstract class for structure a language.
/// </summary>
public abstract class Language
{
    #region SerializeField
    [Header("Canvas Manager")]
    [Tooltip("Canvas manager.")]
    [SerializeField] LanguageCanvasManager canvasManager = new LanguageCanvasManager();
    [Header("Canvas Sign In")]
    [Tooltip("Canvas sign in.")]
    [SerializeField] LanguageCanvasSignIn canvasSignIn = new LanguageCanvasSignIn();
    [Header("Canvas Sign On")]
    [Tooltip("Canvas sign on.")]
    [SerializeField] LanguageCanvasSignOn canvasSignOn = new LanguageCanvasSignOn();
    [Header("Canvas Forgot Password")]
    [Tooltip("Canvas forgot password.")]
    [SerializeField] LanguageCanvasForgotPassword canvasForgotPassword = new LanguageCanvasForgotPassword();
    [Header("Canvas Launcher")]
    [Tooltip("Canvas Launcher.")]
    [SerializeField] LanguageCanvasLauncher canvasLauncher = new LanguageCanvasLauncher();
    [Header("Canvas Home")]
    [Tooltip("Canvas Home.")]
    [SerializeField] LanguageCanvasHome canvasHome = new LanguageCanvasHome();
    [Header("Canvas Librairy")]
    [Tooltip("Canvas Librairy.")]
    [SerializeField] LanguageCanvasLibrairy canvasLibrairy = new LanguageCanvasLibrairy();
    [Header("Canvas About Me")]
    [Tooltip("Canvas About Me.")]
    [SerializeField] LanguageCanvasAboutMe canvasAboutMe = new LanguageCanvasAboutMe();
    [Header("Canvas Contact")]
    [Tooltip("Canvas Contact.")]
    [SerializeField] LanguageCanvasContact canvasContact = new LanguageCanvasContact();
    [Header("Canvas Profile")]
    [Tooltip("Canvas Profile.")]
    [SerializeField] LanguageCanvasProfile canvasProfile = new LanguageCanvasProfile();
    [Header("Message")]
    [Tooltip("Message.")]
    [SerializeField] LanguageMessage message = new LanguageMessage();
    #endregion

    #region Getters & Setters
    public LanguageCanvasManager m_canvasManager { get { return canvasManager; } }
    public LanguageCanvasSignIn m_canvasSignIn { get { return canvasSignIn; } }
    public LanguageCanvasSignOn m_canvasSignOn { get { return canvasSignOn; } }
    public LanguageCanvasForgotPassword m_canvasForgotPassword { get { return canvasForgotPassword; } }
    public LanguageCanvasLauncher m_canvasLauncher { get { return canvasLauncher; } }
    public LanguageCanvasHome m_canvasHome { get { return canvasHome; } }
    public LanguageCanvasLibrairy m_canvasLibrairy { get { return canvasLibrairy; } }
    public LanguageCanvasAboutMe m_canvasAboutMe { get { return canvasAboutMe; } }
    public LanguageCanvasContact m_canvasContact { get { return canvasContact; } }
    public LanguageCanvasProfile m_canvasProfile { get { return canvasProfile; } }
    public LanguageMessage m_message { get { return message; } }
    #endregion 
}
