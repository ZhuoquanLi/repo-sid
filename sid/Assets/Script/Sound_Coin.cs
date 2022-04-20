using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Coin : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audio.Play();
            //print("≤•∑≈¡À");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
