using System;

/// <summary>
/// This class contains data(s) for the Theme Medieval Mobile. Herite from Theme.
/// </summary>
[Serializable]
public class ThemeMedievalMobile : Theme
{
    #region System
    public void Awake()
    {
        m_canvasManager.Awake();
        m_canvasSignIn.Awake();
        m_canvasSignOn.Awake();
        m_canvasForgotPassword.Awake();
        m_canvasLauncher.Awake();
        m_canvasHome.Awake();
        m_canvasLibrairy.Awake();
        m_canvasAboutMe.Awake();
        m_canvasContact.Awake();
        m_canvasProfile.Awake();
    }
    #endregion
}
