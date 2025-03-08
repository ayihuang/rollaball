using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public void NextRound() // attached to button click
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // move to the next scene in index
    }
}

