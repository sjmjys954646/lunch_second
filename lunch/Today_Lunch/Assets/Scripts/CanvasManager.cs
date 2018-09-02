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

    
    public GameObject Ready;

    private bool First_Ready=false;
    private bool Second_Ready=false;
    private bool Third_Ready=false;
    private bool Forth_Ready=false;


    private void Awake()
    {
        Screen.SetResolution(Screen.width, Screen.width * 16 / 9, true);           
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
    }

    public void Home_to_Lobby()
    {
        Home_Canvas.SetActive(false);
        Lobby_Canvas.SetActive(true);
    }

    public void Lobby_to_Roulette()
    {
        Lobby_Canvas.SetActive(false);
        Roulette_Canvas.SetActive(true);
    }

    public void Firstoption()
    {
        Roulette_Canvas.SetActive(false);
        Firstoption_Canvas.SetActive(true);
    }

    public void Secondoption()
    {
        Roulette_Canvas.SetActive(false);
        Secondoption_Canvas.SetActive(true);
    }

    public void Thirdoption()
    {
        Roulette_Canvas.SetActive(false);
        Thirdoption_Canvas.SetActive(true);
    }

    public void Forthtoption()
    {
        Roulette_Canvas.SetActive(false);
        Forthoption_Canvas.SetActive(true);
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
