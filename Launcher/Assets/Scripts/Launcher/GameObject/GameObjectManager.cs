using UnityEngine;
using TMPro;
using UnityEngine.UI;

/// <summary>
/// This class contains data(s) to lead GameObject of the Launcher.
/// </summary>
public class GameObjectManager : MonoBehaviour
{
    #region SerializeField
    [Header("Canvas Manager")]
    [Tooltip("Canvas Manager.")]
    [SerializeField] GameObjectCanvasManager goCanvasManager = new GameObjectCanvasManager();
    [Tooltip("Canvas Sign In.")]
    [SerializeField] GameObjectCanvasSignIn goCanvasSignIn = new GameObjectCanvasSignIn ();
    [Tooltip("Canvas Sign On.")]
    [SerializeField] GameObjectCanvasSignOn goCanvasSignOn = new GameObjectCanvasSignOn();
    [Tooltip("Canvas Forgot Password.")]
    [SerializeField] GameObjectCanvasForgotPassword goCanvasForgotPassword = new GameObjectCanvasForgotPassword();
    [Tooltip("Canvas Launcher.")]
    [SerializeField] GameObjectCanvasLauncher goCanvasLauncher = new GameObjectCanvasLauncher();
    [Tooltip("Canvas Home.")]
    [SerializeField] GameObjectCanvasHome goCanvasHome = new GameObjectCanvasHome();
    [Tooltip("Canvas Librairy.")]
    [SerializeField] GameObjectCanvasLibrairy goCanvasLibrairy = new GameObjectCanvasLibrairy();
    [Tooltip("Canvas About Me.")]
    [SerializeField] GameObjectCanvasAboutMe goCanvasAboutMe = new GameObjectCanvasAboutMe();
    [Tooltip("Canvas Contact.")]
    [SerializeField] GameObjectCanvasContact goCanvasContact = new GameObjectCanvasContact();
    [Tooltip("Canvas Profile.")]
    [SerializeField] GameObjectCanvasProfile goCanvasProfile = new GameObjectCanvasProfile();
    #endregion

    #region Getters & Setters
    public GameObjectCanvasManager m_goCanvasManager { get { return goCanvasManager; } }
    public GameObjectCanvasSignIn m_goCanvasSignIn { get { return goCanvasSignIn; } }
    public GameObjectCanvasSignOn m_goCanvasSignOn { get { return goCanvasSignOn; } }
    public GameObjectCanvasForgotPassword m_goCanvasForgotPassword { get { return goCanvasForgotPassword; } }
    public GameObjectCanvasLauncher m_goCanvasLauncher { get { return goCanvasLauncher; } }
    public GameObjectCanvasHome m_goCanvasHome { get { return goCanvasHome; } }
    public GameObjectCanvasLibrairy m_goCanvasLibrairy { get { return goCanvasLibrairy; } }
    public GameObjectCanvasAboutMe m_goCanvasAboutMe { get { return goCanvasAboutMe; } }
    public GameObjectCanvasContact m_goCanvasContact { get { return goCanvasContact; } }
    public GameObjectCanvasProfile m_goCanvasProfile { get { return goCanvasProfile; } }
    #endregion

    #region System
    private void Awake()
    {
        goCanvasManager.Awake();
        goCanvasSignIn.Awake();
        goCanvasSignOn.Awake();
        goCanvasForgotPassword.Awake();
        goCanvasLauncher.Awake();
        goCanvasHome.Awake();
        goCanvasLibrairy.Awake();
        goCanvasAboutMe.Awake();
        goCanvasContact.Awake();
        goCanvasProfile.Awake();

        goCanvasManager.m_goCanvasManager.SetActive(true);
        goCanvasSignIn.m_goCanvasSignIn.SetActive(true);
        goCanvasSignOn.m_goCanvasSignOn.SetActive(false);
        goCanvasSignOn.m_goPopUpRegisterCanvasSignOn.SetActive(false);
        goCanvasForgotPassword.m_goCanvasForgotPassword.SetActive(false);
        goCanvasForgotPassword.m_goPopUpVerification.SetActive(false);
        goCanvasForgotPassword.m_goPopUpChangePassword.SetActive(false);
        goCanvasForgotPassword.m_goPopUpPasswordChange.SetActive(false);
        goCanvasLauncher.m_goCanvasLauncher.SetActive(false);
        goCanvasLauncher.m_goCanvasHome.SetActive(false);
        goCanvasLauncher.m_goCanvasLibrairy.SetActive(false);
        goCanvasLauncher.m_goCanvasAboutMe.SetActive(false);
        goCanvasLauncher.m_goCanvasContact.SetActive(false);
        goCanvasLauncher.m_goCanvasProfil.SetActive(false);
    }
    #endregion

    #region Main Methods
    public void ReinitializeAll()
    {
        goCanvasManager.ReinitializeAllCanvasManager();
        goCanvasSignIn.ReinitializeAllCanvasSignIn();
        goCanvasSignOn.ReinitializeRegisterCanvasSignOn();
        goCanvasForgotPassword.ReinitializeAllCanvasForgotPassword();
        goCanvasProfile.ReinitializeAllProfile();
    }
    public void DisableGameObject(GameObject go)
    {
        go.SetActive(false);
    }
    public void EnableGameObject(GameObject go)
    {
        go.SetActive(true);
    }
    public void DesactivateTMPInputField(TMP_InputField tmpInputField)
    {
        tmpInputField.interactable = false;
    }
    public void ActivateTMPInputField(TMP_InputField tmpInputField)
    {
        tmpInputField.interactable = true;
    }
    public void DesactivateButton(Button button)
    {
        button.interactable = false;
    }
    public void ActivateButton(Button button)
    {
        button.interactable = true;
    }
    public void ReinitializeRegister()
    {
        goCanvasSignOn.ReinitializeRegisterCanvasSignOn();
    }
    public void ReinitializeForgotPassword()
    {
        goCanvasForgotPassword.ReinitializeAllCanvasForgotPassword();
    }
    public void ReinitializeProfile()
    {
        goCanvasProfile.ReinitializeAllProfile();
    }
    #endregion
}
