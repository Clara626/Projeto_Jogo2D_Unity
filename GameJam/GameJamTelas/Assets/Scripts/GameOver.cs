using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public string cenaMenu;
    public string cenaCredits;
    
    public void Restart()
    {
        SceneManager.LoadScene(cenaMenu);
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
