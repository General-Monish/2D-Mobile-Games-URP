using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMUI : MonoBehaviour
{
    SoundManager soundManager;
    private const int firstLevel = 1;  // Define the first level to load
    private void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    public void Play()
    {
        soundManager.ButtonClickAudio();
        SceneManager.LoadScene(firstLevel);  // Load the first level
    }

    public void Quit()
    {
        soundManager.ButtonClickAudio();
        Application.Quit();  // Quit the game
        Debug.Log("Game quit"); // Unity doesn't quit in the editor, so we log it
    }
}
