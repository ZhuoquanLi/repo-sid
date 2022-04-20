using System.Collections;
using UnityEngine;

public class sound : MonoBehaviour
{
    AudioSource audio ;

    void Start()
    {
        audio = GetComponent<AudioSource>();
            }
    void onCollisionEnter(Collision collision) 
    { 
     if (collision.gameObject.name == "Coin"){
            audio.Play();
        }
        }
 
}
