using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public bool _clickedPlayGame;

    public void PlayGame()
    {
        Debug.Log("Playing.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        _clickedPlayGame = true;
        Debug.Log(_clickedPlayGame);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
