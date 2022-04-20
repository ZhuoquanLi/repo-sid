using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class airplaneController : MonoBehaviour
{

    public GameObject airplane;
    public float value;
    public Vector3 sizeChange;

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveLeft()
    {
        value = value + 0.1f;
        airplane.transform.position = new Vector3(value,0,0);
    }

    public void MoveRight()
    {
        value = value - 0.1f;
        airplane.transform.position = new Vector3(value, 0, 0);
    }

    public void RotateLeft()
    {
        airplane.transform.Rotate(0f,0f,-20f);
    }

    public void RotateRight()
    {
        airplane.transform.Rotate(0f, 0f, 20f);
    }

    public void Grow()
    {
        airplane.transform.localScale = airplane.transform.localScale + sizeChange;
    }

    public void Shrink()
    {
        airplane.transform.localScale = airplane.transform.localScale - sizeChange;
    }


    public void Resetairplane()
    {
        airplane.transform.localPosition = new Vector3(0, 0, 0);
        airplane.transform.localEulerAngles = new Vector3(0, 0, 0);
        airplane.transform.localScale = new Vector3(1, 1, 1);
    }


    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }





}
