using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//包括使用unity的ui和输入系统的命名空间
//using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    //为创建公共变量：玩家速度和文本ui
   
    public TextMeshProUGUI countText;
    public GameObject winTextobject;
    private int count;

    
    void Start()
    {


        count = 0;
        SetCountText();
        winTextobject.SetActive(false);

       

    }


   


    private void OnTriggerEnter(Collider other)
    {
        //如果你所相交的游戏对象带有coingold这个标签
        if (other.gameObject.CompareTag("CoinGold")) ;
        {
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();

        }
    }
    
    private void SetCountText()
    {
        countText.text = "count:" + count.ToString();

        if (count >= 12)
        {
            winTextobject.SetActive(true);
        }
    }

    public void Quit()
    {
        
    }
}
