using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class move_controll : MonoBehaviour
{
    Transform m_transform, m_camera;
    private CharacterController controller;
    public float MoveSpeed = 20.0f;


    public int source;
    public int targetSource;
    public Text sourceText;

    public Text sourceOverText;
    public Text timerText;
    public float timer;
    public GameObject[] overGames;

    public float high;
    void Start()
    {
        m_transform = this.transform;
        m_camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        controller = GetComponent<CharacterController>();
        high = transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        sourceText.text = "source :" + source.ToString();

        timer -= Time.deltaTime;
        if (timer > 0)
        {

            timerText.text = "Time ：" + timer.ToString("F2");

        }
        else
        {
            timerText.text = "Time ：" + 0;
            sourceOverText.gameObject.SetActive(true);
            sourceOverText.text = source.ToString();
            if (source >= targetSource)
            {
                overGames[0].SetActive(true);
            }
            else
            {
                overGames[1].SetActive(true);
            }
            return;

        }


        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D)))
        {
            transform.GetComponent<Animator>().SetBool("walk", true);
            if (Input.GetKey(KeyCode.W))
            {
           
                controller.transform.eulerAngles = new Vector3(0, m_camera.transform.eulerAngles.y, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {
                controller.transform.eulerAngles = new Vector3(0, m_camera.transform.eulerAngles.y + 180f, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                controller.transform.eulerAngles = new Vector3(0, m_camera.transform.eulerAngles.y + 270f, 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                controller.transform.eulerAngles = new Vector3(0, m_camera.transform.eulerAngles.y + 90f, 0);
            }

            controller.Move(m_transform.forward * Time.deltaTime * MoveSpeed);
        }
        else
           
            transform.GetComponent<Animator>().SetBool("walk", false);
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.up * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.down * Time.deltaTime * MoveSpeed);
        }
        //if (!controller.isGrounded)
        //{
       
        //    controller.Move(new Vector3(0, -10f * Time.deltaTime, 0));
        //}

       

        if(transform.position.y< high)
        transform.position = new Vector3(transform.position.x, high, transform.position.z);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {

       
        if (hit.gameObject.tag == "Coin")
        {
            Destroy(hit.gameObject);
            source++;
            GetComponent<AudioSource>().Play();
        }
    }


    public void LoadScen(int value) {

        SceneManager.LoadScene(value);
    }
}