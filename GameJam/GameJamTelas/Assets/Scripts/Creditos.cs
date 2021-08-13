using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Creditos : MonoBehaviour
{
    public string cenaMenu;

    public void Restart()
    {
        SceneManager.LoadScene(cenaMenu);
    }

    public void QuitGame()
    {
        //editor
        UnityEditor.EditorApplication.isPlaying = false;
        //jogo compilado
        //Applicaton.Quit();
    }
}
