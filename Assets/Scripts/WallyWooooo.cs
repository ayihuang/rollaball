using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallyWooooo : MonoBehaviour
{
    // declare variables for vector componenets
    float x;
    float y;
    float z;
    int yRotate;

    public GameObject wallManager;
    public LayerMask wall;
    public BoxCollider boxCollider;

    Vector3 pos;

    public GameObject self;

    // Start is called before the first frame update
    public void Randomize()
    {
        // generate random values for x and y
        x = UnityEngine.Random.Range(-6, 6);
        y = 0.5f;
        z = UnityEngine.Random.Range(-6, 6);

        yRotate = UnityEngine.Random.Range(0, 360);

        pos = new Vector3(x, y, z); // make new vector
        transform.position = pos; // transform to that position
        transform.Rotate(new Vector3(0, yRotate, 0)); // rotate wall

        //Collider[] colliders = new Collider[20];
        /*
        Collider[] overlapped = Physics.OverlapBox(self.transform.position, self.transform.localScale*2f, self.transform.rotation, wall);
        Debug.Log(self.transform.position);
        Debug.Log(self);
        Debug.Log(overlapped.Length);
        //Debug.Log(count);
        foreach(Collider c in overlapped)
        {
            c.gameObject.SetActive(false);
            //Start();
            //self.SetActive(false);
            //Debug.Log("REGENERATE");
            //GeneratePos();
        }
        */
        
    }
    /*
    private void OnTriggerEnter(Collider other) // if wall is on top of another
    {

        Debug.Log("Trigger");
        if (other.gameObject.CompareTag("Wall")) // if a cube generates on top of pickup cube
        {
            Debug.Log("Detected overlap");
            wallManager.GetComponent<RandomizWalls>().MoveWalls(); // regenerate a position
        }
    }
    */
    void Update()
    {
        //pos = new Vector3(Mathf.Sin(Time.time)*(UnityEngine.Random.Range(1,7)), y, z);
        //transform.position = pos;
    }
}

