using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Librairy.
/// </summary>
[Serializable]
public class GameObjectCanvasLibrairy
{
    #region SerializeField
    [Header("Canvas Librairy")]
    [Tooltip("Scrollview of projects.")]
    [SerializeField] GameObject goSVPorjectsCanvasLibriary;
    [Tooltip("Scrollbar vertical of projects.")]
    [SerializeField] GameObject goSBVProjectsCanvasLibrairy;
    [Tooltip("Handle Scrollbar vertical of projects.")]
    [SerializeField] GameObject goHandleSBVProjectsCanvasLibrairy;
    [Tooltip("Background of projects.")]
    [SerializeField] GameObject[] goImgBackProjectsCanvasLibrairy;
    [Tooltip("Button of projects.")]
    [SerializeField] GameObject[] goBtnProjectsCanvasLibrairy;
    [Tooltip("Text Button of projects.")]
    [SerializeField] GameObject[] goTxtProjectsCanvasLibrairy;
    #endregion

    #region Getters & Setters
    public RectTransform m_transformSVPorjectsCanvasLibriary { get { return _transformSVPorjectsCanvasLibriary; } }

    public Image m_imgSBVProjectsCanvasLibrairy { get { return _imgSBVProjectsCanvasLibrairy; } }
    public Image m_imgHandleSBVProjectsCanvasLibrairy { get { return _imgHandleSBVProjectsCanvasLibrairy; } }

    public Image[] m_tabImgBackProjectsCanvasLibrairy { get { return _tabImgBackProjectsCanvasLibrairy; } }
    public Image[] m_tabImgBtnProjectsCanvasLibrairy { get { return _tabImgBtnProjectsCanvasLibrairy; } }

    public TextMeshProUGUI[] m_tabTxtProjectsCanvasLibrairy { get { return _tabTxtProjectsCanvasLibrairy; } }    
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    RectTransform _transformSVPorjectsCanvasLibriary = null;
    Image _imgSBVProjectsCanvasLibrairy = null, _imgHandleSBVProjectsCanvasLibrairy = null;
    Image[] _tabImgBackProjectsCanvasLibrairy, _tabImgBtnProjectsCanvasLibrairy;
    TextMeshProUGUI[] _tabTxtProjectsCanvasLibrairy;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformSVPorjectsCanvasLibriary = goSVPorjectsCanvasLibriary.GetComponent<RectTransform>();

        _imgSBVProjectsCanvasLibrairy = goSBVProjectsCanvasLibrairy.GetComponent<Image>();
        _imgHandleSBVProjectsCanvasLibrairy = goHandleSBVProjectsCanvasLibrairy.GetComponent<Image>();

        _tabImgBackProjectsCanvasLibrairy = new Image[goImgBackProjectsCanvasLibrairy.Length];
        for(int i = 0; i < goImgBackProjectsCanvasLibrairy.Length; i++)
        {
            _tabImgBackProjectsCanvasLibrairy[i] = goImgBackProjectsCanvasLibrairy[i].GetComponent<Image>();
        }
        _tabImgBtnProjectsCanvasLibrairy = new Image[goBtnProjectsCanvasLibrairy.Length];
        for (int i = 0; i < goBtnProjectsCanvasLibrairy.Length; i++)
        {
            _tabImgBtnProjectsCanvasLibrairy[i] = goBtnProjectsCanvasLibrairy[i].GetComponent<Image>();
        }

        _tabTxtProjectsCanvasLibrairy = new TextMeshProUGUI[goTxtProjectsCanvasLibrairy.Length];
        for (int i = 0; i < goTxtProjectsCanvasLibrairy.Length; i++)
        {
            _tabTxtProjectsCanvasLibrairy[i] = goTxtProjectsCanvasLibrairy[i].GetComponent<TextMeshProUGUI>();
        }
    }
    #endregion
}
