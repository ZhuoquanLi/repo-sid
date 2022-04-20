using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ztime : MonoBehaviour
{
    public GameObject second;

    public int second_time;
    public GameObject SCOREPANEL;
    private PlayerMove playerMove;

    void Start()
    {
        second_time = 60;
        StartCoroutine(Time());
        playerMove = GameObject.Find("ufoAnimation").GetComponent<PlayerMove>();
    }
    IEnumerator Time()
    {
        while (second_time >= 0)
        {
            second.GetComponent<Text>().text = second_time.ToString();

            yield return new WaitForSeconds(1);
            second_time--;
            if (second_time == 0)
            {
                SCOREPANEL.transform.GetChild(5).gameObject.SetActive(true);
                playerMove.ismove = false;
                print("时间到了");
            }
        }
    }
}
