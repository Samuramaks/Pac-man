using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Game : MonoBehaviour
{
    public GameObject layout1, layout2;
    public AudioMixerGroup mixer;
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Options()
    {
        layout1.gameObject.SetActive(true);
        layout2.gameObject.SetActive(false);
    }
    public void ComeBackToMenu()
    {
        layout1.gameObject.SetActive(false);
        layout2.gameObject.SetActive(true);
    }
    public void ToggleMusic(bool enabled)
    {
        if (enabled)
        {
            mixer.audioMixer.SetFloat("MasterVolume", 0);
        }
        else
        {
            mixer.audioMixer.SetFloat("MasterVolume", -80);
        }            
    }
}
