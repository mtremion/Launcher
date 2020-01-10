using UnityEngine;

/// <summary>
/// Abstract class for structure a theme.
/// </summary>
public abstract class Theme 
{
    #region SerializeField
    [Header("Canvas Manager")]
    [Tooltip("Canvas manager.")]
    [SerializeField] ThemeCanvasManager canvasManager = new ThemeCanvasManager();
    [Header("Canvas Sign In")]
    [Tooltip("Canvas sign in.")]
    [SerializeField] ThemeCanvasSignIn canvasSignIn = new ThemeCanvasSignIn();
    [Header("Canvas Sign On")]
    [Tooltip("Canvas sign on.")]
    [SerializeField] ThemeCanvasSignOn canvasSignOn = new ThemeCanvasSignOn();
    [Header("Canvas Forgot Password")]
    [Tooltip("Canvas forgot password.")]
    [SerializeField] ThemeCanvasForgotPassword canvasForgotPassword = new ThemeCanvasForgotPassword();
    [Header("Canvas Launcher")]
    [Tooltip("Canvas Launcher.")]
    [SerializeField] ThemeCanvasLauncher canvasLauncher = new ThemeCanvasLauncher();
    [Header("Canvas Home")]
    [Tooltip("Canvas Home.")]
    [SerializeField] ThemeCanvasHome canvasHome = new ThemeCanvasHome();
    [Header("Canvas Librairy")]
    [Tooltip("Canvas Librairy.")]
    [SerializeField] ThemeCanvasLibrairy canvasLibrairy = new ThemeCanvasLibrairy();
    [Header("Canvas About Me")]
    [Tooltip("Canvas About Me.")]
    [SerializeField] ThemeCanvasAboutMe canvasAboutMe = new ThemeCanvasAboutMe();
    [Header("Canvas Contact")]
    [Tooltip("Canvas Contact.")]
    [SerializeField] ThemeCanvasContact canvasContact = new ThemeCanvasContact();
    [Header("Canvas Profile")]
    [Tooltip("Canvas Profile.")]
    [SerializeField] ThemeCanvasProfile canvasProfile = new ThemeCanvasProfile();
    #endregion

    #region Getters & Setters
    public ThemeCanvasManager m_canvasManager { get { return canvasManager; } }
    public ThemeCanvasSignIn m_canvasSignIn { get { return canvasSignIn; } }
    public ThemeCanvasSignOn m_canvasSignOn { get { return canvasSignOn; } }
    public ThemeCanvasForgotPassword m_canvasForgotPassword { get { return canvasForgotPassword; } }
    public ThemeCanvasLauncher m_canvasLauncher { get { return canvasLauncher; } }
    public ThemeCanvasHome m_canvasHome { get { return canvasHome; } }
    public ThemeCanvasLibrairy m_canvasLibrairy { get { return canvasLibrairy; } }
    public ThemeCanvasAboutMe m_canvasAboutMe { get { return canvasAboutMe; } }
    public ThemeCanvasContact m_canvasContact { get { return canvasContact; } }
    public ThemeCanvasProfile m_canvasProfile { get { return canvasProfile; } }
    #endregion    
}
