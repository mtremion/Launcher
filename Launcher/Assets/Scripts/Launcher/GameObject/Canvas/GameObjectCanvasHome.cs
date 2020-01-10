using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas Launcher.
/// </summary>
[Serializable]
public class GameObjectCanvasHome
{
    #region SerializeField
    [Header("Canvas Home / Informations")]
    [Tooltip("Background of part Informations.")]
    [SerializeField] GameObject goImgBackImgInformationsCanvasHome;
    [Tooltip("Img information")]
    [SerializeField] GameObject goImgInformationsCanvasHome;
    [Header("Canvas Home / Indicators Informations")]
    [Tooltip("Img indicator number information 1")]
    [SerializeField] GameObject goImgIndicatorNumberInformation1CanvasHome;
    [Tooltip("Img indicator number information 2")]
    [SerializeField] GameObject goImgIndicatorNumberInformation2CanvasHome;
    [Tooltip("Img indicator number information 3")]
    [SerializeField] GameObject goImgIndicatorNumberInformation3CanvasHome;
    [Header("Canvas Home / Arrow Informations Left")]
    [Tooltip("Background of part Left Arrow.")]
    [SerializeField] GameObject goImgBackBtnLeftArrowCanvasHome;
    [Tooltip("Background of part Left Arrow.")]
    [SerializeField] GameObject goBtnLeftArrowCanvasHome;
    [Header("Canvas Home / Arrow Informations Right")]
    [Tooltip("Background of part Right Arrow.")]
    [SerializeField] GameObject goImgBackBtnRightArrowCanvasHome;
    [Tooltip("Background of part Right Arrow.")]
    [SerializeField] GameObject goBtnRightArrowCanvasHome;
    [Header("Canvas Home / Text Home")]
    [Tooltip("Background of part text home.")]
    [SerializeField] GameObject goImgBackImgTextCanvasHome;
    [Tooltip("Text Home")]
    [SerializeField] GameObject goTextCanvasHome;
    #endregion

    #region Getters & Setters
    public RectTransform m_transformImgBackImgInformationsCanvasHome { get { return _transformImgBackImgInformationsCanvasHome; } }
    public RectTransform m_transformImgInformationsCanvasHome { get { return _transformImgInformationsCanvasHome; } }
    public RectTransform m_transformImgIndicatorNumberInformation1CanvasHome { get { return _transformImgIndicatorNumberInformation1CanvasHome; } }
    public RectTransform m_transformImgIndicatorNumberInformation2CanvasHome { get { return _transformImgIndicatorNumberInformation2CanvasHome; } }
    public RectTransform m_transformImgIndicatorNumberInformation3CanvasHome { get { return _transformImgIndicatorNumberInformation3CanvasHome; } }
    public RectTransform m_transformImgBackBtnLeftArrowCanvasHome { get { return _transformImgBackBtnLeftArrowCanvasHome; } }
    public RectTransform m_transformBtnLeftArrowCanvasHome { get { return _transformBtnLeftArrowCanvasHome; } }
    public RectTransform m_transformImgBackBtnRightArrowCanvasHome { get { return _transformImgBackBtnRightArrowCanvasHome; } }
    public RectTransform m_transformBtnRightArrowCanvasHome { get { return _transformBtnRightArrowCanvasHome; } }
    public RectTransform m_transformImgBackImgTextCanvasHome { get { return _transformImgBackImgTextCanvasHome; } }
    public RectTransform m_transformTextCanvasHome { get { return _transformTextCanvasHome; } }

    public Image m_imgImgBackImgInformationsCanvasHome { get { return _imgImgBackImgInformationsCanvasHome; } }
    public Image m_imgImgInformationsCanvasHome { get { return _imgImgInformationsCanvasHome; } }
    public Image m_imgImgIndicatorNumberInformation1CanvasHome { get { return _imgImgIndicatorNumberInformation1CanvasHome; } }
    public Image m_imgImgIndicatorNumberInformation2CanvasHome { get { return _imgImgIndicatorNumberInformation2CanvasHome; } }
    public Image m_imgImgIndicatorNumberInformation3CanvasHome { get { return _imgImgIndicatorNumberInformation3CanvasHome; } }
    public Image m_imgImgBackBtnLeftArrowCanvasHome { get { return _imgImgBackBtnLeftArrowCanvasHome; } }
    public Image m_imgBtnLeftArrowCanvasHome { get { return _imgBtnLeftArrowCanvasHome; } }
    public Image m_imgImgBackBtnRightArrowCanvasHome { get { return _imgImgBackBtnRightArrowCanvasHome; } }
    public Image m_imgBtnRightArrowCanvasHome { get { return _imgBtnRightArrowCanvasHome; } }
    public Image m_imgImgBackImgTextCanvasHome { get { return _imgImgBackImgTextCanvasHome; } }

    public TextMeshProUGUI m_tmpTextCanvasHome { get { return _tmpTextCanvasHome; } }
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    RectTransform _transformImgBackImgInformationsCanvasHome = null, _transformImgInformationsCanvasHome = null, _transformImgIndicatorNumberInformation1CanvasHome = null,
                _transformImgIndicatorNumberInformation2CanvasHome = null, _transformImgIndicatorNumberInformation3CanvasHome = null, _transformImgBackBtnLeftArrowCanvasHome = null,
                _transformBtnLeftArrowCanvasHome = null, _transformImgBackBtnRightArrowCanvasHome = null, _transformBtnRightArrowCanvasHome = null, 
                _transformImgBackImgTextCanvasHome = null, _transformTextCanvasHome = null;
    Image _imgImgBackImgInformationsCanvasHome = null, _imgImgInformationsCanvasHome = null, _imgImgIndicatorNumberInformation1CanvasHome = null,
        _imgImgIndicatorNumberInformation2CanvasHome = null, _imgImgIndicatorNumberInformation3CanvasHome = null, _imgImgBackBtnLeftArrowCanvasHome = null,
        _imgBtnLeftArrowCanvasHome = null, _imgImgBackBtnRightArrowCanvasHome = null, _imgBtnRightArrowCanvasHome = null,
        _imgImgBackImgTextCanvasHome = null;
    TextMeshProUGUI _tmpTextCanvasHome = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformImgBackImgInformationsCanvasHome = goImgBackImgInformationsCanvasHome.GetComponent<RectTransform>();
        _transformImgInformationsCanvasHome  = goImgInformationsCanvasHome.GetComponent<RectTransform>();
        _transformImgIndicatorNumberInformation1CanvasHome = goImgIndicatorNumberInformation1CanvasHome.GetComponent<RectTransform>();
        _transformImgIndicatorNumberInformation2CanvasHome = goImgIndicatorNumberInformation2CanvasHome.GetComponent<RectTransform>();
        _transformImgIndicatorNumberInformation3CanvasHome = goImgIndicatorNumberInformation3CanvasHome.GetComponent<RectTransform>();
        _transformImgBackBtnLeftArrowCanvasHome = goImgBackBtnLeftArrowCanvasHome.GetComponent<RectTransform>();
        _transformBtnLeftArrowCanvasHome = goBtnLeftArrowCanvasHome.GetComponent<RectTransform>();
        _transformImgBackBtnRightArrowCanvasHome = goImgBackBtnRightArrowCanvasHome.GetComponent<RectTransform>();
        _transformBtnRightArrowCanvasHome = goBtnRightArrowCanvasHome.GetComponent<RectTransform>();
        _transformImgBackImgTextCanvasHome = goImgBackImgTextCanvasHome.GetComponent<RectTransform>();
        _transformTextCanvasHome = goTextCanvasHome.GetComponent<RectTransform>();

        _imgImgBackImgInformationsCanvasHome = goImgBackImgInformationsCanvasHome.GetComponent<Image>();
        _imgImgInformationsCanvasHome = goImgInformationsCanvasHome.GetComponent<Image>();
        _imgImgIndicatorNumberInformation1CanvasHome = goImgIndicatorNumberInformation1CanvasHome.GetComponent<Image>();
        _imgImgIndicatorNumberInformation2CanvasHome = goImgIndicatorNumberInformation2CanvasHome.GetComponent<Image>();
        _imgImgIndicatorNumberInformation3CanvasHome = goImgIndicatorNumberInformation3CanvasHome.GetComponent<Image>();
        _imgImgBackBtnLeftArrowCanvasHome = goImgBackBtnLeftArrowCanvasHome.GetComponent<Image>();
        _imgBtnLeftArrowCanvasHome = goBtnLeftArrowCanvasHome.GetComponent<Image>();
        _imgImgBackBtnRightArrowCanvasHome = goImgBackBtnRightArrowCanvasHome.GetComponent<Image>();
        _imgBtnRightArrowCanvasHome = goBtnRightArrowCanvasHome.GetComponent<Image>();
        _imgImgBackImgTextCanvasHome = goImgBackImgTextCanvasHome.GetComponent<Image>();

        _tmpTextCanvasHome = goTextCanvasHome.GetComponent<TextMeshProUGUI>();
    }
    #endregion

    #region Main Methods

    #endregion
}
