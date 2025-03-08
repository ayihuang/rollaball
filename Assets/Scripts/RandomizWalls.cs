using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizWalls : MonoBehaviour
{

    public GameObject wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9;
    // Start is called before the first frame update
    void Awake()
    {
        MoveWalls();
    }
    private void MoveWalls()
    {
        wall1.GetComponent<WallyWooooo>().Randomize();
        wall2.GetComponent<WallyWooooo>().Randomize();
        wall3.GetComponent<WallyWooooo>().Randomize();
        wall4.GetComponent<WallyWooooo>().Randomize();
        wall5.GetComponent<WallyWooooo>().Randomize();
        wall6.GetComponent<WallyWooooo>().Randomize();
        wall7.GetComponent<WallyWooooo>().Randomize();
        wall8.GetComponent<WallyWooooo>().Randomize();
        wall9.GetComponent<WallyWooooo>().Randomize();

        Transform W1, W2, W3, W4, W5, W6, W7, W8, W9;
        W1 = wall1.transform;
        W2 = wall2.transform;
        W3 = wall3.transform;
        W4 = wall4.transform;
        W5 = wall5.transform;
        W6 = wall6.transform;
        W7 = wall7.transform;
        W8 = wall8.transform;
        W9 = wall9.transform;
        
        if (Vector3.Distance(W1.position, W2.position) < 3f)
            wall1.SetActive(false);
        if (Vector3.Distance(W1.position, W3.position) < 3f)
            wall1.SetActive(false);
        if (Vector3.Distance(W1.position, W4.position) < 3f)
            wall1.SetActive(false);
        if (Vector3.Distance(W1.position, W5.position) < 3f)
            wall1.SetActive(false);
        if (Vector3.Distance(W1.position, W6.position) < 3f)
            wall1.SetActive(false);
        if (Vector3.Distance(W1.position, W7.position) < 3f)
            wall1.SetActive(false);
        if (Vector3.Distance(W1.position, W8.position) < 3f)
            wall1.SetActive(false);
        if (Vector3.Distance(W1.position, W9.position) < 3f)
            wall1.SetActive(false);

        if (Vector3.Distance(W2.position, W3.position) < 3f)
            wall2.SetActive(false);
        if (Vector3.Distance(W2.position, W4.position) < 3f)
            wall2.SetActive(false);
        if (Vector3.Distance(W2.position, W5.position) < 3f)
            wall2.SetActive(false);
        if (Vector3.Distance(W2.position, W6.position) < 3f)
            wall2.SetActive(false);
        if (Vector3.Distance(W2.position, W7.position) < 3f)
            wall2.SetActive(false);
        if (Vector3.Distance(W2.position, W8.position) < 3f)
            wall2.SetActive(false);
        if (Vector3.Distance(W2.position, W9.position) < 3f)
            wall2.SetActive(false);
 
        if (Vector3.Distance(W3.position, W4.position) < 3f)
            wall3.SetActive(false);
        if (Vector3.Distance(W3.position, W5.position) < 3f)
            wall3.SetActive(false);
        if (Vector3.Distance(W3.position, W6.position) < 3f)
            wall3.SetActive(false);
        if (Vector3.Distance(W3.position, W7.position) < 3f)
            wall3.SetActive(false);
        if (Vector3.Distance(W3.position, W8.position) < 3f)
            wall3.SetActive(false);
        if (Vector3.Distance(W3.position, W9.position) < 3f)
            wall3.SetActive(false);
   
        if (Vector3.Distance(W4.position, W5.position) < 3f)
            wall4.SetActive(false);
        if (Vector3.Distance(W4.position, W6.position) < 3f)
            wall4.SetActive(false);
        if (Vector3.Distance(W4.position, W7.position) < 3f)
            wall4.SetActive(false);
        if (Vector3.Distance(W4.position, W8.position) < 3f)
            wall4.SetActive(false);
        if (Vector3.Distance(W4.position, W9.position) < 3f)
            wall4.SetActive(false);
      
        if (Vector3.Distance(W5.position, W6.position) < 3f)
            wall5.SetActive(false);
        if (Vector3.Distance(W5.position, W7.position) < 3f)
            wall5.SetActive(false);
        if (Vector3.Distance(W5.position, W8.position) < 3f)
            wall5.SetActive(false);
        if (Vector3.Distance(W5.position, W9.position) < 3f)
            wall5.SetActive(false);
    
        if (Vector3.Distance(W6.position, W7.position) < 3f)
            wall6.SetActive(false);
        if (Vector3.Distance(W6.position, W8.position) < 3f)
            wall6.SetActive(false);
        if (Vector3.Distance(W6.position, W9.position) < 3f)
            wall6.SetActive(false);
      
        if (Vector3.Distance(W7.position, W8.position) < 3f)
            wall7.SetActive(false);
        if (Vector3.Distance(W7.position, W9.position) < 3f)
            wall7.SetActive(false);
  
        if (Vector3.Distance(W8.position, W9.position) < 3f)
            wall8.SetActive(false);
   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
