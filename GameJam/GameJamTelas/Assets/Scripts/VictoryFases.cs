using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryFases : MonoBehaviour
{
    public string cenaFase2;
    public string cenaFase3;

    public void Next2()
    {
        SceneManager.LoadScene(cenaFase2);
    }

    public void Next3()
    {
        SceneManager.LoadScene(cenaFase3);
    }

    public void QuitGame()
    {
        //editor
        UnityEditor.EditorApplication.isPlaying = false;
        //jogo compilado
        //Applicaton.Quit();
    }
}
