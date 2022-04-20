using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scene01 : MonoBehaviour
{

    public AudioSource BGSound;
    public AudioSource ClickSound;

    public Slider[] sliders;

    public Button ButtonGame01;
    public Button ButtonGame02;
    public Button ButtonGame03;
    public Button ButtonGame04;

    public Button ButtonSETTINGS;
    public Button ButtonQUIT;
    public Button ButtonDONE;

    public GameObject settingPanle;

    // Start is called before the first frame update
    void Start()
    {
        ButtonGame01.onClick.AddListener(ButtonGame01Lis);
        ButtonGame02.onClick.AddListener(ButtonGame02Lis);
        ButtonGame03.onClick.AddListener(ButtonGame03Lis);
        ButtonGame04.onClick.AddListener(ButtonGame04Lis);

        ButtonSETTINGS.onClick.AddListener(ButtonSETTINGSLis);
        ButtonQUIT.onClick.AddListener(ButtonQUITLis);
        ButtonDONE.onClick.AddListener(ButtonDONELis);
    }

    // Update is called once per frame
    void Update()
    {

        BGSound.volume = sliders[0].value;
        ClickSound.volume = sliders[1].value;

        if (Input.GetMouseButtonDown(0))
        {
            ClickSound.Play();
        }

    }

    public void ButtonGame01Lis()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonGame02Lis()
    {
        SceneManager.LoadScene(2);
    }
    public void ButtonGame03Lis()
    {
        SceneManager.LoadScene(3);
    }
    public void ButtonGame04Lis()
    {
        SceneManager.LoadScene(4);
    }



    public void ButtonSETTINGSLis()
    {
        settingPanle.SetActive(true);
    }

    public void ButtonQUITLis()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    public void ButtonDONELis()
    {
        settingPanle.SetActive(false);
    }


}
