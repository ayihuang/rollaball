using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollingO : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime * 8); // rotate the o
    }

}

