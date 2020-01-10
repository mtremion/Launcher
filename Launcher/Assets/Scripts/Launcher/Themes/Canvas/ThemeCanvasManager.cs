using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Sign In.
/// </summary>
[Serializable]
public class ThemeCanvasManager
{
    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Background")]
    [Tooltip("Sprite of the background.")]
    [SerializeField] Sprite imgBackgroundCanvasManager;
    [Tooltip("Position of the background.")]
    [SerializeField] RectTransform transformBackgroundCanvasManager;
    [Header("Title")]
    [Tooltip("Position of the title of the canvas manager.")]
    [SerializeField] RectTransform transformTitleCanvasManager;
    [Tooltip("Color of the title of the canvas manager.")]
    [SerializeField] Color colorTitleCanvasManager;
    [Header("Music")]
    [Tooltip("Audio clip of the theme.")]
    [SerializeField] AudioClip audioClipCanvasManager;
    [Tooltip("RectTransform toggle mute.")]
    [SerializeField] RectTransform transformToggleMuteCanvasManager;
    [Tooltip("Sprite of the background toggle mute.")]
    [SerializeField] Sprite imgBackgroundToggleMuteCanvasManager;
    [Tooltip("Sprite of the checkmark toggle mute.")]
    [SerializeField] Sprite imgCheckMarkToggleMuteCanvasManager;
    [Tooltip("Color text mesh pro toggle mute.")]
    [SerializeField] Color colorTmpToggleMuteCanvasManager;
    [Header("Themes")]
    [Tooltip("RectTransform of the dropdown themes.")]
    [SerializeField] RectTransform transformDropDownThemesCanvasManager;
    [Tooltip("Sprite of the dropdown themes.")]
    [SerializeField] Sprite imgDropDownThemesCanvasManager;
    [Tooltip("Color of the label of the dropdown themes.")]
    [SerializeField] Color colorLabelDropDownThemesCanvasManager;
    [Tooltip("Sprite of the Arrow of the dropdown themes.")]
    [SerializeField] Sprite imgArrowDropDownThemesCanvasManager;
    [Tooltip("Color of the arrow of the dropdown themes.")]
    [SerializeField] Color colorArrowDropDownThemesCanvasManager;
    [Tooltip("Sprite Template viewport background dropdown themes.")]
    [SerializeField] Sprite imgTemplateBackgroundDropDownThemesCanvasManager;
    [Tooltip("Sprite Template viewport checkmark dropdown themes.")]
    [SerializeField] Sprite imgTemplateCheckMarkDropDownThemesCanvasManager;
    [Tooltip("Color Template viewport label dropdown themes.")]
    [SerializeField] Color colorTemplateLabelDropDownThemesCanvasManager;
    [Header("Languages")]
    [Tooltip("RectTransform of the dropdown languages.")]
    [SerializeField] RectTransform transformDropDownLanguagesCanvasManager;
    [Tooltip("Sprite of the dropdown languages.")]
    [SerializeField] Sprite imgDropDownLanguagesCanvasManager;
    [Tooltip("Color of the label of the dropdown languages.")]
    [SerializeField] Color colorLabelDropDownLanguagesCanvasManager;
    [Tooltip("Sprite of the Arrow of the dropdown languages.")]
    [SerializeField] Sprite imgArrowDropDownLanguagesCanvasManager;
    [Tooltip("Color of the arrow of the dropdown languages.")]
    [SerializeField] Color colorArrowDropDownLanguagesCanvasManager;
    [Tooltip("Sprite Template viewport background dropdown languages.")]
    [SerializeField] Sprite imgTemplateBackgroundDropDownLanguagesCanvasManager;
    [Tooltip("Sprite Template viewport checkmark dropdown languages.")]
    [SerializeField] Sprite imgTemplateCheckMarkDropDownLanguagesCanvasManager;
    [Tooltip("Color Template viewport label dropdown languages.")]
    [SerializeField] Color colorTemplateLabelDropDownLanguagesCanvasManager;
    [Header("Button Credit")]
    [Tooltip("Position of the button Credit.")]
    [SerializeField] RectTransform transformBtnCreditCanvasManager;
    [Tooltip("Sprite of the button Credit.")]
    [SerializeField] Sprite imgBtnCreditCanvasManager;
    [Tooltip("Color text of the button Credit.")]
    [SerializeField] Color colorTxtBtnCreditCanvasManager;
    [Header("PopUp Credit / Scroll view")]
    [Tooltip("Position of back Pop Up Credit.")]
    [SerializeField] RectTransform transformImgBackPopUpCreditCanvasManager;
    [Tooltip("Sprite of back Pop Up Credit.")]
    [SerializeField] Sprite imgImgBackPopUpCreditCanvasManager;
    [Tooltip("Position of the Scroll view Credit.")]
    [SerializeField] RectTransform transformSVPopUpCreditCanvasManager;
    [Header("PopUp Credit/ Text Credit")]
    [SerializeField] Color colorTxtPopUpCreditCanvasManager;
    [Header("PopUp Credit / Scrollbar")]
    [Tooltip("Sprite of the background scrollbar vertical Pop Up Credit.")]
    [SerializeField] Sprite imgBackSBVPopUpCreditCanvasManager;
    [Tooltip("Sprite of the handle scrollbar Pop Up Credit.")]
    [SerializeField] Sprite imgHandleSBVPopUpCreditCanvasManager;
    [Header("PopUp Credit/ Button Close")]
    [Tooltip("Position of the button Close.")]
    [SerializeField] RectTransform transformBtnClosePopUpCreditCanvasManager;
    [Tooltip("Sprite of the button Close.")]
    [SerializeField] Sprite imgBtnClosePopUpCreditCanvasManager;
    [Tooltip("Color text of the button Close.")]
    [SerializeField] Color colorTxtBtnClosePopUpCreditCanvasManager;
    [Header("Button Quit")]
    [Tooltip("Position of the button Quit.")]
    [SerializeField] RectTransform transformBtnQuitCanvasManager;
    [Tooltip("Sprite of the button Quit.")]
    [SerializeField] Sprite imgBtnQuitCanvasManager;
    [Tooltip("Color text of the button Quit.")]
    [SerializeField] Color colorTxtBtnQuitCanvasManager;
    [Header("PopUp Quit")]
    [Tooltip("Position of the background PopUp Quit.")]
    [SerializeField] RectTransform transformImgBackPopUpQuitCanvasManager;
    [Tooltip("Sprite of the background PopUp Quit.")]
    [SerializeField] Sprite imgBackPopUpQuitCanvasManager;
    [Tooltip("Position of the text PopUp Quit.")]
    [SerializeField] RectTransform transformTxtPopUpQuitCanvasManager;
    [Tooltip("Color of the text PopUp Quit.")]
    [SerializeField] Color colorTxtPopUpQuitCanvasManager;
    [Header("Button Yes PopUp Quit")]
    [Tooltip("Position of the button Yes PopUp Quit.")]
    [SerializeField] RectTransform transformBtnYesPopUpQuitCanvasManager;
    [Tooltip("Sprite of the button Yes PopUp Quit.")]
    [SerializeField] Sprite imgBtnYesPopUpQuitCanvasManager;
    [Tooltip("Color of the text button Yes PopUp Quit.")]
    [SerializeField] Color colorTxtBtnYesPopUpQuitCanvasManager;
    [Header("Button No PopUp Quit")]
    [Tooltip("Position of the button No PopUp Quit.")]
    [SerializeField] RectTransform transformBtnNoPopUpQuitCanvasManager;
    [Tooltip("Sprite of the button No PopUp Quit.")]
    [SerializeField] Sprite imgBtnNoPopUpQuitCanvasManager;
    [Tooltip("Color of the text button No PopUp Quit.")]
    [SerializeField] Color colorTxtBtnNoPopUpQuitCanvasManager;
    #endregion

    #region Getters & Setters
    public AudioClip m_audioClipCanvasManager { get { return audioClipCanvasManager; } }
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
    /// Function use to change the theme on the Canvas Manager.
    /// </summary>
    public void ChangeThemeCanvasManager()
    {
        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformBackgroundCanvasManager, transformBackgroundCanvasManager);
        _goManager.m_goCanvasManager.m_imgBackgroundCanvasManager.sprite = imgBackgroundCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformTitleCanvasManager, transformTitleCanvasManager);
        _goManager.m_goCanvasManager.m_tmpTitleCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpTitleCanvasManager.color = colorTitleCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformToggleMuteCanvasManager, transformToggleMuteCanvasManager);
        _goManager.m_goCanvasManager.m_imgBackgroundToggleMuteCanvasManager.sprite = imgBackgroundToggleMuteCanvasManager;
        _goManager.m_goCanvasManager.m_imgCheckMarkToggleMuteCanvasManager.sprite = imgCheckMarkToggleMuteCanvasManager;
        _goManager.m_goCanvasManager.m_tmpLabelToggleMuteCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpLabelToggleMuteCanvasManager.color = colorTmpToggleMuteCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformDropDownThemeCanvasManager, transformDropDownThemesCanvasManager);
        _goManager.m_goCanvasManager.m_imgDropDownThemeCanvasManager.sprite = imgDropDownThemesCanvasManager;
        _goManager.m_goCanvasManager.m_tmpLabelDropDownThemeCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpLabelDropDownThemeCanvasManager.color = colorLabelDropDownThemesCanvasManager;
        _goManager.m_goCanvasManager.m_imgArrowDropDownThemeCanvasManager.sprite = imgArrowDropDownThemesCanvasManager;
        _goManager.m_goCanvasManager.m_imgArrowDropDownThemeCanvasManager.color = colorArrowDropDownThemesCanvasManager;
        _goManager.m_goCanvasManager.m_imgBackgroundTemplateDropDownThemeCanvasManager.sprite = imgTemplateBackgroundDropDownThemesCanvasManager;
        _goManager.m_goCanvasManager.m_imgCheckMarkTemplateDropDownThemeCanvasManager.sprite = imgTemplateCheckMarkDropDownThemesCanvasManager;
        _goManager.m_goCanvasManager.m_tmpLabelTemplateDropDownThemeCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpLabelTemplateDropDownThemeCanvasManager.color = colorTemplateLabelDropDownThemesCanvasManager;

        _goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.SetValueWithoutNotify(_goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value);

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformDropDownLanguageCanvasManager, transformDropDownLanguagesCanvasManager);
        _goManager.m_goCanvasManager.m_imgDropDownLanguageCanvasManager.sprite = imgDropDownLanguagesCanvasManager;
        _goManager.m_goCanvasManager.m_tmpLabelDropDownLanguageCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpLabelDropDownLanguageCanvasManager.color = colorLabelDropDownLanguagesCanvasManager;
        _goManager.m_goCanvasManager.m_imgArrowDropDownLanguageCanvasManager.sprite = imgArrowDropDownLanguagesCanvasManager;
        _goManager.m_goCanvasManager.m_imgArrowDropDownLanguageCanvasManager.color = colorArrowDropDownLanguagesCanvasManager;
        _goManager.m_goCanvasManager.m_imgBackgroundTemplateDropDownLanguageCanvasManager.sprite = imgTemplateBackgroundDropDownLanguagesCanvasManager;
        _goManager.m_goCanvasManager.m_imgCheckMarkTemplateDropDownLanguageCanvasManager.sprite = imgTemplateCheckMarkDropDownLanguagesCanvasManager;
        _goManager.m_goCanvasManager.m_tmpLabelTemplateDropDownLanguageCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpLabelTemplateDropDownLanguageCanvasManager.color = colorTemplateLabelDropDownLanguagesCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformBtnCreditCanvasManager, transformBtnCreditCanvasManager);
        _goManager.m_goCanvasManager.m_imgBtnCreditCanvasManager.sprite = imgBtnCreditCanvasManager;
        _goManager.m_goCanvasManager.m_tmpTxtBtnCreditCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpTxtBtnCreditCanvasManager.color = colorTxtBtnCreditCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformBackImgPopUpCreditCanvasManager, transformImgBackPopUpCreditCanvasManager);
        _goManager.m_goCanvasManager.m_imgBackPopUpCreditCanvasManager.sprite = imgImgBackPopUpCreditCanvasManager;
        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformSVPopUpCreditCanvasManager, transformSVPopUpCreditCanvasManager);
        _goManager.m_goCanvasManager.m_imgSBVPopUpCreditCanvasManager.sprite = imgBackSBVPopUpCreditCanvasManager;
        _goManager.m_goCanvasManager.m_imgHandleSBVPopUpCreditCanvasManager.sprite = imgHandleSBVPopUpCreditCanvasManager;

        for (int i = 0; i < _goManager.m_goCanvasManager.m_tmpTabTxtCreditsPopUpCreditCanvasManager.Length; i++)
        {
            _goManager.m_goCanvasManager.m_tmpTabTxtCreditsPopUpCreditCanvasManager[i].font = font;
            _goManager.m_goCanvasManager.m_tmpTabTxtCreditsPopUpCreditCanvasManager[i].color = colorTxtPopUpCreditCanvasManager;
        }

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformBtnClosePopUpCreditCanvasManager, transformBtnClosePopUpCreditCanvasManager);
        _goManager.m_goCanvasManager.m_imgBtnClosePopUpCreditCanvasManager.sprite = imgBtnClosePopUpCreditCanvasManager;
        _goManager.m_goCanvasManager.m_tmpTxtBtnClosePopUpCreditCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpTxtBtnClosePopUpCreditCanvasManager.color = colorTxtBtnClosePopUpCreditCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformBtnQuitCanvasManager, transformBtnQuitCanvasManager);
        _goManager.m_goCanvasManager.m_imgBtnQuitCanvasManager.sprite = imgBtnQuitCanvasManager;
        _goManager.m_goCanvasManager.m_tmpTxtBtnQuitCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpTxtBtnQuitCanvasManager.color = colorTxtBtnQuitCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformBackImgPopUpQuitCanvasManager, transformImgBackPopUpQuitCanvasManager);
        _goManager.m_goCanvasManager.m_imgBackImgPopUpQuitCanvasManager.sprite = imgBackPopUpQuitCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformTxtPopUpQuitCanvasManager, transformTxtPopUpQuitCanvasManager);
        _goManager.m_goCanvasManager.m_tmpTxtPopUpQuitCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpTxtPopUpQuitCanvasManager.color = colorTxtPopUpQuitCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformBtnYesPopUpQuitCanvasManager, transformBtnYesPopUpQuitCanvasManager);
        _goManager.m_goCanvasManager.m_imgBtnYesPopUpQuitCanvasManager.sprite = imgBtnYesPopUpQuitCanvasManager;
        _goManager.m_goCanvasManager.m_tmpTxtBtnYesPopUpQuitCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpTxtBtnYesPopUpQuitCanvasManager.color = colorTxtBtnYesPopUpQuitCanvasManager;

        ChangeRectTransform(_goManager.m_goCanvasManager.m_transformBtnNoPopUpQuitCanvasManager, transformBtnNoPopUpQuitCanvasManager);
        _goManager.m_goCanvasManager.m_imgBtnNoPopUpQuitCanvasManager.sprite = imgBtnNoPopUpQuitCanvasManager;
        _goManager.m_goCanvasManager.m_tmpTxtBtnNoPopUpQuitCanvasManager.font = font;
        _goManager.m_goCanvasManager.m_tmpTxtBtnNoPopUpQuitCanvasManager.color = colorTxtBtnNoPopUpQuitCanvasManager;
    }

    /// <summary>
    /// Function use to change the position of data(s) on the Canvas Manager.
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
    #endregion
}
