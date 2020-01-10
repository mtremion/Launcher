using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Home.
/// </summary>
[Serializable]
public class LanguageCanvasHome
{
    #region SerializeField
    [Header("Canvas Home.")]
    [Tooltip("Text Home.")]
    [TextArea]
    [SerializeField] protected string txtCanvasHome;
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
    /// This function is use to Change the language of data(s) for the Canvas Home.
    /// </summary>
    public void ChangeLanguageCanvasHome()
    {
        _goManager.m_goCanvasHome.m_tmpTextCanvasHome.text = txtCanvasHome;
    }
    #endregion
}
