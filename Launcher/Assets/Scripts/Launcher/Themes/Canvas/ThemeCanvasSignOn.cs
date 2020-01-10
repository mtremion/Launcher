using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Sign On.
/// </summary>
[Serializable]
public class ThemeCanvasSignOn
{
    #region Static
    static bool PASSWORD_VISIBLE = false;
    #endregion

    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Background")]
    [Tooltip("Sprite of the background.")]
    [SerializeField] Sprite imgBackgroundCanvasSignOn;
    [Tooltip("Position of the background.")]
    [SerializeField] RectTransform transformBackgroundCanvasSignOn;
    [Header("Title")]
    [Tooltip("Position of the title of the canvas sign on.")]
    [SerializeField] RectTransform transformTitleCanvasSignOn;
    [Tooltip("Color of the title of the canvas sign on.")]
    [SerializeField] Color colorTitleCanvasSignOn;
    [Header("Pseudo")]
    [Tooltip("Position of the input pseudo.")]
    [SerializeField] RectTransform transformInputPseudoCanvasSignOn;
    [Tooltip("Sprite of the input pseudo.")]
    [SerializeField] Sprite imgInputPseudoCanvasSignOn;
    [Tooltip("Color of the placeholder of the input pseudo.")]
    [SerializeField] Color colorTxtPHInputPseudoCanvasSignOn;
    [Tooltip("Color of the txt of the input pseudo.")]
    [SerializeField] Color colorTxtInputPseudoCanvasSignOn;
    [Header("Button Pseudo Exist")]
    [Tooltip("Position of the button pseudo exist.")]
    [SerializeField] RectTransform transformBtnPseudoExistCanvasSignOn;
    [Tooltip("Sprite of the button pseudo exist.")]
    [SerializeField] Sprite imgBtnPseudoExistCanvasSignOn;
    [Header("Info Pseudo")]
    [Tooltip("Position of the info pseudo.")]
    [SerializeField] RectTransform transformTxtInfoPseudoCanvasSignOn;
    [Header("Password")]
    [Tooltip("Position of the input password.")]
    [SerializeField] RectTransform transformInputPasswordCanvasSignOn;
    [Tooltip("Sprite of the input password.")]
    [SerializeField] Sprite imgInputPasswordCanvasSignOn;
    [Tooltip("Color of the text of the placeholder of the input password.")]
    [SerializeField] Color colorTxtPHInputPasswordCanvasSignOn;
    [Tooltip("Color of the text of the input pseudo.")]
    [SerializeField] Color colorTxtInputPasswordCanvasSignOn;
    [Header("Button Password Visible")]
    [Tooltip("Position of the Button Password Visible.")]
    [SerializeField] RectTransform transformBtnPasswordVisibleCanvasSignOn;
    [Tooltip("Sprite visible of the Button Password Visible.")]
    [SerializeField] Sprite imgBtnPasswordIsVisibleCanvasSignOn;
    [Tooltip("Sprite not visible of the Button Password Visible.")]
    [SerializeField] Sprite imgBtnPasswordIsNotVisibleCanvasSignOn;
    [Header("Info Password")]
    [Tooltip("Position of the info password.")]
    [SerializeField] RectTransform transformTxtInfoPasswordCanvasSignOn;
    [Header("Email")]
    [Tooltip("Position of the input email.")]
    [SerializeField] RectTransform transformInputEmailCanvasSignOn;
    [Tooltip("Sprite of the input email.")]
    [SerializeField] Sprite imgInputEmailCanvasSignOn;
    [Tooltip("Color of the text of the placeholder of the input email.")]
    [SerializeField] Color colorTxtPHInputEmailCanvasSignOn;
    [Tooltip("Color of the text of the input email.")]
    [SerializeField] Color colorTxtInputEmailCanvasSignOn;
    [Header("Info Email")]
    [Tooltip("Position of the info Email.")]
    [SerializeField] RectTransform transformTxtInfoEmailCanvasSignOn;
    [Header("First Name")]
    [Tooltip("Position of the input First Name.")]
    [SerializeField] RectTransform transformInputFirstNameCanvasSignOn;
    [Tooltip("Sprite of the input First Name.")]
    [SerializeField] Sprite imgInputFirstNameCanvasSignOn;
    [Tooltip("Color of the text of the placeholder of the input First Name.")]
    [SerializeField] Color colorTxtPHInputFirstNameCanvasSignOn;
    [Tooltip("Color of the text of the input First Name.")]
    [SerializeField] Color colorTxtInputFirstNameCanvasSignOn;
    [Header("Info First Name")]
    [Tooltip("Position of the info First Name.")]
    [SerializeField] RectTransform transformTxtInfoFirstNameCanvasSignOn;
    [Header("Last Name")]
    [Tooltip("Position of the input Last Name.")]
    [SerializeField] RectTransform transformInputLastNameCanvasSignOn;
    [Tooltip("Sprite of the input Last Name.")]
    [SerializeField] Sprite imgInputLastNameCanvasSignOn;
    [Tooltip("Color of the text of the placeholder of the input Last Name.")]
    [SerializeField] Color colorTxtPHInputLastNameCanvasSignOn;
    [Tooltip("Color of the text of the input Last Name.")]
    [SerializeField] Color colorTxtInputLastNameCanvasSignOn;
    [Header("Info Last Name")]
    [Tooltip("Position of the info Last Name.")]
    [SerializeField] RectTransform transformTxtInfoLastNameCanvasSignOn;
    [Header("Register")]
    [Tooltip("Position of the button Register.")]
    [SerializeField] RectTransform transformBtnRegisterCanvasSignOn;
    [Tooltip("Sprite of the button Register.")]
    [SerializeField] Sprite imgBtnRegisterCanvasSignOn;
    [Tooltip("Color of the text of the button Register.")]
    [SerializeField] Color colorTxtBtnRegisterCanvasSignOn;
    [Header("Back")]
    [Tooltip("Position of the button Back.")]
    [SerializeField] RectTransform transformBtnBackCanvasSignOn;
    [Tooltip("Sprite of the button Back.")]
    [SerializeField] Sprite imgBtnBackCanvasSignOn;
    [Tooltip("Color of the text of the button Back.")]
    [SerializeField] Color colorTxtBtnBackCanvasSignOn;
    [Header("PopUp Register")]
    [Tooltip("Position of the PopUp Register.")]
    [SerializeField] RectTransform transformPopUpCanvasSignOn;
    [Tooltip("Position of the image PopUp Register.")]
    [SerializeField] RectTransform transformImgPopUpCanvasSignOn;
    [Tooltip("Sprite of the PopUp Register.")]
    [SerializeField] Sprite imgPopUpRegisterCanvasSignOn;
    [Tooltip("Position of the text PopUp Register.")]
    [SerializeField] RectTransform transformTxtPopUpCanvasSignOn;
    [Tooltip("Color of the text of the PopUp Register.")]
    [SerializeField] Color colorTxtPopUpRegisterCanvasSignOn;
    [Tooltip("Position of the button PopUp Register.")]
    [SerializeField] RectTransform transformBtnPopUpRegisterCanvasSignOn;
    [Tooltip("Sprite of the button of the PopUp Register.")]
    [SerializeField] Sprite imgBtnPopUpRegisterCanvasSignOn;
    [Tooltip("Color of the text of the button of the PopUp Register.")]
    [SerializeField] Color colorBtnTxtPopUpRegisterCanvasSignOn;
    #endregion

    #region Getters & Setters
    public bool m_passwordVisible { get { return PASSWORD_VISIBLE; } set { PASSWORD_VISIBLE = value; } }
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
    /// Function use to change the theme on the Canvas Sign On.
    /// </summary>
    public void ChangeThemeCanvasSignOn()
    {
        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformBackgroundCanvasSignOn, transformBackgroundCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgBackgroundCanvasSignOn.sprite = imgBackgroundCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformTitleCanvasSignOn, transformTitleCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_tmpTitleCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTitleCanvasSignOn.color = colorTitleCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformInputPseudoCanvasSignOn, transformInputPseudoCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgInputPseudoCanvasSignOn.sprite = imgInputPseudoCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpPHInputPseudoCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpPHInputPseudoCanvasSignOn.color = colorTxtPHInputPseudoCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputPseudoCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputPseudoCanvasSignOn.color = colorTxtInputPseudoCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformBtnPseudoExistCanvasSignOn, transformBtnPseudoExistCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgBtnPseudoExistCanvasSignOn.sprite = imgBtnPseudoExistCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformTxtInfoPseudoCanvasSignOn, transformTxtInfoPseudoCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_tmpTxtInfoPseudoCanvasSignOn.font = font;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformInputPasswordCanvasSignOn, transformInputPasswordCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgInputPasswordCanvasSignOn.sprite = imgInputPasswordCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpPHInputPasswordCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpPHInputPasswordCanvasSignOn.color = colorTxtPHInputPasswordCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputPasswordCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputPasswordCanvasSignOn.color = colorTxtInputPasswordCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformBtnPasswordVisibleCanvasSignOn, transformBtnPasswordVisibleCanvasSignOn);
        if(PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasSignOn.m_imgBtnPasswordVisibleCanvasSignOn.sprite = imgBtnPasswordIsVisibleCanvasSignOn;
            _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Alphanumeric;
        }
        else
        {
            _goManager.m_goCanvasSignOn.m_imgBtnPasswordVisibleCanvasSignOn.sprite = imgBtnPasswordIsNotVisibleCanvasSignOn;
            _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Password;
        } 

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformTxtInfoPasswordCanvasSignOn, transformTxtInfoPasswordCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_tmpTxtInfoPasswordCanvasSignOn.font = font;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformInputEmailCanvasSignOn, transformInputEmailCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgInputEmailCanvasSignOn.sprite = imgInputEmailCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpPHInputEmailCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpPHInputEmailCanvasSignOn.color = colorTxtPHInputEmailCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputEmailCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputEmailCanvasSignOn.color = colorTxtInputEmailCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformTxtInfoEmailCanvasSignOn, transformTxtInfoEmailCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_tmpTxtInfoEmailCanvasSignOn.font = font;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformInputFirstNameCanvasSignOn, transformInputFirstNameCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgInputFirstNameCanvasSignOn.sprite = imgInputFirstNameCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpPHInputFirstNameCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpPHInputFirstNameCanvasSignOn.color = colorTxtPHInputFirstNameCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputFirstNameCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputFirstNameCanvasSignOn.color = colorTxtInputFirstNameCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformTxtInfoFirstNameCanvasSignOn, transformTxtInfoFirstNameCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_tmpTxtInfoFirstNameCanvasSignOn.font = font;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformInputLastNameCanvasSignOn, transformInputLastNameCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgInputLastNameCanvasSignOn.sprite = imgInputLastNameCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpPHInputLastNameCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpPHInputLastNameCanvasSignOn.color = colorTxtPHInputLastNameCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputLastNameCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtInputLastNameCanvasSignOn.color = colorTxtInputLastNameCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformTxtInfoLastNameCanvasSignOn, transformTxtInfoLastNameCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_tmpTxtInfoLastNameCanvasSignOn.font = font;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformBtnRegisterCanvasSignOn, transformBtnRegisterCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgBtnRegisterCanvasSignOn.sprite = imgBtnRegisterCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnRegisterCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnRegisterCanvasSignOn.color = colorTxtBtnRegisterCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformBtnBackCanvasSignOn, transformBtnBackCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgBtnBackCanvasSignOn.sprite = imgBtnBackCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnBackCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnBackCanvasSignOn.color = colorTxtBtnBackCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformPopUpRegisterCanvasSignOn, transformPopUpCanvasSignOn);

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformImgPopUpRegisterCanvasSignOn, transformImgPopUpCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgPopUpRegisterCanvasSignOn.sprite = imgPopUpRegisterCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformTxtPopUpRegisterCanvasSignOn,transformTxtPopUpCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_tmpTxtPopUpRegisterCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtPopUpRegisterCanvasSignOn.color = colorTxtPopUpRegisterCanvasSignOn;

        ChangeRectTransform(_goManager.m_goCanvasSignOn.m_transformBtnPopUpRegisterCanvasSignOn, transformBtnPopUpRegisterCanvasSignOn);
        _goManager.m_goCanvasSignOn.m_imgBtnPopUpRegisterCanvasSignOn.sprite = imgBtnPopUpRegisterCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnPopUpRegisterCanvasSignOn.font = font;
        _goManager.m_goCanvasSignOn.m_tmpTxtBtnPopUpRegisterCanvasSignOn.color = colorBtnTxtPopUpRegisterCanvasSignOn;
    }

    /// <summary>
    /// Function use to change the position of data(s) on the Canvas Sign On.
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
    /// Function use to change the visibilty of the password for the Canvas Sign On.
    /// </summary>
    public void ChangePasswordVisibility()
    {
        PASSWORD_VISIBLE = !PASSWORD_VISIBLE;

        if(PASSWORD_VISIBLE)
        { 
            _goManager.m_goCanvasSignOn.m_imgBtnPasswordVisibleCanvasSignOn.sprite = imgBtnPasswordIsVisibleCanvasSignOn;
            _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Alphanumeric;
            _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn.ForceLabelUpdate();
        }
        else
        {
            _goManager.m_goCanvasSignOn.m_imgBtnPasswordVisibleCanvasSignOn.sprite = imgBtnPasswordIsNotVisibleCanvasSignOn;
            _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Password;
            _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn.ForceLabelUpdate();
        } 
    }
    /// <summary>
    /// Function use to reinitialize the visibilty button to not visible for Canvas Sign On.
    /// </summary>
    public void ReinitializeVisibilityButtonCanvasSignOn()
    {
        PASSWORD_VISIBLE = false;

        _goManager.m_goCanvasSignOn.m_imgBtnPasswordVisibleCanvasSignOn.sprite = imgBtnPasswordIsNotVisibleCanvasSignOn;
        _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn.contentType = TMP_InputField.ContentType.Password;
        _goManager.m_goCanvasSignOn.m_inputPasswordCanvasSignOn.ForceLabelUpdate();
    }
    #endregion
}
