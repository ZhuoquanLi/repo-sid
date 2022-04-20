using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{

    public GameObject IntroduceUI;



    public void GotoScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Introduce()
    {
        IntroduceUI.SetActive(true);
    }

    public void CloseIntroduce()
    {
        IntroduceUI.SetActive(false);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }


}
