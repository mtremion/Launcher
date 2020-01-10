using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Launcher.
/// </summary>
[Serializable]
public class ThemeCanvasLauncher
{
    #region Static
    public static string ACTUAL_FOCUS = "Home";
    #endregion

    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Background")]
    [Tooltip("Sprite of the background.")]
    [SerializeField] Sprite imgBackgroundCanvasLauncher;
    [Tooltip("Position of the background.")]
    [SerializeField] RectTransform transformBackgroundCanvasLauncher;
    [Header("Button Home")]
    [Tooltip("Position of the button Home.")]
    [SerializeField] RectTransform transformBtnHomeCanvasLauncher;
    [Tooltip("Color focus of the text of the button Home.")]
    [SerializeField] Color colorFocusTxtBtnHomeCanvasLauncher;
    [Tooltip("Color not focus of the text of the button Home.")]
    [SerializeField] Color colorNotFocusTxtBtnHomeCanvasLauncher;
    [Header("Button Librairy")]
    [Tooltip("Position of the button Librairy.")]
    [SerializeField] RectTransform transformBtnLibrairyCanvasLauncher;
    [Tooltip("Color focus of the text of the button Librairy.")]
    [SerializeField] Color colorFocusTxtBtnLibrairyCanvasLauncher;
    [Tooltip("Color not focus of the text of the button Librairy.")]
    [SerializeField] Color colorNotFocusTxtBtnLibrairyCanvasLauncher;
    [Header("Button About Me")]
    [Tooltip("Position of the button About Me.")]
    [SerializeField] RectTransform transformBtnAboutMeCanvasLauncher;
    [Tooltip("Color focus of the text of the button About Me.")]
    [SerializeField] Color colorFocusTxtBtnAboutMeCanvasLauncher;
    [Tooltip("Color not focus of the text of the button About Me.")]
    [SerializeField] Color colorNotFocusTxtBtnAboutMeCanvasLauncher;
    [Header("Button Contact")]
    [Tooltip("Position of the button Contact.")]
    [SerializeField] RectTransform transformBtnContactCanvasLauncher;
    [Tooltip("Color focus of the text of the button Contact.")]
    [SerializeField] Color colorFocusTxtBtnContactCanvasLauncher;
    [Tooltip("Color not focus of the text of the button Contact.")]
    [SerializeField] Color colorNotFocusTxtBtnContactCanvasLauncher;
    [Header("Button Profil")]
    [Tooltip("Position of the button Home.")]
    [SerializeField] RectTransform transformBtnProfilCanvasLauncher;
    [Tooltip("Color focus of the text of the button Home.")]
    [SerializeField] Color colorFocusTxtBtnProfilCanvasLauncher;
    [Tooltip("Color not focus of the text of the button Home.")]
    [SerializeField] Color colorNotFocusTxtBtnProfilCanvasLauncher;
    [Header("Button Deconnection")]
    [Tooltip("Position of the button Deconnection.")]
    [SerializeField] RectTransform transformBtnDeconnectionCanvasLauncher;
    [Tooltip("Sprite of the button Deconnection.")]
    [SerializeField] Sprite imgBtnDeconnectionCanvasLauncher;
    [Header("PopUp Deconnection")]
    [Tooltip("Position of the background PopUp Deconnection.")]
    [SerializeField] RectTransform transformImgBackPopUpDeconnectionCanvasLauncher;
    [Tooltip("Sprite of the background PopUp Deconnection.")]
    [SerializeField] Sprite imgBackPopUpDeconnectionCanvasLauncher;
    [Tooltip("Position of the text PopUp Deconnection.")]
    [SerializeField] RectTransform transformTxtPopUpDeconnectionCanvasLauncher;
    [Tooltip("Color of the text PopUp Deconnection.")]
    [SerializeField] Color colorTxtPopUpDeconnectionCanvasLauncher;
    [Header("Button Yes PopUp Deconnection")]
    [Tooltip("Position of the button Yes PopUp Deconnection.")]
    [SerializeField] RectTransform transformBtnYesPopUpDeconnectionCanvasLauncher;
    [Tooltip("Sprite of the button Yes PopUp Deconnection.")]
    [SerializeField] Sprite imgBtnYesPopUpDeconnectionCanvasLauncher;
    [Tooltip("Color of the text button Yes PopUp Deconnection.")]
    [SerializeField] Color colorTxtBtnYesPopUpDeconnectionCanvasLauncher;
    [Header("Button No PopUp Deconnection")]
    [Tooltip("Position of the button No PopUp Deconnection.")]
    [SerializeField] RectTransform transformBtnNoPopUpDeconnectionCanvasLauncher;
    [Tooltip("Sprite of the button No PopUp Deconnection.")]
    [SerializeField] Sprite imgBtnNoPopUpDeconnectionCanvasLauncher;
    [Tooltip("Color of the text button No PopUp Deconnection.")]
    [SerializeField] Color colorTxtBtnNoPopUpDeconnectionCanvasLauncher;
    #endregion

    #region Private
    GameObjectManager _goManager = null;
    #endregion

    #region System
    public void Awake()
    {
        _goManager = GameObject.Find("GameObjectManager").GetComponent<GameObjectManager>();

        ACTUAL_FOCUS = "Home";
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// Function use to change the theme on the Launcher.
    /// </summary>
    public void ChangeThemeCanvasLauncher()
    {
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBackgroundCanvasLauncher, transformBackgroundCanvasLauncher);
        _goManager.m_goCanvasLauncher.m_imgBackgroundCanvasLauncher.sprite = imgBackgroundCanvasLauncher;

        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBtnHomeCanvasLauncher, transformBtnHomeCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBtnLibrairyCanvasLauncher, transformBtnLibrairyCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBtnAboutMeCanvasLauncher, transformBtnAboutMeCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBtnContactCanvasLauncher, transformBtnContactCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBtnProfilCanvasLauncher, transformBtnProfilCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBtnDeconnectionCanvasLauncher, transformBtnDeconnectionCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformImgBackPopUpDeconnectionCanvasLauncher, transformImgBackPopUpDeconnectionCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformTxtPopUpDeconnectionCanvasLauncher, transformTxtPopUpDeconnectionCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBtnYesPopUpDeconnectionCanvasLauncher, transformBtnYesPopUpDeconnectionCanvasLauncher);
        ChangeRectTransform(_goManager.m_goCanvasLauncher.m_transformBtnNoPopUpDeconnectionCanvasLauncher, transformBtnNoPopUpDeconnectionCanvasLauncher);

        _goManager.m_goCanvasLauncher.m_imgBtnDeconnectionCanvasLauncher.sprite = imgBtnDeconnectionCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_imgImgBackPopUpDeconnectionCanvasLauncher.sprite = imgBackPopUpDeconnectionCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_imgBtnYesPopUpDeconnectionCanvasLauncher.sprite = imgBtnYesPopUpDeconnectionCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_imgBtnNoPopUpDeconnectionCanvasLauncher.sprite = imgBtnNoPopUpDeconnectionCanvasLauncher;

        _goManager.m_goCanvasLauncher.m_tmpTxtPopUpDeconnectionCanvasLauncher.font = font;
        _goManager.m_goCanvasLauncher.m_tmpTxtPopUpDeconnectionCanvasLauncher.color = colorTxtPopUpDeconnectionCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnYesPopUpDeconnectionCanvasLauncher.font = font;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnYesPopUpDeconnectionCanvasLauncher.color = colorTxtBtnYesPopUpDeconnectionCanvasLauncher;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnNoPopUpDeconnectionCanvasLauncher.font = font;
        _goManager.m_goCanvasLauncher.m_tmpTxtBtnNoPopUpDeconnectionCanvasLauncher.color = colorTxtBtnNoPopUpDeconnectionCanvasLauncher;

        ChangeFocus(ACTUAL_FOCUS);
    }
    /// <summary>
    /// Function use to change the position of data(s) on the Canvas Launcher.
    /// </summary>
    public void ChangeRectTransform(RectTransform from, RectTransform to)
    {
        from.SetPositionAndRotation(to.position, to.rotation);
        from.sizeDelta = new Vector2(to.sizeDelta.x, to.sizeDelta.y);
        from.anchorMax = to.anchorMax;
        from.anchorMin = to.anchorMin;
        from.pivot = to.pivot;
        from.localScale = new Vector3(to.localScale.x, to.localScale.y, to.localScale.z);
    }
    /// <summary>
    /// Function use to change the button focused with the right color.
    /// </summary>
    public void ChangeFocus(string focus)
    {
        ACTUAL_FOCUS = focus;

        switch(focus)
        {
            case "Home":
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnHomeCanvasLauncher.color = colorFocusTxtBtnHomeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnLibrairyCanvasLauncher.color = colorNotFocusTxtBtnLibrairyCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnAboutMeCanvasLauncher.color = colorNotFocusTxtBtnAboutMeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnContactCanvasLauncher.color = colorNotFocusTxtBtnContactCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnProfilCanvasLauncher.color = colorNotFocusTxtBtnProfilCanvasLauncher;               
                break;
            case "Librairy":
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnHomeCanvasLauncher.color = colorNotFocusTxtBtnHomeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnLibrairyCanvasLauncher.color = colorFocusTxtBtnLibrairyCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnAboutMeCanvasLauncher.color = colorNotFocusTxtBtnAboutMeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnContactCanvasLauncher.color = colorNotFocusTxtBtnContactCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnProfilCanvasLauncher.color = colorNotFocusTxtBtnProfilCanvasLauncher;
                break;
            case "AboutMe":
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnHomeCanvasLauncher.color = colorNotFocusTxtBtnHomeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnLibrairyCanvasLauncher.color = colorNotFocusTxtBtnLibrairyCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnAboutMeCanvasLauncher.color = colorFocusTxtBtnAboutMeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnContactCanvasLauncher.color = colorNotFocusTxtBtnContactCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnProfilCanvasLauncher.color = colorNotFocusTxtBtnProfilCanvasLauncher;
                break;
            case "Contact":
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnHomeCanvasLauncher.color = colorNotFocusTxtBtnHomeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnLibrairyCanvasLauncher.color = colorNotFocusTxtBtnLibrairyCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnAboutMeCanvasLauncher.color = colorNotFocusTxtBtnAboutMeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnContactCanvasLauncher.color = colorFocusTxtBtnContactCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnProfilCanvasLauncher.color = colorNotFocusTxtBtnProfilCanvasLauncher;
                break;
            case "Profil":
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnHomeCanvasLauncher.color = colorNotFocusTxtBtnHomeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnLibrairyCanvasLauncher.color = colorNotFocusTxtBtnLibrairyCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnAboutMeCanvasLauncher.color = colorNotFocusTxtBtnAboutMeCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnContactCanvasLauncher.color = colorNotFocusTxtBtnContactCanvasLauncher;
                _goManager.m_goCanvasLauncher.m_tmpTxtBtnProfilCanvasLauncher.color = colorFocusTxtBtnProfilCanvasLauncher;
                break;
            default:
                break;
        }
    }
    #endregion
}
