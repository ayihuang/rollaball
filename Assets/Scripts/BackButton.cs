using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void Back() // attached to button click
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // move to previous scene in index
    }
}


