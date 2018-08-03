using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timing;
    public Text timercountdown;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timing > 0)
        {
            timing = timing - Time.deltaTime;
            timercountdown.text = timing.ToString("0");
        }
    }
}
