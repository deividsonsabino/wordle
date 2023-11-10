using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public void StartGame()
    {
        SceneManager.LoadScene("Wordle");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        ////// UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
