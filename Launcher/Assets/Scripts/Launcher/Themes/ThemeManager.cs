using UnityEngine;

/// <summary>
/// This class contains data(s) lead all Themes in the launcher.
/// </summary>
public class ThemeManager : MonoBehaviour
{
    #region SerializeField
    [Header("Themes")]
    [Tooltip("Steampunk mobile's theme.")]
    [SerializeField] ThemeSteampunkMobile steampunkMobile = new ThemeSteampunkMobile();
    [Tooltip("Steampunk mobile's theme.")]
    [SerializeField] ThemeSciFiMobile sciFiMobile = new ThemeSciFiMobile();
    [Tooltip("Steampunk mobile's theme.")]
    [SerializeField] ThemeMedievalMobile medievalMobile = new ThemeMedievalMobile();
    #endregion

    #region Getters & Setters
    public AudioClip m_actualAudioClip { get { return _actualAudioClip; } }
    #endregion

    #region Private
    AudioClip _actualAudioClip = null;
    GameObjectManager _goManager = null;
    DataBaseManager _dbManager = null;
    #endregion

    #region System
    private void Awake()
    {
        _goManager = GameObject.Find("GameObjectManager").GetComponent<GameObjectManager>();
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _actualAudioClip = steampunkMobile.m_canvasManager.m_audioClipCanvasManager;

        steampunkMobile.Awake();
        sciFiMobile.Awake();
        medievalMobile.Awake();
    }
    private void Start()
    {
        ChangeTheme();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This fucntion will change theme to the chosen one.
    /// </summary>
    public void ChangeTheme()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                _actualAudioClip = steampunkMobile.m_canvasManager.m_audioClipCanvasManager;
                steampunkMobile.m_canvasManager.ChangeThemeCanvasManager();
                steampunkMobile.m_canvasSignIn.ChangeThemeCanvasSignIn();
                steampunkMobile.m_canvasSignOn.ChangeThemeCanvasSignOn();
                steampunkMobile.m_canvasForgotPassword.ChangeThemeCanvasForgotPassword();
                steampunkMobile.m_canvasLauncher.ChangeThemeCanvasLauncher();
                steampunkMobile.m_canvasHome.ChangeThemeCanvasHome();
                steampunkMobile.m_canvasLibrairy.ChangeThemeCanvasLibrairy();
                steampunkMobile.m_canvasAboutMe.ChangeThemeCanvasAboutMe();
                steampunkMobile.m_canvasContact.ChangeThemeCanvasContact();
                steampunkMobile.m_canvasProfile.ChangeThemeCanvasProfile();
                _dbManager.m_dbGet.GetProfileImage(_dbManager.m_actualPseudo);
                break;
            case 1:
                _actualAudioClip = sciFiMobile.m_canvasManager.m_audioClipCanvasManager;
                sciFiMobile.m_canvasManager.ChangeThemeCanvasManager();
                sciFiMobile.m_canvasSignIn.ChangeThemeCanvasSignIn();
                sciFiMobile.m_canvasSignOn.ChangeThemeCanvasSignOn();
                sciFiMobile.m_canvasForgotPassword.ChangeThemeCanvasForgotPassword();
                sciFiMobile.m_canvasLauncher.ChangeThemeCanvasLauncher();
                sciFiMobile.m_canvasHome.ChangeThemeCanvasHome();
                sciFiMobile.m_canvasLibrairy.ChangeThemeCanvasLibrairy();
                sciFiMobile.m_canvasAboutMe.ChangeThemeCanvasAboutMe();
                sciFiMobile.m_canvasContact.ChangeThemeCanvasContact();
                sciFiMobile.m_canvasProfile.ChangeThemeCanvasProfile();
                _dbManager.m_dbGet.GetProfileImage(_dbManager.m_actualPseudo);
                break;
            case 2:
                _actualAudioClip = medievalMobile.m_canvasManager.m_audioClipCanvasManager;
                medievalMobile.m_canvasManager.ChangeThemeCanvasManager();
                medievalMobile.m_canvasSignIn.ChangeThemeCanvasSignIn();
                medievalMobile.m_canvasSignOn.ChangeThemeCanvasSignOn();
                medievalMobile.m_canvasForgotPassword.ChangeThemeCanvasForgotPassword();
                medievalMobile.m_canvasLauncher.ChangeThemeCanvasLauncher();
                medievalMobile.m_canvasHome.ChangeThemeCanvasHome();
                medievalMobile.m_canvasLibrairy.ChangeThemeCanvasLibrairy();
                medievalMobile.m_canvasAboutMe.ChangeThemeCanvasAboutMe();
                medievalMobile.m_canvasContact.ChangeThemeCanvasContact();
                medievalMobile.m_canvasProfile.ChangeThemeCanvasProfile();
                _dbManager.m_dbGet.GetProfileImage(_dbManager.m_actualPseudo);
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the password for the Canvas Sign On.
    /// </summary>
    public void ChangePasswordVisibilityCanvasSignOn()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasSignOn.ChangePasswordVisibility();
                break;
            case 1:
                sciFiMobile.m_canvasSignOn.ChangePasswordVisibility();
                break;
            case 2:
                medievalMobile.m_canvasSignOn.ChangePasswordVisibility();
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the confirm password for the Canvas Sign On.
    /// </summary>
    public void ReinitializeVisibilityButtonCanvasSignOn()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasSignOn.ReinitializeVisibilityButtonCanvasSignOn();
                break;
            case 1:
                sciFiMobile.m_canvasSignOn.ReinitializeVisibilityButtonCanvasSignOn();
                break;
            case 2:
                medievalMobile.m_canvasSignOn.ReinitializeVisibilityButtonCanvasSignOn();
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the new password for the Canvas Forgot Password.
    /// </summary>
    public void ChangeNewPasswordVisibilityCanvasForgotPassword()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasForgotPassword.ChangeNewPasswordVisibility();
                break;
            case 1:
                sciFiMobile.m_canvasForgotPassword.ChangeNewPasswordVisibility();
                break;
            case 2:
                medievalMobile.m_canvasForgotPassword.ChangeNewPasswordVisibility();
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the confirm password for the Canvas Forgot Password.
    /// </summary>
    public void ChangeConfirmPasswordVisibilityCanvasForgotPassword()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasForgotPassword.ChangeConfirmPasswordVisibility();
                break;
            case 1:
                sciFiMobile.m_canvasForgotPassword.ChangeConfirmPasswordVisibility();
                break;
            case 2:
                medievalMobile.m_canvasForgotPassword.ChangeConfirmPasswordVisibility();
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the confirm password for the Canvas Forgot password.
    /// </summary>
    public void ReinitializeVisibilityButtonCanvasForgotPassword()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasForgotPassword.ReinitializeVisibilityButtonCanvasForgotPassword();
                break;
            case 1:
                sciFiMobile.m_canvasForgotPassword.ReinitializeVisibilityButtonCanvasForgotPassword();
                break;
            case 2:
                medievalMobile.m_canvasForgotPassword.ReinitializeVisibilityButtonCanvasForgotPassword();
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to change the focus canvas for the Canvas Launcher.
    /// </summary>
    public void ChangeFocusCanvasLauncher(string focus)
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasLauncher.ChangeFocus(focus);
                break;
            case 1:
                sciFiMobile.m_canvasLauncher.ChangeFocus(focus);
                break;
            case 2:
                medievalMobile.m_canvasLauncher.ChangeFocus(focus);
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to change the focus information for the Canvas Home.
    /// </summary>
    public void ChangeFocusCanvasHome(int change)
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasHome.ChangeActualInformation(change);
                break;
            case 1:
                sciFiMobile.m_canvasHome.ChangeActualInformation(change);
                break;
            case 2:
                medievalMobile.m_canvasHome.ChangeActualInformation(change);
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to get the timer from Canvas Home.
    /// </summary>
    public float GotTimerCanvasHome()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                return steampunkMobile.m_canvasHome.m_timer;
            case 1:
                return sciFiMobile.m_canvasHome.m_timer;
            case 2:
                return medievalMobile.m_canvasHome.m_timer;
            default:
                return 0;
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the new password for the Canvas Profile.
    /// </summary>
    public void ChangeNewPasswordVisibilityCanvasProfile()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasProfile.ChangeNewPasswordVisibilityCanvasProfile();
                break;
            case 1:
                sciFiMobile.m_canvasProfile.ChangeNewPasswordVisibilityCanvasProfile();
                break;
            case 2:
                medievalMobile.m_canvasProfile.ChangeNewPasswordVisibilityCanvasProfile();
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the confrim password for the Canvas Profile.
    /// </summary>
    public void ChangeConfirmPasswordVisibilityCanvasProfile()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasProfile.ChangeConfirmPasswordVisibilityCanvasProfile();
                break;
            case 1:
                sciFiMobile.m_canvasProfile.ChangeConfirmPasswordVisibilityCanvasProfile();
                break;
            case 2:
                medievalMobile.m_canvasProfile.ChangeConfirmPasswordVisibilityCanvasProfile();
                break;
            default:
                break;
        }
    }
    public void ReinitializeVisibilityButtonCanvasProfil()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value)
        {
            case 0:
                steampunkMobile.m_canvasProfile.ReinitializeVisibilityButtonCanvasProfil();
                break;
            case 1:
                sciFiMobile.m_canvasProfile.ReinitializeVisibilityButtonCanvasProfil();
                break;
            case 2:
                medievalMobile.m_canvasProfile.ReinitializeVisibilityButtonCanvasProfil();
                break;
            default:
                break;
        }
    }
    #endregion
}
