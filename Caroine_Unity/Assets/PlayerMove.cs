using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public GameObject Player;
    public GameObject Score;
    private Text text;
    int i = 0;
    private float rotateSpeed = 30f;
    private float movespeed = 8;

    public GameObject aa;
    public bool ismove=false;

    // Start is called before the first frame update
    void Start()
    {
        text = Score.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey(KeyCode.W))
        //{
        //    //使人物按照z轴正方向以每帧3的单位长度移动
        //    Player.transform.Translate(Vector3.back * Time.deltaTime * 3, Space.World);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    Player.transform.Translate(Vector3.left * Time.deltaTime * 3, Space.World);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    Player.transform.Translate(Vector3.forward * Time.deltaTime * 3, Space.World);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Player.transform.Translate(Vector3.right * Time.deltaTime * 3, Space.World);
        //}
        //第一种控制移动
        if (ismove == true)
        {
            float h = Input.GetAxis("Horizontal");

            float v = Input.GetAxis("Vertical");

            //朝一个方向移动 new Vector3(0, 0, v) * speed * Time.deltaTime是个向量

            transform.Translate(new Vector3(0, 0, v) * movespeed * Time.deltaTime);  //前后移动

            transform.Rotate(new Vector3(0, h, 0) * rotateSpeed * Time.deltaTime); //左右移动
        }
    }
    private void OnCollisionEnter(Collision collision) //吃掉金币
    {

        if (collision.collider.tag=="Coin") // 判断碰撞的物体是不是金币
        {

            Destroy(collision.gameObject);
            i++;
            text.text = i.ToString();

        }
    }
    public void isMovve()
    {
        ismove = true;
    }

}


