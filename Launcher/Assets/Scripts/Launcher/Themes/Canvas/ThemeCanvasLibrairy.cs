using UnityEngine;
using System;
using TMPro;

/// <summary>
/// This class contains data(s) for the lead the Theme on the Canvas Librairy
/// </summary>
[Serializable]
public class ThemeCanvasLibrairy
{
    #region SerializeField
    [Header("Globals")]
    [Tooltip("Font asset of the theme.")]
    [SerializeField] TMP_FontAsset font;
    [Header("Canvas Librairy / Scroll view")]
    [Tooltip("Position of the Scroll view Projects.")]
    [SerializeField] RectTransform transformSVProjectsCanvasLibrairy;
    [Header("Canvas Librairy / Presentation projects")]
    [Tooltip("Sprite of the background presentation projects.")]
    [SerializeField] Sprite imgBackProjectsCanvasLibrairy;
    [Tooltip("Sprite of presentation projects.")]
    [SerializeField] Sprite[] imgProjectsCanvasLibrairy;
    [Tooltip("Color of text presentation projects.")]
    [SerializeField] Color colorTxtProjectsCanvasLibrairy;
    [Header("Canvas Librairy / Scrollbar")]
    [Tooltip("Sprite of the background scrollbar vertical.")]
    [SerializeField] Sprite imgBackSBVCanvasLibrairy;
    [Tooltip("Sprite of the handle scrollbar.")]
    [SerializeField] Sprite imgHandleSBVCanvasLibrairy;
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
    public void ChangeThemeCanvasLibrairy()
    {
        ChangeRectTransform(_goManager.m_goCanvasLibrairy.m_transformSVPorjectsCanvasLibriary, transformSVProjectsCanvasLibrairy);

        for(int i = 0; i < imgProjectsCanvasLibrairy.Length; i++)
        {
            _goManager.m_goCanvasLibrairy.m_tabImgBackProjectsCanvasLibrairy[i].sprite = imgBackProjectsCanvasLibrairy;
            _goManager.m_goCanvasLibrairy.m_tabImgBtnProjectsCanvasLibrairy[i].sprite = imgProjectsCanvasLibrairy[i];
            _goManager.m_goCanvasLibrairy.m_tabTxtProjectsCanvasLibrairy[i].font = font;
            _goManager.m_goCanvasLibrairy.m_tabTxtProjectsCanvasLibrairy[i].color = colorTxtProjectsCanvasLibrairy;
        }

        _goManager.m_goCanvasLibrairy.m_imgSBVProjectsCanvasLibrairy.sprite = imgBackSBVCanvasLibrairy;
        _goManager.m_goCanvasLibrairy.m_imgHandleSBVProjectsCanvasLibrairy.sprite = imgHandleSBVCanvasLibrairy;
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
    #endregion
}
