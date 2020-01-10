using UnityEngine;

/// <summary>
/// This class contains data(s) lead all languages in the launcher.
/// </summary>
public class LanguageManager : MonoBehaviour
{
    #region SerializeField
    [Header("Languages")]
    [Tooltip("English language.")]
    [SerializeField] English english = new English();
    [Tooltip("French language.")]
    [SerializeField] French french = new French();
    [Tooltip("French language.")]
    [SerializeField] Spanish spanish = new Spanish();
    #endregion

    #region Getters & Setters
    public English m_english { get { return english; } }
    public French m_french { get { return french; } }
    public Spanish m_spanish { get { return spanish; } }
    #endregion

    #region Private
    GameObjectManager _goManager = null;
    #endregion

    #region System
    private void Awake()
    {
        _goManager = GameObject.Find("GameObjectManager").GetComponent<GameObjectManager>();

        english.Awake();
        french.Awake();
        spanish.Awake();
    }
    private void Start()
    {
        ChangeLanguage();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This fucntion will change language to the chosen one.
    /// </summary>
    public void ChangeLanguage()
    {
        switch(_goManager.m_goCanvasManager.m_dropDownLanguageCanvasManager.value)
        {
            case 0:
                english.m_canvasManager.ChangeLanguageCanvasManager();
                english.m_canvasSignIn.ChangeLanguageCanvasSignIn();
                english.m_canvasSignOn.ChangeLanguageCanvasSignOn();
                english.m_canvasForgotPassword.ChangeLanguageCanvasForgotPassword();
                english.m_canvasLauncher.ChangeLanguageCanvasLauncher();
                english.m_canvasHome.ChangeLanguageCanvasHome();
                english.m_canvasLibrairy.ChangeLanguageCanvasLibrairy();
                english.m_canvasAboutMe.ChangeLanguageCanvasAboutMe();
                english.m_canvasContact.ChangeLanguageCanvasContact();
                english.m_canvasProfile.ChangeLanguageCanvasProfile();
                break;
            case 1:
                french.m_canvasManager.ChangeLanguageCanvasManager();
                french.m_canvasSignIn.ChangeLanguageCanvasSignIn();
                french.m_canvasSignOn.ChangeLanguageCanvasSignOn();
                french.m_canvasForgotPassword.ChangeLanguageCanvasForgotPassword();
                french.m_canvasLauncher.ChangeLanguageCanvasLauncher();
                french.m_canvasHome.ChangeLanguageCanvasHome();
                french.m_canvasLibrairy.ChangeLanguageCanvasLibrairy();
                french.m_canvasAboutMe.ChangeLanguageCanvasAboutMe();
                french.m_canvasContact.ChangeLanguageCanvasContact();
                french.m_canvasProfile.ChangeLanguageCanvasProfile();
                break;
            case 2:
                spanish.m_canvasManager.ChangeLanguageCanvasManager();
                spanish.m_canvasSignIn.ChangeLanguageCanvasSignIn();
                spanish.m_canvasSignOn.ChangeLanguageCanvasSignOn();
                spanish.m_canvasForgotPassword.ChangeLanguageCanvasForgotPassword();
                spanish.m_canvasLauncher.ChangeLanguageCanvasLauncher();
                spanish.m_canvasHome.ChangeLanguageCanvasHome();
                spanish.m_canvasLibrairy.ChangeLanguageCanvasLibrairy();
                spanish.m_canvasAboutMe.ChangeLanguageCanvasAboutMe();
                spanish.m_canvasContact.ChangeLanguageCanvasContact();
                spanish.m_canvasProfile.ChangeLanguageCanvasProfile();
                break;
            default:
                break;
        }
    }

    public void SetProfileCanvasProfile()
    {
        switch (_goManager.m_goCanvasManager.m_dropDownLanguageCanvasManager.value)
        {
            case 0:
                english.m_canvasProfile.SetProfile();
                break;
            case 1:
                french.m_canvasProfile.SetProfile();
                break;
            case 2:
                spanish.m_canvasProfile.SetProfile();
                break;
            default:
                break;
        }
    }
    #endregion
}
