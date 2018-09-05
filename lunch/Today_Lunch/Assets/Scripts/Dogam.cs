using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dogam : MonoBehaviour {

    public GameObject Dataget;
    public Database Data;

    public int page=1;

    public List<Text> texts = new List<Text>();

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
    }
}
