using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    [SerializeField] GameObject levelPanel;
    [SerializeField] GameObject gameOverPanel;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI gameOverText;
    public int levelNumber=1;
    levelManager levelManager;
    [SerializeField] Button restartBtn;
    [SerializeField] Button menuBtn;
    // Start is called before the first frame update
    void Start()
    {
        UpdateLevelNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateLevelNumber()
    {
        levelText.text = "Level:" + levelNumber.ToString();
    }

    void HideLevelPanelUI()
    {
        levelPanel.SetActive(false);
    }

    void SetGameOverPanel(bool isActive)
    {
        gameOverPanel.SetActive(isActive);
    }

    void AddListener()
    {
        restartBtn.onClick.AddListener(RestartBtn);
        menuBtn.onClick.AddListener(MenuBtn);
    }

    public void RestartBtn()
    {
        levelManager.RestartLevel();
    }

    public void MenuBtn()
    {
        levelManager.LoadMMBtn();
    }

    public void ShowGameWinUI()
    {
        SetGameOverPanel(true);
        gameOverText.text = "Game Completed!!";
        gameOverText.color = Color.green;
        HideLevelPanelUI();
    }

    public void ShowGameLoseUI()
    {
        SetGameOverPanel(true);
        gameOverText.text = "Game Over!!";
        gameOverText.color = Color.red;
        HideLevelPanelUI();
    }
}
