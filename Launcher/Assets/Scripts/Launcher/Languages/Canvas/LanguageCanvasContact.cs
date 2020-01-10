using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Contact.
/// </summary>
[Serializable]
public class LanguageCanvasContact
{
    #region SerializeField
    [Header("Canvas Contact.")]
    [Tooltip("Text.")]
    [TextArea]
    [SerializeField] protected string txtCanvasContact;
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
    /// This function is use to Change the language of data(s) for the Canvas Contact.
    /// </summary>
    public void ChangeLanguageCanvasContact()
    {
        _goManager.m_goCanvasContact.m_tmpTxtCanvasContact.text = txtCanvasContact;
    }
    #endregion
}
