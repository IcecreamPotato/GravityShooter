﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GUIMenuManager : MonoBehaviour
{
    /// <summary>
    /// Checks to see if the platform is build in WebGL.
    /// </summary>
    void Awake()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            GUIManager.instance.Activate("UIQuitButton", false);
        }
    }

    /// <summary>
    /// Loads Main Menu scene
    /// </summary>
    public void MainMenu()
    {
        GUIManager.instance.Activate("UIPauseText", false);
        GUIManager.instance.Activate("UIResumeButton", false);
        GUIManager.instance.Activate("UIQuitButton", false);
        GUIManager.instance.Activate("UIMainMenu", false);
        GUIManager.instance.Activate("UIGameOver", false);
        GUIManager.instance.Activate("UIHighScores", false);
        GUIManager.instance.Activate("UICurrentScore", false);
        LevelLoader.LoadLevel("MainMenu");
    }

    /// <summary>
    /// Loads GamePlay scene
    /// </summary>
    public void PlayButton()
    {
        GUIManager.instance.Activate("UITitle", false);
        GUIManager.instance.Activate("UIPlayButton", false);
        GUIManager.instance.Activate("UIOptionsButton", false);
        GUIManager.instance.Activate("UIQuitButton", false);
        LevelLoader.LoadLevel("GamePlay");
    }

    /// <summary>
    /// Turns off GUI elements for audio gui elements
    /// </summary>
    public void OptionButton()
    {
            GUIManager.instance.Activate("UIPlayButton", false);
            GUIManager.instance.Activate("UIOptionsButton", false);
            GUIManager.instance.Activate("UIQuitButton", false);

            GUIManager.instance.Activate("UIAudioText", true);
            GUIManager.instance.Activate("UIMusicToggle", true);
            GUIManager.instance.Activate("UIMusicToggleSlider", true);
            GUIManager.instance.Activate("UISoundEffectsToggle", true);
            GUIManager.instance.Activate("UISoundEffectsSlider", true);
            GUIManager.instance.Activate("UIBackButton", true);
    }

    /// <summary>
    /// If user wants to exit appilcation
    /// </summary>
    public void QuitButton()
    {
        Application.Quit();
    }

    /// <summary>
    /// Button just made to go backwards in Main Menu
    /// </summary>
    public void BackButton()
    {
        GUIManager.instance.Activate("UIPlayButton", true);
        GUIManager.instance.Activate("UIOptionsButton", true);
        GUIManager.instance.Activate("UIQuitButton", true);

        GUIManager.instance.Activate("UIAudioText", false);
        GUIManager.instance.Activate("UIMusicToggle", false);
        GUIManager.instance.Activate("UIMusicToggleSlider", false);
        GUIManager.instance.Activate("UISoundEffectsToggle", false);
        GUIManager.instance.Activate("UISoundEffectsSlider", false);
        GUIManager.instance.Activate("UIBackButton", false);
    }

    /// <summary>
    /// PauseButton will pause the game play
    /// Needs to be checked every frame in gameplay scene
    /// Does need timeScale = 0 or 1 to pause game
    /// </summary>
    public static void PauseButton()
    {
        GUIManager.instance.Activate("UIPauseText", true);
        GUIManager.instance.Activate("UIResumeButton", true);
        GUIManager.instance.Activate("UIQuitButton", true);
        GUIManager.instance.Activate("UIMainMenu", true);
    }

    /// <summary>
    /// To go back to the gameplay
    /// </summary>
    public void ResumeButton()
    {
        GUIManager.instance.Activate("UIPauseText", false);
        GUIManager.instance.Activate("UIResumeButton", false);
        GUIManager.instance.Activate("UIQuitButton", false);
        GUIManager.instance.Activate("UIMainMenu", false);
    }

    /// <summary>
    /// Should be called when user completed level or has died
    /// </summary>
    public void GameOver()
    {
        LevelLoader.LoadLevel("GameOver");
        GUIManager.instance.Activate("UIGameOver", true);
        GUIManager.instance.Activate("UIHighScores", true);
        GUIManager.instance.Activate("UICurrentScore", true);
        GUIManager.instance.Activate("UIQuitButton", true);
        GUIManager.instance.Activate("UIMainMenu", true);
    }
}