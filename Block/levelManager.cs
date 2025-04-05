using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    int currentSceneIndex;
    public LevelUI LevelUI;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLevelComplete()
    {
        Debug.Log("Level Completed");
        LoadNextLevel();
    }

    private void LoadNextLevel()
    {
        int nextSceneIndex = currentSceneIndex + 1;
        int totalNumberOfScenes = SceneManager.sceneCountInBuildSettings;

        if (nextSceneIndex < totalNumberOfScenes)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("You've completed all levels!");
            LevelUI.ShowGameWinUI();
        }
    }
    public void OnPlayerDeath()
    {
        LevelUI.ShowGameLoseUI();
    }

   public void RestartLevel()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMMBtn()
    {
        SceneManager.LoadScene(0);
    }
}
