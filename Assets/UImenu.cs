using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UImenu : MonoBehaviour
{
    [Header("UIPages")]
    public GameObject settingsScreen;
    public GameObject creditsScreen;
    public GameObject mainScreen;

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
       // Application.LoadLevel(1);
    }
    public void SettingsButton()
    {
        mainScreen.SetActive(false);
        settingsScreen.SetActive(true);
    }

    public void set2Menu()
    {
        mainScreen.SetActive(true);
        settingsScreen.SetActive(false);
    }
    public void CreditsButton()
    {
        mainScreen.SetActive(false);
        creditsScreen.SetActive(true);
    }
    public void cre2Menu()
    {
        mainScreen.SetActive(true);
        creditsScreen.SetActive(false);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
