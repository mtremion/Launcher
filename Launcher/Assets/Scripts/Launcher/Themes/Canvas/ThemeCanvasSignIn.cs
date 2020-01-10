using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Sign In.
/// </summary>
[Serializable]
public class ThemeCanvasSignIn
{
    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Background")]
    [Tooltip("Sprite of the background.")]
    [SerializeField] Sprite imgBackgroundCanvasSignIn;
    [Tooltip("Position of the background.")]
    [SerializeField] RectTransform transformBackgroundCanvasSignIn;
    [Header("Title")]
    [Tooltip("Position of the title of the canvas sign in.")]
    [SerializeField] RectTransform transformTitleCanvasSignIn;
    [Tooltip("Color of the title of the canvas sign in.")]
    [SerializeField] Color colorTitleCanvasSignIn;
    [Header("Pseudo")]
    [Tooltip("Position of the input pseudo.")]
    [SerializeField] RectTransform transformInputPseudoCanvasSignIn;
    [Tooltip("Sprite input pseudo of the canvas sign in.")]
    [SerializeField] Sprite imgInputPseudoCanvasSignIn;
    [Tooltip("Color text placeholder pseudo of the canvas sign in.")]
    [SerializeField] Color colorPHPseudoCanvasSignIn;
    [Tooltip("Color text pseudo of the canvas sign in.")]
    [SerializeField] Color colorTextPseudoCanvasSignIn;
    [Header("Password")]
    [Tooltip("Position of the input password.")]
    [SerializeField] RectTransform transformInputPasswordCanvasSignIn;
    [Tooltip("Sprite input pseudo of the canvas sign in.")]
    [SerializeField] Sprite imgInputPasswordCanvasSignIn;
    [Tooltip("Color text placeholder pseudo of the canvas sign in.")]
    [SerializeField] Color colorPHPasswordCanvasSignIn;
    [Tooltip("Color text input password of the canvas sign in.")]
    [SerializeField] Color colorTextPasswordCanvasSignIn;
    [Header("Info text")]
    [Tooltip("Position of the info text.")]
    [SerializeField] RectTransform transformInfoTextCanvasSignIn;
    [Header("Forgot Password")]
    [Tooltip("Position of the button forgot password.")]
    [SerializeField] RectTransform transformForgotPasswordCanvasSignIn;
    [Tooltip("Color text forgot password of the canvas sign in.")]
    [SerializeField] Color colorForgotPasswordCanvasSignIn;
    [Header("New account")]
    [Tooltip("Position of the button new account.")]
    [SerializeField] RectTransform transformNewAccountCanvasSignIn;
    [Tooltip("Color text new account password of the canvas sign in.")]
    [SerializeField] Color colorNewAccountCanvasSignIn;
    [Header("Connection")]
    [Tooltip("Position of the button connection.")]
    [SerializeField] RectTransform transformConnectionCanvasSignIn;
    [Tooltip("Color text connection of the canvas sign in.")]
    [SerializeField] Color colorConnectionCanvasSignIn;
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
    /// Function use to change the theme on the Canvas Sign In.
    /// </summary>
    public void ChangeThemeCanvasSignIn()
    {
        ChangeRectTransform(_goManager.m_goCanvasSignIn.m_transformBackgroundCanvasSignIn, transformBackgroundCanvasSignIn);
        _goManager.m_goCanvasSignIn.m_imgBackgroundCanvasSignIn.sprite = imgBackgroundCanvasSignIn;

        ChangeRectTransform(_goManager.m_goCanvasSignIn.m_transformTitleCanvasSignIn, transformTitleCanvasSignIn);
        _goManager.m_goCanvasSignIn.m_tmpTitleCanvasSignIn.font = font;
        _goManager.m_goCanvasSignIn.m_tmpTitleCanvasSignIn.color = colorTitleCanvasSignIn;

        ChangeRectTransform(_goManager.m_goCanvasSignIn.m_transformInputPseudoCanvasSignIn, transformInputPseudoCanvasSignIn);
        _goManager.m_goCanvasSignIn.m_imgInputPseudoCanvasSignIn.sprite = imgInputPseudoCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpPHInputPseudoCanvasSignIn.font = font;
        _goManager.m_goCanvasSignIn.m_tmpPHInputPseudoCanvasSignIn.color = colorPHPseudoCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpTxtInputPseudoCanvasSignIn.font = font;
        _goManager.m_goCanvasSignIn.m_tmpTxtInputPseudoCanvasSignIn.color = colorTextPseudoCanvasSignIn;

        ChangeRectTransform(_goManager.m_goCanvasSignIn.m_transformInputPasswordCanvasSignIn, transformInputPasswordCanvasSignIn);
        _goManager.m_goCanvasSignIn.m_imgInputPasswordCanvasSignIn.sprite = imgInputPasswordCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpPHInputPasswordCanvasSignIn.font = font;
        _goManager.m_goCanvasSignIn.m_tmpPHInputPasswordCanvasSignIn.color = colorPHPasswordCanvasSignIn;
        _goManager.m_goCanvasSignIn.m_tmpTxtInputPasswordCanvasSignIn.color = colorTextPseudoCanvasSignIn;

        ChangeRectTransform(_goManager.m_goCanvasSignIn.m_transformTxtInfoConnectionCanvasSignIn, transformInfoTextCanvasSignIn);
        _goManager.m_goCanvasSignIn.m_tmpTxtInfoConnectionCanvasSignIn.font = font;

        ChangeRectTransform(_goManager.m_goCanvasSignIn.m_transformBtnForgotPasswordCanvasSignIn, transformForgotPasswordCanvasSignIn);
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnForgotPasswordCanvasSignIn.font = font;
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnForgotPasswordCanvasSignIn.color = colorForgotPasswordCanvasSignIn;

        ChangeRectTransform(_goManager.m_goCanvasSignIn.m_transformBtnNewAccountCanvasSignIn, transformNewAccountCanvasSignIn);
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnNewAccountCanvasSignIn.font = font;
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnNewAccountCanvasSignIn.color = colorNewAccountCanvasSignIn;

        ChangeRectTransform(_goManager.m_goCanvasSignIn.m_transformBtnConnectionCanvasSignIn, transformConnectionCanvasSignIn);
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnConnectionCanvasSignIn.font = font;
        _goManager.m_goCanvasSignIn.m_tmpTxtBtnConnectionCanvasSignIn.color = colorConnectionCanvasSignIn;
    }

    /// <summary>
    /// Function use to change the position of data(s) on the Canvas Sign In.
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
