using UnityEngine;

/// <summary>
/// This class contains mains data(s) for the sound on the Launcher.
/// </summary>
public class SoundManager : MonoBehaviour
{
    #region Private
    ThemeManager _theme = null;
    AudioSource _audioSource = null;
    AudioClip _actualAudioClip = null;
    bool _mute = false;
    #endregion

    #region System
    public void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _theme = GameObject.Find("ThemeManager").GetComponent<ThemeManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeAudioClip();
    }
    #endregion

    #region Main Methods
    /// <summary>
    /// This function is use to Mute or not the music.
    /// </summary>
    public void AllowMusic()
    {
        _mute = !_mute;

        if (_mute)
        {
            _audioSource.Stop();
        }
        else
        {
            _audioSource.PlayOneShot(_actualAudioClip);
        }
    }

    /// <summary>
    /// This function is use to Change the AudioClip from the Theme.
    /// </summary>
    public void ChangeAudioClip()
    {
        _audioSource.Stop();
        _actualAudioClip = _theme.m_actualAudioClip;

        if (!_mute)
        {
            _audioSource.PlayOneShot(_actualAudioClip);
        }
    }
    #endregion
}
