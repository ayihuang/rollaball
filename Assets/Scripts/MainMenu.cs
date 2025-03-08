using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame() // starts playing part of game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); // goes to scene 2 in build seetings
    }

    public void Info() // for info 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // goes to scene 1 in build seetings
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);


    }
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);

    }
}
