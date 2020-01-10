using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Manager.
/// </summary>
[Serializable]
public class LanguageCanvasManager
{
    #region SerializeField
    [Header("Canvas Manager.")]
    [Tooltip("Title of the Canvas Manager")]
    [SerializeField] protected string titleCanvasManager;
    [Tooltip("Mute")]
    [SerializeField] protected string mute;
    [Tooltip("Themes names in the dropdown theme.")]
    [SerializeField] protected string[] themes;
    [Tooltip("Label dropdown theme.")]
    [SerializeField] protected string labelTheme;
    [Tooltip("Text button Credit.")]
    [SerializeField] protected string txtBtnCredit;
    [Tooltip("Text Credits.")]
    [TextArea]
    [SerializeField] string[] txtCreditsPopUpCredit;
    [Tooltip("Text button Close Pop Up Credit.")]
    [SerializeField] protected string txtBtnClosePopUpCredit;
    [Tooltip("Text button Quit.")]
    [SerializeField] protected string txtBtnQuit;
    [Tooltip("Text PopUp Quit.")]
    [SerializeField] protected string txtPopUpQuit;
    [Tooltip("Text button Yes PopUp Quit.")]
    [SerializeField] protected string txtBtnYesPopUpQuit;
    [Tooltip("Text button No PopUp Quit.")]
    [SerializeField] protected string txtBtnNoPopUpQuit;
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
    /// This function is use to Change the language of data(s) for the Canvas Manager.
    /// </summary>
    public void ChangeLanguageCanvasManager()
    {
        _goManager.m_goCanvasManager.m_tmpTitleCanvasManager.text = titleCanvasManager;
        _goManager.m_goCanvasManager.m_tmpLabelToggleMuteCanvasManager.text = mute;

        int valueTheme = _goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.value;
        _goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.ClearOptions();
        _goManager.m_goCanvasManager.m_tmpLabelDropDownThemeCanvasManager.text = themes[valueTheme];
        foreach (string str in themes)
        {
            _goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.options.Add(new TMP_Dropdown.OptionData() { text = str });
        }
        _goManager.m_goCanvasManager.m_dropDownThemeCanvasManager.SetValueWithoutNotify(valueTheme);

        _goManager.m_goCanvasManager.m_tmpTxtBtnCreditCanvasManager.text = txtBtnCredit;

        for (int i = 0; i < txtCreditsPopUpCredit.Length; i++)
        {
            _goManager.m_goCanvasManager.m_tmpTabTxtCreditsPopUpCreditCanvasManager[i].text = txtCreditsPopUpCredit[i];
        }

        _goManager.m_goCanvasManager.m_tmpTxtBtnClosePopUpCreditCanvasManager.text = txtBtnClosePopUpCredit;

        _goManager.m_goCanvasManager.m_tmpTxtBtnQuitCanvasManager.text = txtBtnQuit;
        _goManager.m_goCanvasManager.m_tmpTxtPopUpQuitCanvasManager.text = txtPopUpQuit;
        _goManager.m_goCanvasManager.m_tmpTxtBtnYesPopUpQuitCanvasManager.text = txtBtnYesPopUpQuit;
        _goManager.m_goCanvasManager.m_tmpTxtBtnNoPopUpQuitCanvasManager.text = txtBtnNoPopUpQuit;    
    }
    #endregion
}
