using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public string cenaGame;
    public string cenaCredits;

    public void StartGame()
    {
        SceneManager.LoadScene(cenaGame);
    }

    public void Credits()
    {
        SceneManager.LoadScene(cenaCredits);
    }

    public void QuitGame()
    {
        //editor
        UnityEditor.EditorApplication.isPlaying = false;
        //jogo compilado
        //Applicaton.Quit();
    }
}
