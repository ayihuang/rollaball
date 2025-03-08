using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private void Awake() // once awake
    {

        DontDestroyOnLoad(gameObject); // don't destroy game object between scenes pre: game object is active, post: object stays active

    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            gameObject.SetActive(false);
        }
    }
}
