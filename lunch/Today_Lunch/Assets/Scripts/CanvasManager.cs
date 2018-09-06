using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public GameObject Home_Canvas;
    public GameObject Lobby_Canvas;
    public GameObject Roulette_Canvas;
    public GameObject Firstoption_Canvas;
    public GameObject Secondoption_Canvas;
    public GameObject Thirdoption_Canvas;
    public GameObject Forthoption_Canvas;
    public GameObject Book_Canvas;
    public GameObject Result_Canvas;
    public GameObject MapTouch_Canvas;

    
    public GameObject Ready;
    public GameObject mapStep;
    public GameObject roulStep;

    public Image startCanvasImg;
    public Text startCanvasInfor;

    private bool First_Ready=false;
    private bool Second_Ready=false;
    private bool Third_Ready=false;
    private bool Forth_Ready=false;

    private bool lobby = true;


    private void Awake()
    {
        Screen.SetResolution(Screen.width, Screen.width * 16 / 9, true);
        Application.targetFrameRate = 30;
        QualitySettings.vSyncCount = 0;
    }

    private void Start()
    {
        StartCoroutine(StartCanvasMotion());
    }

    IEnumerator StartCanvasMotion()
    {
        Home_Canvas.SetActive(true);
        startCanvasImg.DOFade(1, 2f);
        yield return new WaitForSeconds(1.5f);
        startCanvasInfor.DOFade(1, 1.5f);
        yield return new WaitForSeconds(3f);
        Home_Canvas.SetActive(false);
        Lobby_Canvas.SetActive(true);
    }

    private void Update()
    {

        Check_isReady_First();
        Check_isReady_Second();
        Check_isReady_Third();
        Check_isReady_Forth();

        if(First_Ready == true && Second_Ready ==true && Third_Ready== true && Forth_Ready == true)
        {
            Ready.GetComponent<Touch_OptionStep>().ready = true;
        }

        if(lobby && Input.GetKey(KeyCode.Escape))
        {

        }
    }


    public void Result_to_Map()
    {
        Result_Canvas.SetActive(false);
        mapStep.SetActive(true);
    }

    public void Lobby_to_Roulette()
    {
        Lobby_Canvas.SetActive(false);
        Roulette_Canvas.SetActive(true);
        roulStep.SetActive(true);
    }

    public void Lobby_to_Map()
    {
        Lobby_Canvas.SetActive(false);
        mapStep.SetActive(true);
        MapTouch_Canvas.SetActive(true);
    }

    public void Lobby_to_Exit()
    {
        Application.Quit();
    }

    public void Check_isReady_First()
    {
        if(Firstoption_Canvas.transform.GetChild(0).GetComponent<Toggle>().isOn == true ||
            Firstoption_Canvas.transform.GetChild(1).GetComponent<Toggle>().isOn == true ||
            Firstoption_Canvas.transform.GetChild(2).GetComponent<Toggle>().isOn == true ||
            Firstoption_Canvas.transform.GetChild(3).GetComponent<Toggle>().isOn == true ||
            Firstoption_Canvas.transform.GetChild(4).GetComponent<Toggle>().isOn == true ||
            Firstoption_Canvas.transform.GetChild(5).GetComponent<Toggle>().isOn == true ||
            Firstoption_Canvas.transform.GetChild(6).GetComponent<Toggle>().isOn == true ||
            Firstoption_Canvas.transform.GetChild(7).GetComponent<Toggle>().isOn == true ||
            Firstoption_Canvas.transform.GetChild(8).GetComponent<Toggle>().isOn == true     
            )
        {
            First_Ready = true;
        }

    }

    public void Check_isReady_Second()
    {
        if(Secondoption_Canvas.transform.GetChild(0).GetComponent<Toggle>().isOn == true||
           Secondoption_Canvas.transform.GetChild(1).GetComponent<Toggle>().isOn == true 
           )
        {
            Second_Ready = true;
        }
    }

    public void Check_isReady_Third()
    {
        if(Thirdoption_Canvas.transform.GetChild(0).GetComponent<Toggle>().isOn == true||
           Thirdoption_Canvas.transform.GetChild(1).GetComponent<Toggle>().isOn == true ||
           Thirdoption_Canvas.transform.GetChild(2).GetComponent<Toggle>().isOn == true ||
           Thirdoption_Canvas.transform.GetChild(3).GetComponent<Toggle>().isOn == true 
            )
        {
            Third_Ready = true;
        }
    }

    public void Check_isReady_Forth()
    {
        Forth_Ready = true;
    }

    public void Forthoption_to_Roulette()
    {
        Forthoption_Canvas.SetActive(false);
        Roulette_Canvas.SetActive(true);
    }

    public void Roulette_to_Result()
    {
        Roulette_Canvas.SetActive(false);
        Result_Canvas.SetActive(true);
    } 
   
}
