using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dogam : MonoBehaviour {

    public GameObject Dataget;
    public Database Data;
    public GameObject ButtonsOb;

    public int page=1;

    public List<Text> texts = new List<Text>();
    public List<Button> buttons = new List<Button>();

    public Text Pagenum;
    public Text explan;

    private void Start()
    {
        Data = Dataget.GetComponent<Database>();
        Changetext();
    }

    private void Changetext()
    {
        if(page==1)
        {
            for(int i = 0;i<=9;i++)
            {
                if(i==9)
                {
                    texts[i].fontSize = 40;
                }
                texts[i].text = Data.Shop[i].Storename;
            }
        }
        if(page==2)
        {
            for (int i = 10; i <= 19; i++)
            {
                texts[i - 10].text = Data.Shop[i].Storename;
            }
        }
        if (page == 3)
        {
            for (int i = 20; i <= 29; i++)
            {
                texts[i - 20].text = Data.Shop[i].Storename;
            }
        }
        if (page == 4)
        {
            for (int i = 30; i <= 39; i++)
            {
                texts[i - 30].text = Data.Shop[i].Storename;
            }
        }
        if (page == 5)
        {
            for (int i = 40; i <= 49; i++)
            {
                if (i == 41 || i == 43 || i == 46 || i==47)
                {
                    texts[i-40].fontSize = 40;
                }
                texts[i - 40].text = Data.Shop[i].Storename;
            }
        }
        if (page == 6)
        {
            for (int i = 50; i <= 59; i++)
            {
                if (i == 53)
                {
                    texts[i - 50].fontSize = 40;
                }
                texts[i - 50].text = Data.Shop[i].Storename;
            }
        }
        if (page == 7)
        {
            for (int i = 60; i <= 69; i++)
            {
                if (i == 62||i==63||i==67)
                {
                    texts[i - 60].fontSize = 40;
                }
                texts[i - 60].text = Data.Shop[i].Storename;
            }
        }
        if (page == 8)
        {
            for (int i = 70; i <= 79; i++)
            {
                texts[i - 70].text = Data.Shop[i].Storename;
            }
        }
        if (page == 9)
        {
            for (int i = 80; i <= 89; i++)
            {
                texts[i - 80].text = Data.Shop[i].Storename;
            }
        }
        if (page == 10)
        {
            for (int i = 90; i <= 99; i++)
            {
                texts[i - 90].text = Data.Shop[i].Storename;
            }
        }
        if (page == 11)
        {
            for (int i = 100; i <= 109; i++)
            {
                texts[i - 100].text = Data.Shop[i].Storename;
            }
        }
        if (page == 12)
        {
            for (int i = 110; i <= 119; i++)
            {
                if(i>=114)
                {
                    texts[i - 110].text = " ";
                    continue;          
                }
                texts[i - 110].text = Data.Shop[i].Storename;
            }
        }
        if (page < 1)
            page = 1;
        if (page > 12)
            page = 12;
        Pagenum.text = "("+page+")";
    }

    public void Button_Right()
    {
        page++;
        Changetext();
    }

    public void Button_Left()
    {
        page--;
        Changetext();
    } 

}
