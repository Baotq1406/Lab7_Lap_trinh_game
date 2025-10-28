using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;   
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 1 reference
    public Canvas GameMenu;

    // 1 reference
    private bool IsShowingMenu = false;

    // 1 reference
    public TMP_Text Title;

    // 1 reference
    public TMP_Text Message;

    // 1 reference
    public Button EnterButton;

    // 1 reference
    public Button RestartButton;

    // 0 references
    void Start()
    {
        GameMenu.enabled = IsShowingMenu;
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want to continue?";
        EnterButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsShowingMenu)
            {
                Time.timeScale = 1f;
                IsShowingMenu = false;
                GameMenu.enabled = IsShowingMenu;
                return;
            }

            IsShowingMenu = !IsShowingMenu;
            GameMenu.enabled = IsShowingMenu;
            Time.timeScale = 0f;
        }
    }

    public void OnRestartButtonPressed()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void OnEnterButtonPressed()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
