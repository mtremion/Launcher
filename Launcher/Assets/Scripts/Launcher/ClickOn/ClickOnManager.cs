using UnityEngine;
using TMPro;
using System.Collections;

/// <summary>
/// This class contains mains data(s) for click's action(s) on the Launcher.
/// </summary>
public class ClickOnManager : MonoBehaviour
{
    #region Private
    DataBaseManager _dbManager = null;
    GameObjectManager _goManager = null;
    SoundManager _sndManager = null;
    ThemeManager _themeManager = null;
    LanguageManager _languageManager = null;
    BrowserFileManager _bfManager = null;
    #endregion

    #region System
    private void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();
        _goManager = GameObject.Find("GameObjectManager").GetComponent<GameObjectManager>();
        _sndManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        _themeManager = GameObject.Find("ThemeManager").GetComponent<ThemeManager>();
        _languageManager = GameObject.Find("LanguageManager").GetComponent<LanguageManager>();
        _bfManager = GameObject.Find("BrowserFileManager").GetComponent<BrowserFileManager>();
    }
    #endregion

    #region Main Methods

    #region Canvas Manager
    /// <summary>
    /// This function will stop or play the music.
    /// </summary>
    public void OnClickToggleMute()
    {
        _sndManager.AllowMusic();
    }
    /// <summary>
    /// This function will change Theme.
    /// </summary>
    public void OnValueChangeTheme()
    {
        _themeManager.ChangeTheme();
        _sndManager.ChangeAudioClip();
    }
    /// <summary>
    /// This function will change Language.
    /// </summary>
    public void OnValueChangeLanguage()
    {
        _languageManager.ChangeLanguage();
        _goManager.ReinitializeAll();
    }
    /// <summary>
    /// Function use to show Pop Up Credit from Canvas Manager.
    /// </summary>
    public void ClickOnCreditCanvasManager()
    {
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_goPopUpCredit);

        _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignIn.m_inputPseudoCanvasSignIn);
        _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignIn.m_inputPasswordCanvasSignIn);
    }
    /// <summary>
    /// Function use to hide Pop Up Credit from Canvas Manager.
    /// </summary>
    public void ClickOnClosePopUpCreditCanvasManager()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_goPopUpCredit);

        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignIn.m_inputPseudoCanvasSignIn);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignIn.m_inputPasswordCanvasSignIn);
    }
    /// <summary>
    /// Function use to show Pop Up Quit from Canvas Manager.
    /// </summary>
    public void ClickOnQuitCanvasManager()
    {
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_goPopUpQuit);

        _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignIn.m_inputPseudoCanvasSignIn);
        _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignIn.m_inputPasswordCanvasSignIn);
    }
    /// <summary>
    /// Function use to Quit Application.
    /// </summary>
    public void ClickOnYesPopUpQuitCanvasManager()
    {
        Application.Quit();
    }
    /// <summary>
    /// Function use to cancel Quit Application.
    /// </summary>
    public void ClickOnNoPopUpQuitCanvasManager()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_goPopUpQuit);

        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignIn.m_inputPseudoCanvasSignIn);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignIn.m_inputPasswordCanvasSignIn);
    }
    #endregion

    #region Canvas Sign In
    /// <summary>
    /// This function will try to connect the player to the Launcher.
    /// </summary>
    public void ClickOnConnectionCanvasSignIn()
    {
        string pseudo = _goManager.m_goCanvasSignIn.m_inputPseudoCanvasSignIn.text;
        string password = _goManager.m_goCanvasSignIn.m_inputPasswordCanvasSignIn.text;
        TextMeshProUGUI infoText = _goManager.m_goCanvasSignIn.m_tmpTxtInfoConnectionCanvasSignIn;
        TMP_InputField inputPseudo = _goManager.m_goCanvasSignIn.m_inputPseudoCanvasSignIn;
        TMP_InputField inputPassword = _goManager.m_goCanvasSignIn.m_inputPasswordCanvasSignIn;

        if(_dbManager.m_dbVerification.IsGoodPassword(pseudo, password, infoText, inputPseudo, inputPassword))
        {
            _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_tmpTitleCanvasManager.gameObject);
            _goManager.DisableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
            _goManager.EnableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLauncher);
            _goManager.EnableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasHome);

            _dbManager.m_actualPseudo = pseudo;
            _dbManager.m_actualEmail = _dbManager.m_dbGet.GetEmail(pseudo);
            _dbManager.m_actualLastName = _dbManager.m_dbGet.GetLastName(pseudo);
            _dbManager.m_actualFirstName= _dbManager.m_dbGet.GetFirstName(pseudo);

            _goManager.m_goCanvasSignIn.ReinitializeAllCanvasSignIn();

            _languageManager.SetProfileCanvasProfile();
            _dbManager.m_dbGet.GetProfileImage(_dbManager.m_actualPseudo);

            StartCoroutine(ChangeFocusCanvasHomeCoroutine(1, _themeManager.GotTimerCanvasHome()));
        }
    }
    /// <summary>
    /// Function use to access to the functionnality "Forgot Password".
    /// </summary>
    public void ClickOnForgotPassword()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_tmpTitleCanvasManager.gameObject);
        _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goCanvasForgotPassword);

        _goManager.ReinitializeForgotPassword();
    }
    /// <summary>
    /// Function use to access to the functionnality "Register".
    /// </summary>
    public void ClickOnNeedAnAccount()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.DisableGameObject(_goManager.m_goCanvasManager.m_tmpTitleCanvasManager.gameObject);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignOn.m_goCanvasSignOn);

        _goManager.ReinitializeRegister();
    }
    #endregion

    #region Canvas Sign On
    /// <summary>
    /// Function use to check if a pseudo and a password exist on the database, if exist, the connection to the launcher is allow, else an error's message is sent.
    /// </summary>
    public void ClickOnPseudoExistCanvasSignOn()
    {
        TMP_InputField inputPseudo = _goManager.m_goCanvasSignOn.m_inputPseudoCanvasSignOn;
        TextMeshProUGUI info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoPseudoCanvasSignOn;
        _dbManager.m_dbVerification.IsFreePseudo(inputPseudo, info);      
    }
    /// <summary>
    /// Function use to change visibilty of the password for the canvas Sign On.
    /// </summary>
    public void ClickOnPasswordVisibilityCanvasSignOn()
    {
        _themeManager.ChangePasswordVisibilityCanvasSignOn();
    }
    /// <summary>
    /// Function use to Register a player. If it's ok, the player will be register.
    /// </summary>
    public void ClickOnRegisterCanvasSignOn()
    {
        TMP_InputField input = _goManager.m_goCanvasSignOn.m_inputPseudoCanvasSignOn;
        TextMeshProUGUI info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoPseudoCanvasSignOn;
        _dbManager.m_dbVerification.IsValidPseudo(input, info);
        string pseudo = input.text;

        input = _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn;
        info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoPasswordCanvasSignOn;
        _dbManager.m_dbVerification.IsValidPassword(input, info);
        string password = input.text;

        input = _goManager.m_goCanvasSignOn.m_inputEmailCanvasSignOn;
        info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoEmailCanvasSignOn;
        _dbManager.m_dbVerification.IsValidEmail(input, info);
        string email = input.text;

        input = _goManager.m_goCanvasSignOn.m_inputFirstNameCanvasSignOn;
        info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoFirstNameCanvasSignOn;
        _dbManager.m_dbVerification.IsValidFirstName(input, info);
        string firstName = input.text;

        input = _goManager.m_goCanvasSignOn.m_inputLastNameCanvasSignOn;
        info = _goManager.m_goCanvasSignOn.m_tmpTxtInfoLastNameCanvasSignOn;
        _dbManager.m_dbVerification.IsValidLastName(input, info);
        string lastName = input.text;

        if (_dbManager.m_dbVerification.IsValidRegister())
        {
            _goManager.EnableGameObject(_goManager.m_goCanvasSignOn.m_goPopUpRegisterCanvasSignOn);
            _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputPseudoCanvasSignOn);
            _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn);
            _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputEmailCanvasSignOn);
            _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputFirstNameCanvasSignOn);
            _goManager.DesactivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputLastNameCanvasSignOn);

            _goManager.m_goCanvasSignOn.ReinitializeRegisterCanvasSignOn();
            _themeManager.ReinitializeVisibilityButtonCanvasForgotPassword();

            _dbManager.m_dbRegister.Register(pseudo, password, email, firstName, lastName);
        }     
    }
    /// <summary>
    /// Function use to back to the Sign In Canvas after a register.
    /// </summary>
    public void ClickOnSignInCanvasSignOn()
    {
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputPseudoCanvasSignOn);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputEmailCanvasSignOn);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputFirstNameCanvasSignOn);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasSignOn.m_inputLastNameCanvasSignOn);

        _goManager.DisableGameObject(_goManager.m_goCanvasSignOn.m_goPopUpRegisterCanvasSignOn);
        _goManager.DisableGameObject(_goManager.m_goCanvasSignOn.m_goCanvasSignOn);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_tmpTitleCanvasManager.gameObject);

    }
    /// <summary>
    /// Function use to back to the Sign In Canvas, cancel a registration.
    /// </summary>
    public void ClickOnBackCanvasSignOn()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasSignOn.m_goCanvasSignOn);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_tmpTitleCanvasManager.gameObject);   
    }
    #endregion

    #region Canvas Forgot Password
    /// <summary>
    /// Function use to send an email to the user with a Verification Code.
    /// </summary>
    public void ClickOnSendEmailCanvasForgotPassword()
    {
        TMP_InputField inputEmail = _goManager.m_goCanvasForgotPassword.m_InputEmailForgotPassword;
        TextMeshProUGUI infoEmail = _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoInputEmailForgotPassword;
        string email = inputEmail.text;

        if(_dbManager.m_dbVerification.DoesEmailExist(inputEmail, infoEmail))
        {
            _dbManager.m_sendEmail.ForgotPassword(email);

            _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpVerification);
            _goManager.ReinitializeForgotPassword();
            _goManager.DesactivateTMPInputField(inputEmail);
        }     
    }
    /// <summary>
    /// Function use to back to Sign In from Forgot Password.
    /// </summary>
    public void ClickOnBackCanvasForgotPassword()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goCanvasForgotPassword);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_tmpTitleCanvasManager.gameObject);
    }
    /// <summary>
    /// Function use to check if an enter code is the good one.
    /// </summary>
    public void ClickOnVerifyPopUpVerificationCanvasForgotPassword()
    {
        string actualVerifyCode = _dbManager.m_sendEmail.m_actualVerifyCode;

        TMP_InputField inputCode = _goManager.m_goCanvasForgotPassword.m_InputCodePopUpVerification;
        TextMeshProUGUI infoCode = _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoInputCodePopUpVerification;
        string enterCode = inputCode.text;

        if(_dbManager.m_dbVerification.VerifyCode(inputCode, infoCode, actualVerifyCode, enterCode))
        {
            _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpVerification);
            _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpChangePassword);

            _goManager.ReinitializeForgotPassword();
        }
    }
    /// <summary>
    /// Function use to back to forgot password from Pop Up verification.
    /// </summary>
    public void ClickOnBackPopUpVerificationCanvasForgotPassword()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpVerification);
        _goManager.m_goCanvasForgotPassword.ReinitializeAllCanvasForgotPassword();
        _themeManager.ReinitializeVisibilityButtonCanvasForgotPassword();
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasForgotPassword.m_InputEmailForgotPassword);
    }
    /// <summary>
    /// Function use to check if a password and his confirm are the same. If it is, change the actual password for the player.
    /// </summary>
    public void ClickOnConfirmPopUpChangePasswordCanvasForgotPassword()
    {
        TMP_InputField inputNewPassword = _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword;
        TMP_InputField inputConfirmPassword = _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword;
        TextMeshProUGUI infoPasswords = _goManager.m_goCanvasForgotPassword.m_tmpTxtInfoPasswordPopUpChangePassword;
        string actualEmailSend = _dbManager.m_sendEmail.m_actualemailSent;

        if (_dbManager.m_dbVerification.VerifyNewPasswordAndConfirmPassword(inputNewPassword, inputConfirmPassword, infoPasswords, actualEmailSend))
        {
            _dbManager.m_dbChangePassword.ChangePassword(actualEmailSend, inputNewPassword.text);

            _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpPasswordChange);
            _goManager.DesactivateTMPInputField(inputNewPassword);
            _goManager.DesactivateTMPInputField(inputConfirmPassword);
            _goManager.m_goCanvasForgotPassword.ReinitializeAllCanvasForgotPassword();
            _themeManager.ReinitializeVisibilityButtonCanvasForgotPassword();
        }
    }
    /// <summary>
    /// Function use to change visibilty of the new password for the Pop Up Change Password from the canvas forgot password.
    /// </summary>
    public void ClickOnNewPasswordVisibilityPopUpChangePasswordCanvasForgotPassword()
    {  
        _themeManager.ChangeNewPasswordVisibilityCanvasForgotPassword();       
    }
    /// <summary>
    /// Function use to change visibilty of the confirm password for the Pop Up Change Password from the canvas forgot password.
    /// </summary>
    public void ClickOnConfirmPasswordVisibilityPopUpChangePasswordCanvasForgotPassword()
    {
        _themeManager.ChangeConfirmPasswordVisibilityCanvasForgotPassword();
    }
    /// <summary>
    /// Function use back to Forgot Password for from Pop Up Change Password.
    /// </summary>
    public void ClickOnCancelPopUpChangePasswordCanvasForgotPassword()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpChangePassword);

        _goManager.m_goCanvasForgotPassword.ReinitializeAllCanvasForgotPassword();
        _themeManager.ReinitializeVisibilityButtonCanvasForgotPassword();
    }
    /// <summary>
    /// Function use back to Sign In from Pop Up Password Change.
    /// </summary>
    public void ClickOnSignPopUpPasswordChangeCanvasForgotPassword()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpPasswordChange);
        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpChangePassword);
        _goManager.DisableGameObject(_goManager.m_goCanvasForgotPassword.m_goCanvasForgotPassword);

        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_tmpTitleCanvasManager.gameObject);

        _goManager.ActivateTMPInputField(_goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword);

        _goManager.m_goCanvasForgotPassword.ReinitializeAllCanvasForgotPassword();
        _themeManager.ReinitializeVisibilityButtonCanvasForgotPassword();
    }
    #endregion

    #region Canvas Launcher
    /// <summary>
    /// Function use change focus to Home for the Canvas Launcher.
    /// </summary>
    public void ClickOnHomeCanvasLauncher()
    {
        _themeManager.ChangeFocusCanvasLauncher("Home");

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLibrairy);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasAboutMe);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasContact);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasProfil);

        _goManager.EnableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasHome);

        _goManager.ReinitializeProfile();
        _themeManager.ReinitializeVisibilityButtonCanvasProfil();

        StartCoroutine(ChangeFocusCanvasHomeCoroutine(1, _themeManager.GotTimerCanvasHome()));
    }
    /// <summary>
    /// Function use change focus to Home for the Canvas Launcher.
    /// </summary>
    public void ClickOnLibrairyCanvasLauncher()
    {
        _themeManager.ChangeFocusCanvasLauncher("Librairy");

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasHome);
        StopAllCoroutines();
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasAboutMe);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasContact);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasProfil);

        _goManager.ReinitializeProfile();
        _themeManager.ReinitializeVisibilityButtonCanvasProfil();

        _goManager.EnableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLibrairy);
    }
    /// <summary>
    /// Function use change focus to Home for the Canvas Launcher.
    /// </summary>
    public void ClickOnAboutMeCanvasLauncher()
    {
        _themeManager.ChangeFocusCanvasLauncher("AboutMe");

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasHome);
        StopAllCoroutines();
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLibrairy);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasContact);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasProfil);

        _goManager.ReinitializeProfile();
        _themeManager.ReinitializeVisibilityButtonCanvasProfil();

        _goManager.EnableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasAboutMe);
    }
    /// <summary>
    /// Function use change focus to Home for the Canvas Launcher.
    /// </summary>
    public void ClickOnContactCanvasLauncher()
    {
        _themeManager.ChangeFocusCanvasLauncher("Contact");

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasHome);
        StopAllCoroutines();
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLibrairy);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasAboutMe);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasProfil);

        _goManager.ReinitializeProfile();
        _themeManager.ReinitializeVisibilityButtonCanvasProfil();

        _goManager.EnableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasContact);
    }
    /// <summary>
    /// Function use change focus to Home for the Canvas Launcher.
    /// </summary>
    public void ClickOnProfilCanvasLauncher()
    {
        _themeManager.ChangeFocusCanvasLauncher("Profil");

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasHome);
        StopAllCoroutines();

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLibrairy);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasAboutMe);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasContact);

        _goManager.ReinitializeProfile();
        _themeManager.ReinitializeVisibilityButtonCanvasProfil();

        _goManager.EnableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasProfil);
    }
    /// <summary>
    /// Function use to open the pop up to disconnect from the Canvas Launcher.
    /// </summary>
    public void ClickOnDeconnectionCanvasLauncher()
    {           
        _goManager.EnableGameObject(_goManager.m_goCanvasLauncher.m_goPopUpDeconnection);
    }
    /// <summary>
    /// Function use to disconnect from the Canvas Launcher.
    /// </summary>
    public void ClickOnYesPopUpDeconnectionCanvasLauncher()
    {
        StopAllCoroutines();

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goPopUpDeconnection);

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasHome);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLibrairy);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasAboutMe);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasContact);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasProfil);

        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLauncher);

        _goManager.ReinitializeProfile();
        _themeManager.ReinitializeVisibilityButtonCanvasProfil();

        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
        _goManager.EnableGameObject(_goManager.m_goCanvasManager.m_tmpTitleCanvasManager.gameObject);
        _goManager.ReinitializeAll();
    }
    /// <summary>
    /// Function use to cancel disconnect from the Canvas Launcher.
    /// </summary>
    public void ClickOnNoPopUpDeconnectionCanvasLauncher()
    {
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goPopUpDeconnection);
    }
    #endregion

    #region Canvas Home
    /// <summary>
    /// Function use change focus to Home for the Canvas Home.
    /// </summary>
    public void ClickOnLeftArrowCanvasHome()
    {
        StopAllCoroutines();
        _themeManager.ChangeFocusCanvasHome(-1);
        StartCoroutine(ChangeFocusCanvasHomeCoroutine(1, _themeManager.GotTimerCanvasHome()));
    }
    /// <summary>
    /// Function use change focus to Home for the Canvas Home.
    /// </summary>
    public void ClickOnRightArrowCanvasHome()
    {
        StopAllCoroutines();
        _themeManager.ChangeFocusCanvasHome(1);
        StartCoroutine(ChangeFocusCanvasHomeCoroutine(1, _themeManager.GotTimerCanvasHome()));
    }
    /// <summary>
    /// Function use change focus to Home for the Canvas Home.
    /// </summary>
    IEnumerator ChangeFocusCanvasHomeCoroutine(int value, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        _themeManager.ChangeFocusCanvasHome(value);
        StartCoroutine(ChangeFocusCanvasHomeCoroutine(1, _themeManager.GotTimerCanvasHome()));
    }
    #endregion

    #region Canvas Librairy
    /// <summary>
    /// Function use download Project 1.
    /// </summary>
    public void ClickOnProject1()
    {
        _dbManager.m_dbUrl.DownloadProjet1();
    }
    /// <summary>
    /// Function use download Project 2.
    /// </summary>
    public void ClickOnProject2()
    {
        _dbManager.m_dbUrl.DownloadProjet2();
    }
    /// <summary>
    /// Function use download Project 3.
    /// </summary>
    public void ClickOnProject3()
    {
        _dbManager.m_dbUrl.DownloadProjet3();
    }
    /// <summary>
    /// Function use download Project 4.
    /// </summary>
    public void ClickOnProject4()
    {
        _dbManager.m_dbUrl.DownloadProjet4();
    }
    /// <summary>
    /// Function use download Project 5.
    /// </summary>
    public void ClickOnProject5()
    {
        _dbManager.m_dbUrl.DownloadProjet5();
    }
    #endregion

    #region Canvas Contact
    /// <summary>
    /// Function use to open Facebook.
    /// </summary>
    public void ClickOnOpenFacebookCanvasContact()
    {
        _dbManager.m_dbUrl.OpenFacebook();  
    }
    /// <summary>
    /// Function use to open Linkedin.
    /// </summary>
    public void ClickOnOpenLinkedinCanvasContact()
    {
        _dbManager.m_dbUrl.OpenLinkedin();
    }
    /// <summary>
    /// Function use to open DoYouBuzz.
    /// </summary>
    public void ClickOnOpenDoYouBuzzCanvasContact()
    {
        _dbManager.m_dbUrl.OpenDoYouBuzz();
    }
    /// <summary>
    /// Function use to open GitHub.
    /// </summary>
    public void ClickOnOpenGitHubCanvasContact()
    {
        _dbManager.m_dbUrl.OpenGitHub();
    }
    /// <summary>
    /// Function use to open Web Site.
    /// </summary>
    public void ClickOnOpenWebSiteCanvasContact()
    {
        _dbManager.m_dbUrl.OpenWebSite();
    }
    #endregion

    #region Canvas Profile
    /// <summary>
    /// Function use to change image profile.
    /// </summary>
    public void ClickOnChangeProfileCanvasProfile()
    {
        _bfManager.OpenBrowserFileCanvasProfile();
    }
    /// <summary>
    /// Function use to change password.
    /// </summary>
    public void ClickOnChangePasswordCanvasProfile()
    {
        TMP_InputField inputNewPassword = _goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile;
        TMP_InputField inputConfirmPassword = _goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile;
        TextMeshProUGUI infoPasswords = _goManager.m_goCanvasProfile.m_tmpTxtInfoPasswordsCanvasProfile;
        string email = _dbManager.m_actualEmail;

        if (_dbManager.m_dbVerification.VerifyNewPasswordAndConfirmPassword(inputNewPassword, inputConfirmPassword, infoPasswords, email))
        {
            _dbManager.m_dbChangePassword.ChangePassword(email, inputNewPassword.text);

            _goManager.EnableGameObject(_goManager.m_goCanvasForgotPassword.m_goPopUpPasswordChange);
            _goManager.DesactivateTMPInputField(inputNewPassword);
            _goManager.DesactivateTMPInputField(inputConfirmPassword);
            _goManager.ReinitializeProfile();
            _themeManager.ReinitializeVisibilityButtonCanvasProfil();

            _goManager.EnableGameObject(_goManager.m_goCanvasProfile.m_goPopUpChangePasswordCanvasProfile);
        }
    }
    /// <summary>
    /// Function use to change visibilty of the new password for the canvas Profile.
    /// </summary>
    public void ClickOnNewPasswordVisibilityCanvasProfile()
    {
        _themeManager.ChangeNewPasswordVisibilityCanvasProfile();
    }
    /// <summary>
    /// Function use to change visibilty of the confirm password for the canvas Profile.
    /// </summary>
    public void ClickOnConfirmPasswordVisibilityCanvasProfile()
    {
        _themeManager.ChangeConfirmPasswordVisibilityCanvasProfile();
    }
    /// <summary>
    /// Function use to back to Profile after a password change.
    /// </summary>
    public void ClickOnOkPopUpChangePasswordCanvasProfile()
    {
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile);
        _goManager.DisableGameObject(_goManager.m_goCanvasProfile.m_goPopUpChangePasswordCanvasProfile);
    }
    /// <summary>
    /// Function use to open the validation Pop up to delete an account.
    /// </summary>
    public void ClickOnDeleteAccountCanvasProfile()
    {
        _goManager.DesactivateTMPInputField(_goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile);
        _goManager.DesactivateTMPInputField(_goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile);
        _goManager.EnableGameObject(_goManager.m_goCanvasProfile.m_goPopUpDeleteAccountCanvasProfile);
    }
    /// <summary>
    /// Function use to delete an account.
    /// </summary>
    public void ClickOnYesDeleteAccountCanvasProfile()
    {
        _dbManager.m_dbDelete.DeleteUser(_dbManager.m_actualPseudo);
        _goManager.ReinitializeAll();
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile);
        _goManager.DisableGameObject(_goManager.m_goCanvasProfile.m_goPopUpDeleteAccountCanvasProfile);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasProfil);
        _goManager.DisableGameObject(_goManager.m_goCanvasLauncher.m_goCanvasLauncher);
        _goManager.EnableGameObject(_goManager.m_goCanvasSignIn.m_goCanvasSignIn);
    }
    /// <summary>
    /// Function use to cancel a delete account.
    /// </summary>
    public void ClickOnCancelDeleteAccountCanvasProfile()
    {
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile);
        _goManager.ActivateTMPInputField(_goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile);
        _goManager.DisableGameObject(_goManager.m_goCanvasProfile.m_goPopUpDeleteAccountCanvasProfile);
    }
    #endregion

    #endregion
}
