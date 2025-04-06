using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource BGM_Source;
    [SerializeField] AudioSource SFX_Source;
    [SerializeField] AudioClip   levelCompleteAudio;
    [SerializeField] AudioClip   gameOverAudio;
    [SerializeField] AudioClip   buttonClickAudio;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        PlayBGMMusic();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBGMMusic()
    {
        if(BGM_Source != null && BGM_Source.clip !=null && !BGM_Source.isPlaying)
        {
            BGM_Source.Play();
        }
    }

    public void LevelCompleteAudio()
    {
        if (levelCompleteAudio != null && SFX_Source != null)
        {
            SFX_Source.PlayOneShot(levelCompleteAudio);
        }
    }
    public void GameOverAudio()
    {
        if (gameOverAudio != null && SFX_Source != null)
        {
            SFX_Source.PlayOneShot(gameOverAudio);
        }
    }
    public void ButtonClickAudio()
    {
        if (buttonClickAudio != null && SFX_Source != null)
        {
            SFX_Source.PlayOneShot(buttonClickAudio);
        }
    }

    public void DestroySoundManager()
    {
        Destroy(gameObject);
    }
}
