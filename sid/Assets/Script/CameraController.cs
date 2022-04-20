using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float speed;
    Vector3 ve;
    //Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame

    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset,ref ve, 0);
    }
}
