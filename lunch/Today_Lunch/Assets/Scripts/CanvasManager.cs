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

    public GameObject Firstwarningimage;
    public GameObject Secondwarningimage;
    public GameObject Thirdwarningimage;

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
        if(Firstoption_Canvas.transform.GetChild(1).GetComponent<Toggle>().isOn == false &&
            Firstoption_Canvas.transform.GetChild(2).GetComponent<Toggle>().isOn == false &&
            Firstoption_Canvas.transform.GetChild(3).GetComponent<Toggle>().isOn == false &&
            Firstoption_Canvas.transform.GetChild(4).GetComponent<Toggle>().isOn == false &&
            Firstoption_Canvas.transform.GetChild(5).GetComponent<Toggle>().isOn == false &&
            Firstoption_Canvas.transform.GetChild(6).GetComponent<Toggle>().isOn == false &&
            Firstoption_Canvas.transform.GetChild(7).GetComponent<Toggle>().isOn == false &&
            Firstoption_Canvas.transform.GetChild(8).GetComponent<Toggle>().isOn == false &&
            Firstoption_Canvas.transform.GetChild(9).GetComponent<Toggle>().isOn == false
            )
        {
            StartCoroutine("Firstwarning");
        }
        else
        {
            Firstoption_Canvas.SetActive(false);
            Roulette_Canvas.SetActive(true);
        }      
    }

    public void Secondoption_to_Roulette()
    {
        if (Secondoption_Canvas.transform.GetChild(1).GetComponent<Toggle>().isOn == false &&
            Secondoption_Canvas.transform.GetChild(2).GetComponent<Toggle>().isOn == false 
            )
        {
            StartCoroutine("Secondwarning");
        }
        else
        {
            Secondoption_Canvas.SetActive(false);
            Roulette_Canvas.SetActive(true);
        }
    }

    public void Thirdoption_to_Roulette()
    {
        if (Thirdoption_Canvas.transform.GetChild(1).GetComponent<Toggle>().isOn == false &&
            Thirdoption_Canvas.transform.GetChild(2).GetComponent<Toggle>().isOn == false &&
            Thirdoption_Canvas.transform.GetChild(3).GetComponent<Toggle>().isOn == false &&
            Thirdoption_Canvas.transform.GetChild(4).GetComponent<Toggle>().isOn == false
            )
        {
            StartCoroutine("Thirdwarning");
        }
        else
        {
            Thirdoption_Canvas.SetActive(false);
            Roulette_Canvas.SetActive(true);
        }       
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
    
    public IEnumerator Firstwarning()
    {
        Firstwarningimage.SetActive(true);
        yield return new WaitForSeconds(2);
        Firstwarningimage.SetActive(false);
    }

    public IEnumerator Secondwarning()
    {
        Secondwarningimage.SetActive(true);
        yield return new WaitForSeconds(2);
        Secondwarningimage.SetActive(false);
    }

    public IEnumerator Thirdwarning()
    {
        Thirdwarningimage.SetActive(true);
        yield return new WaitForSeconds(2);
        Thirdwarningimage.SetActive(false);
    }
}
