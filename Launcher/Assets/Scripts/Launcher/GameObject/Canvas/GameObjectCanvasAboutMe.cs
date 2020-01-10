using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This class contains GameObject of the Canvas About Me.
/// </summary>
[Serializable]
public class GameObjectCanvasAboutMe
{
    #region SerializeField
    [Header("Canvas About Me / Me")]
    [Tooltip("Background of part Me.")]
    [SerializeField] GameObject goImgBackImgMeCanvasAboutMe;
    [Tooltip("Img Me.")]
    [SerializeField] GameObject goImgMeCanvasAboutMe;
    [Header("Canvas About Me / Informations")]
    [Tooltip("Background of part Informations.")]
    [SerializeField] GameObject goImgBackTxtInformationsCanvasAboutMe;
    [Tooltip("Txt Informations.")]
    [SerializeField] GameObject goTxtInformationsCanvasAboutMe;
    [Header("Canvas About Me / Text")]
    [Tooltip("Background of part Text.")]
    [SerializeField] GameObject goImgBackTxtCanvasAboutMe;
    [Tooltip("Txt Text.")]
    [SerializeField] GameObject goTxtCanvasAboutMe;
    #endregion

    #region Getters & Setters
    public RectTransform m_transformImgBackImgMeCanvasAboutMe { get { return _transformImgBackImgMeCanvasAboutMe; } }
    public RectTransform m_transformImgMeCanvasAboutMe { get { return _transformImgMeCanvasAboutMe; } }
    public RectTransform m_transformImgBackTxtInformationsCanvasAboutMe { get { return _transformImgBackTxtInformationsCanvasAboutMe; } }
    public RectTransform m_transformTxtInformationsCanvasAboutMe { get { return _transformTxtInformationsCanvasAboutMe; } }
    public RectTransform m_transformImgBackTxtCanvasAboutMe { get { return _transformImgBackTxtCanvasAboutMe; } }
    public RectTransform m_transformTxtCanvasAboutMe { get { return _transformTxtCanvasAboutMe; } }

    public Image m_imgImgBackImgMeCanvasAboutMe { get { return _imgImgBackImgMeCanvasAboutMe; } }
    public Image m_imgImgMeCanvasAboutMe { get { return _imgImgMeCanvasAboutMe; } }
    public Image m_imgImgBackTxtInformationsCanvasAboutMe { get { return _imgImgBackTxtInformationsCanvasAboutMe; } }
    public Image m_imgImgBackTxtCanvasAboutMe { get { return _imgImgBackTxtCanvasAboutMe; } }

    public TextMeshProUGUI m_tmpTxtInformationsCanvasAboutMe { get { return _tmpTxtInformationsCanvasAboutMe; } }
    public TextMeshProUGUI m_tmpTxtCanvasAboutMe { get { return _tmpTxtCanvasAboutMe; } }
    #endregion

    #region Private
    DataBaseManager _dbManager = null;
    RectTransform _transformImgBackImgMeCanvasAboutMe = null, _transformImgMeCanvasAboutMe = null, _transformImgBackTxtInformationsCanvasAboutMe = null,
    _transformTxtInformationsCanvasAboutMe = null, _transformImgBackTxtCanvasAboutMe = null, _transformTxtCanvasAboutMe = null;
    Image _imgImgBackImgMeCanvasAboutMe = null, _imgImgMeCanvasAboutMe = null, _imgImgBackTxtInformationsCanvasAboutMe = null,
     _imgImgBackTxtCanvasAboutMe = null;
    TextMeshProUGUI  _tmpTxtInformationsCanvasAboutMe = null, _tmpTxtCanvasAboutMe = null;
    #endregion

    #region System
    public void Awake()
    {
        _dbManager = GameObject.Find("DataBaseManager").GetComponent<DataBaseManager>();

        _transformImgBackImgMeCanvasAboutMe = goImgBackImgMeCanvasAboutMe.GetComponent<RectTransform>();
        _transformImgMeCanvasAboutMe = goImgMeCanvasAboutMe.GetComponent<RectTransform>();
        _transformImgBackTxtInformationsCanvasAboutMe = goImgBackTxtInformationsCanvasAboutMe.GetComponent<RectTransform>();
        _transformTxtInformationsCanvasAboutMe = goTxtInformationsCanvasAboutMe.GetComponent<RectTransform>();
        _transformImgBackTxtCanvasAboutMe = goImgBackTxtCanvasAboutMe.GetComponent<RectTransform>();
        _transformTxtCanvasAboutMe = goTxtCanvasAboutMe.GetComponent<RectTransform>();

        _imgImgBackImgMeCanvasAboutMe = goImgBackImgMeCanvasAboutMe.GetComponent<Image>();
        _imgImgMeCanvasAboutMe = goImgMeCanvasAboutMe.GetComponent<Image>();
        _imgImgBackTxtInformationsCanvasAboutMe = goImgBackTxtInformationsCanvasAboutMe.GetComponent<Image>();
        _imgImgBackTxtCanvasAboutMe = goImgBackTxtCanvasAboutMe.GetComponent<Image>();

        _tmpTxtInformationsCanvasAboutMe = goTxtInformationsCanvasAboutMe.GetComponent<TextMeshProUGUI>();
        _tmpTxtCanvasAboutMe = goTxtCanvasAboutMe.GetComponent<TextMeshProUGUI>();
    }
    #endregion
}
