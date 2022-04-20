using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        transform.position += transform.forward * ver * 5 * Time.deltaTime;
        transform.Rotate(transform.up * 20 * hor * Time.deltaTime, Space.Self);
    }
}
