using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public float speed;
    public float rotspeed;

    private CharacterController playerMove;

    public Text countText;
	public Text winText;
  

	private Rigidbody rb;
	private int count;

    public GameObject UIwin;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
        UIwin.SetActive(false);
        winText.text = "";

        playerMove = gameObject.GetComponent<CharacterController>();
    }

	void FixedUpdate ()
	{
        float x = 0, y = 0, z = 0;

        if (Input.GetKey(KeyCode.W))
        {
            z += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
        }

        playerMove.Move(transform.TransformDirection(new Vector3(x, y, z)));
    }

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
    }

    void SetCountText()
	{
		countText.text =  count.ToString ();
		if (count >= 16) 
		{  
            UIwin.SetActive(true);
            winText.text = "Win";
		}
	}
}