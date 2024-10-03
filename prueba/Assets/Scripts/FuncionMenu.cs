using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class FuncionMenu : MonoBehaviour
{
    public AudioSource clip;
    public void Empezar(string nombrenivel)
    {
        SceneManager.LoadScene(nombrenivel);
    }
    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void PlaySoundBoton()
    {
        clip.Play();
    }

}
