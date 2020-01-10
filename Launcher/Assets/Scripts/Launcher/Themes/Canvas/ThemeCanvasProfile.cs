using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Profile
/// </summary>
[Serializable]
public class ThemeCanvasProfile
{
    #region Static
    static bool NEW_PASSWORD_VISIBLE = false;
    static bool CONFIRM_PASSWORD_VISIBLE = false;
    #endregion

    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Canvas Contact / Personal Informations")]
    [Tooltip("Position of background Personal Informations")]
    [SerializeField] RectTransform transformImgBackPersonnalsInformationsCanvasProfile;
    [Tooltip("Sprite of background Personal Informations")]
    [SerializeField] Sprite imgImgBackPersonnalsInformationsCanvasProfile;
    [Tooltip("Position of background text Personal Informations")]
    [SerializeField] RectTransform transformImgBackTxtPersonnalsInformationsCanvasProfile;
    [Tooltip("Sprite of background text Personal Informations")]
    [SerializeField] Sprite imgImgBackTxtPersonnalsInformationsCanvasProfile;
    [Tooltip("Position of text Personal Informations")]
    [SerializeField] RectTransform transformTxtPersonnalsInformationsCanvasProfile;
    [Tooltip("Color of text Personal Informations")]
    [SerializeField] Color colorTxtPersonnalsInformationsCanvasProfile;
    [Tooltip("Position of text Pseudo")]
    [SerializeField] RectTransform transformTxtPseudoCanvasProfile;
    [Tooltip("Color of text Pseudo")]
    [SerializeField] Color colorTxtPseudoCanvasProfile;
    [Tooltip("Position of text Last name")]
    [SerializeField] RectTransform transformTxtLastNameCanvasProfile;
    [Tooltip("Color of text Last name")]
    [SerializeField] Color colorTxtLastNameCanvasProfile;
    [Tooltip("Position of background First name")]
    [SerializeField] RectTransform transformTxtFirstNameCanvasProfile;
    [Tooltip("Color of text First name")]
    [SerializeField] Color colorTxtFirstNameCanvasProfile;
    [Tooltip("Position of background Email")]
    [SerializeField] RectTransform transformTxtEmailCanvasProfile;
    [Tooltip("Color of text Email")]
    [SerializeField] Color colorTxtEmailCanvasProfile;
    [Tooltip("Position of image Profile")]
    [SerializeField] RectTransform transformImgProfileCanvasProfile;
    [Tooltip("Sprite of image Profile")]
    [SerializeField] Sprite imgImgProfileCanvasProfile;
    [Tooltip("Position of Button Change image Profile")]
    [SerializeField] RectTransform transformBtnChangeProfileCanvasProfile;
    [Tooltip("Sprite of Button Change image Profile")]
    [SerializeField] Sprite imgBtnChangeProfileCanvasProfile;
    [Tooltip("Color of text Button Change image Profile")]
    [SerializeField] Color colorTxtBtnChangeProfileCanvasProfile;
    [Header("Canvas Contact / Change password")]
    [Tooltip("Position of Background Change Password")]
    [SerializeField] RectTransform transformImgBackChangePasswordCanvasProfile;
    [Tooltip("Sprite of Background Change Password")]
    [SerializeField] Sprite imgImgBackChangePasswordCanvasProfile;
    [Tooltip("Position of Background text Change Password")]
    [SerializeField] RectTransform transformImgBackTxtChangePasswordCanvasProfile;
    [Tooltip("Sprite of Background text Change Password")]
    [SerializeField] Sprite imgImgBackTxtChangePasswordCanvasProfile;
    [Tooltip("Position of text Change Password")]
    [SerializeField] RectTransform transformTxtChangePasswordCanvasProfile;
    [Tooltip("Color of text Change Password")]
    [SerializeField] Color colorTxtChangePasswordCanvasProfile;
    [Tooltip("Position of Input New Password")]
    [SerializeField] RectTransform transformInputNewPasswordCanvasProfile;
    [Tooltip("Sprite of Input New Password")]
    [SerializeField] Sprite imgInputNewPasswordCanvasProfile;
    [Tooltip("Color of text Placeholder Input New Password")]
    [SerializeField] Color colorTxtPHInputNewPasswordCanvasProfile;
    [Tooltip("Color of text Input New Password")]
    [SerializeField] Color colorTxtInputNewPasswordCanvasProfile;
    [Tooltip("Position of Button Visibility New Password")]
    [SerializeField] RectTransform transformBtnVisibilityNewPasswordCanvasProfile;
    [Tooltip("Sprite of Button Visibility New Password visible")]
    [SerializeField] Sprite imgBtnVisibleNewPasswordCanvasProfile;
    [Tooltip("Sprite of Button Visibility New Password not visible")]
    [SerializeField] Sprite imgBtnNotVisibleNewPasswordCanvasProfile;
    [Tooltip("Position of Input Confirm Password")]
    [SerializeField] RectTransform transformInputConfirmPasswordCanvasProfile;
    [Tooltip("Sprite of Input Confirm Password")]
    [SerializeField] Sprite imgInputConfirmPasswordCanvasProfile;
    [Tooltip("Color of text Placeholder Input Confirm Password")]
    [SerializeField] Color colorTxtPHInputConfirmPasswordCanvasProfile;
    [Tooltip("Color of text Input Confirm Password")]
    [SerializeField] Color colorTxtInputConfirmPasswordCanvasProfile;
    [Tooltip("Position of Button Visibility Confirm Password")]
    [SerializeField] RectTransform transformBtnVisibilityConfirmPasswordCanvasProfile;
    [Tooltip("Sprite of Button Visibility Confirm Password visible")]
    [SerializeField] Sprite imgBtnVisibleConfirmPasswordCanvasProfile;
    [Tooltip("Sprite of Button Visibility Confirm Password not visible")]
    [SerializeField] Sprite imgBtnNotVisibleConfirmPasswordCanvasProfile;
    [Tooltip("Position of text Info Password")]
    [SerializeField] RectTransform transformTxtInfoPasswordsCanvasProfile;
    [Tooltip("Position of Button Change Password")]
    [SerializeField] RectTransform transformBtnChangePasswordCanvasProfile;
    [Tooltip("Sprite of Button Change Password")]
    [SerializeField] Sprite imgBtnChangePasswordCanvasProfile;
    [Tooltip("Color of text Button Change Password")]
    [SerializeField] Color colorTxtBtnChangePasswordCanvasProfile;
    [Header("Canvas Contact / Change password / Pop Up")]
    [Tooltip("Position of background Pop Up Change Password")]
    [SerializeField] RectTransform transformImgPopUpChangePasswordCanvasProfile;
    [Tooltip("Sprite of background Pop Up Change Password")]
    [SerializeField] Sprite imgImgPopUpChangePasswordCanvasProfile;
    [Tooltip("Position of text Pop Up Change Password")]
    [SerializeField] RectTransform transformTxtPopUpChangePasswordCanvasProfile;
    [Tooltip("Color of text Pop Up Change Password")]
    [SerializeField] Color colorTxtPopUpChangePasswordCanvasProfile;
    [Tooltip("Position of Button Ok Pop Up Change Password")]
    [SerializeField] RectTransform transformBtnOkPopUpChangePasswordCanvasProfile;
    [Tooltip("Sprite of Button Ok Pop Up Change Password")]
    [SerializeField] Sprite imgBtnOkPopUpChangePasswordCanvasProfile;
    [Tooltip("Color of text Button Ok Pop Up Change Password")]
    [SerializeField] Color colorTxtBtnOkPopUpChangePasswordCanvasProfile;
    [Header("Canvas Contact / Delete account")]
    [Tooltip("Position of Background Delete Account")]
    [SerializeField] RectTransform transformImgBackDeleteAccountCanvasProfile;
    [Tooltip("Sprite of Background Delete Account")]
    [SerializeField] Sprite imgImgBackDeleteAccountCanvasProfile;
    [Tooltip("Position of Background txt Delete Account")]
    [SerializeField] RectTransform transformImgBackTxtDeleteAccountCanvasProfile;
    [Tooltip("Sprite of Background text Delete Account")]
    [SerializeField] Sprite imgImgBackTxtDeleteAccountCanvasProfile;
    [Tooltip("Position of text Delete Account")]
    [SerializeField] RectTransform transformTxtDeleteAccountCanvasProfile;
    [Tooltip("Color of text Delete Account")]
    [SerializeField] Color colorTxtDeleteAccountCanvasProfile;
    [Tooltip("Position of Button Delete Delete Account")]
    [SerializeField] RectTransform transformBtnDeleteAccountCanvasProfile;
    [Tooltip("Sprite of Button Delete Delete Account")]
    [SerializeField] Sprite imgBtnDeleteAccountCanvasProfile;
    [Tooltip("Color of text Button Delete Delete Account")]
    [SerializeField] Color colorTxtBtnDeleteAccountPasswordCanvasProfile;
    [Header("Canvas Contact / Delete account / Pop up")]
    [Tooltip("Position of Background Pop Up Delete Account")]
    [SerializeField] RectTransform transformImgPopUpDeleteAccountCanvasProfile;
    [Tooltip("Sprite of Background Pop Up Delete Account")]
    [SerializeField] Sprite imgImgPopUpDeleteAccountCanvasProfile;
    [Tooltip("Position of text Pop Up Delete Account")]
    [SerializeField] RectTransform transformTxtPopUpDeleteAccountCanvasProfile;
    [Tooltip("Color of text Pop Up Delete Account")]
    [SerializeField] Color colorTxtPopUpDeleteAccountCanvasProfile;
    [Tooltip("Position of Button Yes Pop Up Delete Account")]
    [SerializeField] RectTransform transformBtnYesPopUpDeleteAccountCanvasProfile;
    [Tooltip("Sprite of Button Yes Pop Up Delete Account")]
    [SerializeField] Sprite imgBtnYesPopUpDeleteAccountCanvasProfile;
    [Tooltip("Color of text Button Yes Pop Up Delete Account")]
    [SerializeField] Color colorTxtBtnYesPopUpDeleteAccountCanvasProfile;
    [Tooltip("Position of Button Cancel Pop Up Delete Account")]
    [SerializeField] RectTransform transformBtnCancelPopUpDeleteAccountCanvasProfile;
    [Tooltip("Sprite of Button Cancel Pop Up Delete Account")]
    [SerializeField] Sprite imgBtnCancelPopUpDeleteAccountCanvasProfile;
    [Tooltip("Color of text Button Cancel Pop Up Delete Account")]
    [SerializeField] Color colorTxtBtnCancelPopUpDeleteAccountCanvasProfile;
    #endregion

    #region Getters & Setters
    public bool m_newPasswordVisible { get { return NEW_PASSWORD_VISIBLE; } set { NEW_PASSWORD_VISIBLE = value; } }
    public bool m_confirmPasswordVisible { get { return CONFIRM_PASSWORD_VISIBLE; } set { CONFIRM_PASSWORD_VISIBLE = value; } }
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
    /// Function use to change the theme on the Profile.
    /// </summary>
    public void ChangeThemeCanvasProfile()
    {
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgBackPersonnalsInformationsCanvasProfile, transformImgBackPersonnalsInformationsCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgBackTxtPersonnalsInformationsCanvasProfile, transformImgBackTxtPersonnalsInformationsCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtPersonnalsInformationsCanvasProfile, transformTxtPersonnalsInformationsCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtPseudoCanvasProfile, transformTxtPseudoCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtLastNameCanvasProfile, transformTxtLastNameCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtFirstNameCanvasProfile, transformTxtFirstNameCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtEmailCanvasProfile, transformTxtEmailCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgProfileCanvasProfile, transformImgProfileCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformBtnChangeProfileCanvasProfile, transformBtnChangeProfileCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgBackChangePasswordCanvasProfile, transformImgBackChangePasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgBackTxtChangePasswordCanvasProfile, transformImgBackTxtChangePasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtChangePasswordCanvasProfile, transformTxtChangePasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformInputNewPasswordCanvasProfile, transformInputNewPasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformBtnVisibilityNewPasswordCanvasProfile, transformBtnVisibilityNewPasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformInputConfirmPasswordCanvasProfile, transformInputConfirmPasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformBtnVisibilityConfirmPasswordCanvasProfile, transformBtnVisibilityConfirmPasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtInfoPasswordsCanvasProfile, transformTxtInfoPasswordsCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformBtnChangePasswordCanvasProfile, transformBtnChangePasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgPopUpChangePasswordCanvasProfile, transformImgPopUpChangePasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtPopUpChangePasswordCanvasProfile, transformTxtPopUpChangePasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformBtnOkPopUpChangePasswordCanvasProfile, transformBtnOkPopUpChangePasswordCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgBackDeleteAccountCanvasProfile, transformImgBackDeleteAccountCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgBackTxtDeleteAccountCanvasProfile, transformImgBackTxtDeleteAccountCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtDeleteAccountCanvasProfile, transformTxtDeleteAccountCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformBtnDeleteAccountCanvasProfile, transformBtnDeleteAccountCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformImgPopUpDeleteAccountCanvasProfile, transformImgPopUpDeleteAccountCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformTxtPopUpDeleteAccountCanvasProfile, transformTxtPopUpDeleteAccountCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformBtnYesPopUpDeleteAccountCanvasProfile, transformBtnYesPopUpDeleteAccountCanvasProfile);
        ChangeRectTransform(_goManager.m_goCanvasProfile.m_transformBtnCancelPopUpDeleteAccountCanvasProfile, transformBtnCancelPopUpDeleteAccountCanvasProfile);

        _goManager.m_goCanvasProfile.m_imgImgBackPersonnalsInformationsCanvasProfile.sprite = imgImgBackPersonnalsInformationsCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgImgBackTxtPersonnalsInformationsCanvasProfile.sprite = imgImgBackTxtPersonnalsInformationsCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgImgProfileCanvasProfile.sprite = imgImgProfileCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgBtnChangeProfileCanvasProfile.sprite = imgBtnChangeProfileCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgImgBackChangePasswordCanvasProfile.sprite = imgImgBackChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgImgBackTxtChangePasswordCanvasProfile.sprite = imgImgBackTxtChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgInputNewPasswordCanvasProfile.sprite = imgInputNewPasswordCanvasProfile;

        if (NEW_PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasProfile.m_imgBtnVisibilityNewPasswordCanvasProfile.sprite = imgBtnVisibleNewPasswordCanvasProfile;
            _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Alphanumeric;
        }
        else
        {
            _goManager.m_goCanvasProfile.m_imgBtnVisibilityNewPasswordCanvasProfile.sprite = imgBtnNotVisibleNewPasswordCanvasProfile;
            _goManager.m_goCanvasForgotPassword.m_InputNewPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        }

        _goManager.m_goCanvasProfile.m_imgInputConfirmPasswordCanvasProfile.sprite = imgInputConfirmPasswordCanvasProfile;

        if (CONFIRM_PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasProfile.m_imgBtnVisibilityConfirmPasswordCanvasProfile.sprite = imgBtnVisibleConfirmPasswordCanvasProfile;
            _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Alphanumeric;
        }
        else
        {
            _goManager.m_goCanvasProfile.m_imgBtnVisibilityConfirmPasswordCanvasProfile.sprite = imgBtnNotVisibleConfirmPasswordCanvasProfile;
            _goManager.m_goCanvasForgotPassword.m_InputConfirmPasswordPopUpChangePassword.contentType = TMP_InputField.ContentType.Password;
        }

        _goManager.m_goCanvasProfile.m_imgBtnChangePasswordCanvasProfile.sprite = imgBtnChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgImgPopUpChangePasswordCanvasProfile.sprite = imgImgPopUpChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgBtnOkPopUpChangePasswordCanvasProfile.sprite = imgBtnOkPopUpChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgImgBackDeleteAccountCanvasProfile.sprite = imgImgBackDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgImgBackTxtDeleteAccountCanvasProfile.sprite = imgImgBackTxtDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgBtnDeleteAccountCanvasProfile.sprite = imgBtnDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgImgPopUpDeleteAccountCanvasProfile.sprite = imgImgPopUpDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgBtnYesPopUpDeleteAccountCanvasProfile.sprite = imgBtnYesPopUpDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_imgBtnCancelPopUpDeleteAccountCanvasProfile.sprite = imgBtnCancelPopUpDeleteAccountCanvasProfile;

        _goManager.m_goCanvasProfile.m_tmpTxtPersonnalsInformationsCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtPseudoCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtLastNameCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtFirstNameCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtEmailCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnChangeProfileCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtChangePasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtPHInputNewPasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtInputNewPasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtPHInputConfirmPasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtInputConfirmPasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtInfoPasswordsCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnChangePasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtPopUpChangePasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnOkPopUpChangePasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtDeleteAccountCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnDeleteAccountPasswordCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtPopUpDeleteAccountCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnYesPopUpDeleteAccountCanvasProfile.font = font;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnCancelPopUpDeleteAccountCanvasProfile.font = font;

        _goManager.m_goCanvasProfile.m_tmpTxtPersonnalsInformationsCanvasProfile.color = colorTxtPersonnalsInformationsCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPseudoCanvasProfile.color = colorTxtPseudoCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtLastNameCanvasProfile.color = colorTxtLastNameCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtFirstNameCanvasProfile.color = colorTxtFirstNameCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtEmailCanvasProfile.color = colorTxtEmailCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnChangeProfileCanvasProfile.color = colorTxtBtnChangeProfileCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtChangePasswordCanvasProfile.color = colorTxtChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPHInputNewPasswordCanvasProfile.color = colorTxtPHInputNewPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtInputNewPasswordCanvasProfile.color = colorTxtInputNewPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPHInputConfirmPasswordCanvasProfile.color = colorTxtPHInputConfirmPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtInputConfirmPasswordCanvasProfile.color = colorTxtInputConfirmPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnChangePasswordCanvasProfile.color = colorTxtBtnChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPopUpChangePasswordCanvasProfile.color = colorTxtPopUpChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnOkPopUpChangePasswordCanvasProfile.color = colorTxtBtnOkPopUpChangePasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtDeleteAccountCanvasProfile.color = colorTxtDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnDeleteAccountPasswordCanvasProfile.color = colorTxtBtnDeleteAccountPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtPopUpDeleteAccountCanvasProfile.color = colorTxtPopUpDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnYesPopUpDeleteAccountCanvasProfile.color = colorTxtBtnYesPopUpDeleteAccountCanvasProfile;
        _goManager.m_goCanvasProfile.m_tmpTxtBtnCancelPopUpDeleteAccountCanvasProfile.color = colorTxtBtnCancelPopUpDeleteAccountCanvasProfile;
    }
    /// <summary>
    /// Function use to change the position of data(s) on the Canvas Profile.
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
    /// Function use to change the visibilty of the new password for the Canvas Profile.
    /// </summary>
    public void ChangeNewPasswordVisibilityCanvasProfile()
    {
        NEW_PASSWORD_VISIBLE = !NEW_PASSWORD_VISIBLE;

        if (NEW_PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasProfile.m_imgBtnVisibilityNewPasswordCanvasProfile.sprite = imgBtnVisibleNewPasswordCanvasProfile;
            _goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile.contentType = TMP_InputField.ContentType.Alphanumeric;
            _goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile.ForceLabelUpdate();
        }
        else
        {
            _goManager.m_goCanvasProfile.m_imgBtnVisibilityNewPasswordCanvasProfile.sprite = imgBtnNotVisibleNewPasswordCanvasProfile;
            _goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile.contentType = TMP_InputField.ContentType.Password;
            _goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile.ForceLabelUpdate();
        }
    }
    /// <summary>
    /// Function use to change the visibilty of the confirm password for the Canvas Profile.
    /// </summary>
    public void ChangeConfirmPasswordVisibilityCanvasProfile()
    {
        CONFIRM_PASSWORD_VISIBLE = !CONFIRM_PASSWORD_VISIBLE;


        if (CONFIRM_PASSWORD_VISIBLE)
        {
            _goManager.m_goCanvasProfile.m_imgBtnVisibilityConfirmPasswordCanvasProfile.sprite = imgBtnVisibleConfirmPasswordCanvasProfile;
            _goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile.contentType = TMP_InputField.ContentType.Alphanumeric;
            _goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile.ForceLabelUpdate();
        }
        else
        {
            _goManager.m_goCanvasProfile.m_imgBtnVisibilityConfirmPasswordCanvasProfile.sprite = imgBtnNotVisibleConfirmPasswordCanvasProfile;
            _goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile.contentType = TMP_InputField.ContentType.Password;
            _goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile.ForceLabelUpdate();
        }
    }
    /// <summary>
    /// Function use to reinitialize the visibilty button to not visible for Canvas Profile.
    /// </summary>
    public void ReinitializeVisibilityButtonCanvasProfil()
    {
        NEW_PASSWORD_VISIBLE = false;
        CONFIRM_PASSWORD_VISIBLE = false;

        _goManager.m_goCanvasProfile.m_imgBtnVisibilityNewPasswordCanvasProfile.sprite = imgBtnNotVisibleNewPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile.contentType = TMP_InputField.ContentType.Password;
        _goManager.m_goCanvasProfile.m_inputInputNewPasswordCanvasProfile.ForceLabelUpdate();

        _goManager.m_goCanvasProfile.m_imgBtnVisibilityConfirmPasswordCanvasProfile.sprite = imgBtnNotVisibleConfirmPasswordCanvasProfile;
        _goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile.contentType = TMP_InputField.ContentType.Password;
        _goManager.m_goCanvasProfile.m_inputInputConfirmPasswordCanvasProfile.ForceLabelUpdate();
    }
    #endregion
}
