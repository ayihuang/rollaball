using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class PlayerController : MonoBehaviour
{
    // declare variables
    public float speed = 0;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI livesText;
    public GameObject winTextObject;
    public GameObject NextRoundObject;
    public GameObject Heart3Object;
    public GameObject Heart2Object;
    public GameObject Heart1Object;
    public GameObject HeartPop;
    public GameObject HeartPop2;
    public GameObject HeartPop3;
    public GameObject BackgroundMusic;
    public GameObject GameOver;

    private Rigidbody rb;
    private int count;
    private int lives = 3;
    private float movementX;
    private float movementY;
    private bool isDead = false;
    private double deathTime = 0;

    private void Awake() // make sure sound effects are disabled
    {
        HeartPop.SetActive(false);
        HeartPop2.SetActive(false);
        HeartPop3.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        // set values
        rb = GetComponent<Rigidbody>();
        count = 0;
        lives = 3;

        setCountText(); // display count text    
        //setlivesLeft(); // display lives text, used for testing, commented out once hearts are added
        winTextObject.SetActive(false); // don't show win message  
        NextRoundObject.SetActive(false); // don't show next button
        GameOver.SetActive(false);
    }

    void OnMove(InputValue movementValue) // using the inputted instructions through arrow keys or wasd
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void setCountText() // count of how many cubes collected
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winTextObject.SetActive(true); // show win message
            NextRoundObject.SetActive(true); // show next button
        }
    }

    void setlivesLeft() // count of how many red cubes were hit 
    {
        livesText.text = "Lives left: " + lives.ToString(); // show lives left
    }

    void FixedUpdate()
    {
        if (!isDead)
        {
            Vector3 movement = new Vector3(movementX, 0.0f, movementY); // crete vector3 variable, assign x y z

            rb.AddForce(movement * speed); // affect movement by multipliying by speed

        }
        else
        {
            deathTime += Time.deltaTime;
            if (deathTime > 2)
            {
                SceneManager.LoadScene("Ending");
                BackgroundMusic.SetActive(false);
            }

        }

    }
    private void OnTriggerEnter(Collider other) // hitting other object
    {
        if (other.gameObject.CompareTag("PickUp")) // if object is tagged with pickUp
        {
            other.gameObject.SetActive(false); // deactivate the object
            count++;

            setCountText(); // reset count text
        }
        else if (other.gameObject.CompareTag("DontPickUp")) // if object is tagged with DontPickUp
        {
            other.gameObject.SetActive(false); // deactivate object
            lives -= 1;
            //setlivesLeft(); used for testing, commented out once hearts are added

            if (lives == 2)
            {
                Heart3Object.SetActive(false);
                HeartPop.SetActive(true);
            }
            else if (lives == 1)
            {
                Heart2Object.SetActive(false);
                HeartPop2.SetActive(true);
            }
            else if (lives == 0)
            {
                Heart1Object.SetActive(false);
                HeartPop3.SetActive(true);
                GameOver.SetActive(true);
                isDead = true;


            }

        }

    }
}