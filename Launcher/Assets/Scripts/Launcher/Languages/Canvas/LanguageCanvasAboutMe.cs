using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas About Me.
/// </summary>
[Serializable]
public class LanguageCanvasAboutMe
{
    #region SerializeField
    [Header("Canvas About Me.")]
    [Tooltip("Text Informations.")]
    [TextArea]
    [SerializeField] protected string txtInformationsCanvasAboutMe;
    [Tooltip("Text About Me.")]
    [TextArea]
    [SerializeField] protected string txtCanvasAboutMe;
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
    /// This function is use to Change the language of data(s) for the Canvas About Me.
    /// </summary>
    public void ChangeLanguageCanvasAboutMe()
    {
        _goManager.m_goCanvasAboutMe.m_tmpTxtInformationsCanvasAboutMe.text = txtInformationsCanvasAboutMe;
        _goManager.m_goCanvasAboutMe.m_tmpTxtCanvasAboutMe.text = txtCanvasAboutMe;
    }
    #endregion
}
