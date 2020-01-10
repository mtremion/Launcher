using UnityEngine;
using System;

/// <summary>
/// This class contains data(s) for the lead the language on the Canvas Librairy.
/// </summary>
[Serializable]
public class LanguageCanvasLibrairy
{
    #region SerializeField
    [Header("Canvas Librairy.")]
    [Tooltip("Text : Informations projects.")]
    [TextArea]
    [SerializeField] string[] txtProjects;
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
    /// This function is use to Change the language of data(s) for the Canvas Librairy.
    /// </summary>
    public void ChangeLanguageCanvasLibrairy()
    {
        for(int i = 0; i < txtProjects.Length; i++)
        {
            _goManager.m_goCanvasLibrairy.m_tabTxtProjectsCanvasLibrairy[i].text = txtProjects[i];
        }
    }
    #endregion
}
