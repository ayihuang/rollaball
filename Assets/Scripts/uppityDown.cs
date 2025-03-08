using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class uppityDown : MonoBehaviour
{
    public float amp; // control how high or low amplitude is
    public float freq; // control period of the wave

    public RectTransform text;
    private void Update() // every frame make box go up and down
    {
        text.localPosition = new Vector3(0, Mathf.Sin(Time.time*freq)*amp, 0); // have y value follow a sine wave
    }
}
