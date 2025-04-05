using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMUI : MonoBehaviour
{
    private const int firstLevel = 1;  // Define the first level to load

    public void Play()
    {
        SceneManager.LoadScene(firstLevel);  // Load the first level
    }

    public void Quit()
    {
        Application.Quit();  // Quit the game
        Debug.Log("Game quit"); // Unity doesn't quit in the editor, so we log it
    }
}
