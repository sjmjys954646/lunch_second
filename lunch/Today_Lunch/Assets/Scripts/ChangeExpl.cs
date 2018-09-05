using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class ChangeExpl : MonoBehaviour {

    public GameObject Dogammanager;
    public Dogam Dogams;
    public int num;

    private void Start()
    {
        Dogams = Dogammanager.GetComponent<Dogam>();
    }

    public void ChangeExplanation()
    {
        if (Dogams.page == 1)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i].Storename + "\n" 
                        + "음식종류: " + Dogams.Data.Shop[i].Foodkind + "\n" 
                        + "장소: " + Dogams.Data.Shop[i].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i].Price + "\n" 
                        + "설명: " + Dogams.Data.Shop[i].Explanation;
                }
            }
        }
        if (Dogams.page == 2)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+10].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+10].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+10].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+10].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+10].Explanation;
                }
            }
        }
        if (Dogams.page == 3)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+20].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+20].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+20].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+20].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+20].Explanation;
                }
            }
        }
        if (Dogams.page == 4)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+30].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+30].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+30].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+30].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+30].Explanation;
                }
            }
        }
        if (Dogams.page == 5)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+40].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+40].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+40].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+40].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+40].Explanation;
                }
            }
        }
        if (Dogams.page == 6)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+50].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+50].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+50].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+50].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+50].Explanation;
                }
            }
        }
        if (Dogams.page == 7)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+60].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+60].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+60].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+60].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+60].Explanation;
                }
            }
        }
        if (Dogams.page == 8)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+70].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+70].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+70].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+70].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+70].Explanation;
                }
            }
        }
        if (Dogams.page == 9)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+80].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+80].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+80].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+80].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+80].Explanation;
                }
            }
        }
        if (Dogams.page == 10)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+90].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+90].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+90].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+90].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+90].Explanation;
                }
            }
        }
        if (Dogams.page == 11)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+100].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+100].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+100].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+100].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+100].Explanation;
                }
            }
        }
        if (Dogams.page == 12)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (gameObject.GetComponent<ChangeExpl>().num == i)
                {
                    Dogams.explan.text = "이름: " + Dogams.Data.Shop[i+110].Storename + "\n"
                        + "음식종류: " + Dogams.Data.Shop[i+110].Foodkind + "\n"
                        + "장소: " + Dogams.Data.Shop[i+110].Pos + "\n"
                        + "가격대: " + Dogams.Data.Shop[i+110].Price + "\n"
                        + "설명: " + Dogams.Data.Shop[i+110].Explanation;
                }
            }
        }
    }
}
