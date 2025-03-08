using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // declare variables
    float x;
    float y;
    float z;
    Vector3 pos;

    private void Start() // called before first frame update
    {
        // generate random values for x and y
        x = Random.Range(-9, 9);
        y = 0.5f;
        z = Random.Range(-9, 9);
        pos = new Vector3(x, y, z); // make new vector
        transform.position = pos; // transform to that position
    }
    private void OnTriggerEnter(Collider other) // cubes collide 
    {
        if (other.gameObject.CompareTag("PickUp")) // if a cube generates on top of pickup cube
        {
            Start(); // regenerate a position
        }
        else if(other.gameObject.CompareTag("DontPickUp")) // if a cube generates on top of dontpickup cube
        {
            Start(); // regenerate a position
        }
        else if (other.gameObject.CompareTag("Wall")) // if cube generates on a wall
        {
            Start();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime); // rotate cube
    }

}
