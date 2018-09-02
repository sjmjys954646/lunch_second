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

    private void Awake()
    {
        Screen.SetResolution(Screen.width, Screen.width * 16 / 9, true);           
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

    public void Roulette_to_Firstoption()
    {
        Roulette_Canvas.SetActive(false);
        Firstoption_Canvas.SetActive(true);
    }

    public void Roulette_to_Secondoption()
    {
        Roulette_Canvas.SetActive(false);
        Secondoption_Canvas.SetActive(true);
    }

    public void Roulette_to_Thirdoption()
    {
        Roulette_Canvas.SetActive(false);
        Thirdoption_Canvas.SetActive(true);
    }

    public void Roulette_to_Forthtoption()
    {
        Roulette_Canvas.SetActive(false);
        Forthoption_Canvas.SetActive(true);
    }

    public void Firstoption_to_Roulette()
    {
        Firstoption_Canvas.SetActive(false);
        Roulette_Canvas.SetActive(true);
    }

    public void Secondoption_to_Roulette()
    {
        Secondoption_Canvas.SetActive(false);
        Roulette_Canvas.SetActive(true);
    }

    public void Thirdoption_to_Roulette()
    {
        Thirdoption_Canvas.SetActive(false);
        Roulette_Canvas.SetActive(true);
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

    public void Lobby_to_Book()
    {
        Lobby_Canvas.SetActive(false);
        Book_Canvas.SetActive(true);
    }  
   
}
