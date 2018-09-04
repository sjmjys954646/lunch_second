using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckManager : MonoBehaviour {

    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    public GameObject Forth;
    public GameObject DataBase;

    public List<Database.Info> Selectedfirst = new List<Database.Info>();
    public List<Database.Info> Selectedsecond = new List<Database.Info>();
    public List<Database.Info> Selectedthird = new List<Database.Info>();
    public List<Database.Info> Selectedforth = new List<Database.Info>();

    public int count = 0;
    public int result;
    public Text resulttext;
    public Text numbertext;
    public Text explanationtext;

    public void StartRoulette()
    {
        if (First.transform.GetChild(0).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "한식")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (First.transform.GetChild(1).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "중식")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (First.transform.GetChild(2).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "퓨전")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (First.transform.GetChild(3).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "치킨")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (First.transform.GetChild(4).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "양식")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (First.transform.GetChild(5).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "일식")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (First.transform.GetChild(6).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "분식")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (First.transform.GetChild(7).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "고깃집")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (First.transform.GetChild(8).GetComponent<Toggle>().isOn == true)
        {
            DataBase.GetComponent<Database>().Shop.ForEach(delegate (Database.Info go)
            {
                if (go.Foodkind == "후식")
                {
                    Selectedfirst.Add(go);
                }
            });
        }

        if (Second.transform.GetChild(0).GetComponent<Toggle>().isOn == true)
        {
            Selectedfirst.ForEach(delegate (Database.Info go)
            {
                if (go.Pos == "후문")
                {
                    Selectedsecond.Add(go);
                }
            });
        }

        if (Second.transform.GetChild(1).GetComponent<Toggle>().isOn == true)
        {
            Selectedfirst.ForEach(delegate (Database.Info go)
            {
                if (go.Pos == "쪽문")
                {
                    Selectedsecond.Add(go);
                }
            });
        }

        if (Third.transform.GetChild(0).GetComponent<Toggle>().isOn == true)
        {
            Selectedsecond.ForEach(delegate (Database.Info go)
            {
                if (go.Price == "하")
                {
                    Selectedthird.Add(go);
                }
            });
        }

        if (Third.transform.GetChild(0).GetComponent<Toggle>().isOn == true || Third.transform.GetChild(1).GetComponent<Toggle>().isOn == true)
        {
            Selectedsecond.ForEach(delegate (Database.Info go)
            {
                if (go.Price == "하/중")
                {
                    Selectedthird.Add(go);
                }
            });
        }

        if (Third.transform.GetChild(1).GetComponent<Toggle>().isOn == true)
        {
            Selectedsecond.ForEach(delegate (Database.Info go)
            {
                if (go.Price == "중")
                {
                    Selectedthird.Add(go);
                }
            });
        }

        if (Third.transform.GetChild(1).GetComponent<Toggle>().isOn == true || Third.transform.GetChild(2).GetComponent<Toggle>().isOn == true)
        {
            Selectedsecond.ForEach(delegate (Database.Info go)
            {
                if (go.Price == "중/상")
                {
                    Selectedthird.Add(go);
                }
            });
        }

        if (Third.transform.GetChild(2).GetComponent<Toggle>().isOn == true)
        {
            Selectedsecond.ForEach(delegate (Database.Info go)
            {
                if (go.Price == "상")
                {
                    Selectedthird.Add(go);
                }
            });
        }

        if (Third.transform.GetChild(3).GetComponent<Toggle>().isOn == true)
        {
            if (Third.transform.GetChild(0).GetComponent<Toggle>().isOn == false && Third.transform.GetChild(1).GetComponent<Toggle>().isOn == false && Third.transform.GetChild(2).GetComponent<Toggle>().isOn == false)
            {
                Selectedsecond.ForEach(delegate (Database.Info go)
                {
                    Selectedthird.Add(go);
                });
            }
        }

        if (Forth.transform.GetChild(0).GetComponent<Toggle>().isOn == true)
        {
            Selectedthird.ForEach(delegate (Database.Info go)
            {
                Selectedforth.Add(go);
            });
        }
        else
        {
            Selectedthird.ForEach(delegate (Database.Info go)
            {
                if (go.Deliever == false)
                {
                    Selectedforth.Add(go);
                }
            });
        }

        Selectedforth.ForEach(delegate (Database.Info go)
        {
            Debug.Log(go.Storename);
        });
    }
      

    public void Pickrandom()
    {
        Selectedforth.ForEach(delegate (Database.Info go)
        {
            count += 1;
        });
        Debug.Log(count);
        result = Random.Range(0, count);
        Debug.Log(result);

        numbertext.text = count + "개 음식점 중";
        resulttext.text = Selectedforth[result].Storename;
        explanationtext.text = "설명: " + Selectedforth[result].Explanation;
      
        
        //area1 - 6142 1217 -2981
        //area2 - 4398 2600
        //area3 - 4267 1348
        //area4 - 2614 2658
        //area5 - 2561 1555
        //area6 - 1185 1555
        //area7 - 1210 2683
        //area8 - 6274 2482

        if (Selectedforth[result].Area == 1)
        {
            Camera.main.transform.position = new Vector3(-6142, 1217, -2981);
        }
        if (Selectedforth[result].Area == 2)
        {
            Camera.main.transform.position = new Vector3(-4267, 1348, -2981);
        }
        if (Selectedforth[result].Area == 3)
        {
            Camera.main.transform.position = new Vector3(-4398, 2600, -2981);
        }
        if (Selectedforth[result].Area == 4)
        {
            Camera.main.transform.position = new Vector3(-2614, 2658, -2981);
        }
        if (Selectedforth[result].Area == 5)
        {
            Camera.main.transform.position = new Vector3(-2561, 1555, -2981);
        }
        if (Selectedforth[result].Area == 6)
        {
            Camera.main.transform.position = new Vector3(-1185, 1555, -2981);
        }
        if (Selectedforth[result].Area == 7)
        {
            Camera.main.transform.position = new Vector3(-1210, 2683, -2981);
        }
        if (Selectedforth[result].Area == 8)
        {
            Camera.main.transform.position = new Vector3(-6274, 2482, -2981);
        }
    }
    
    public void Pricedelete()
    {
        Third.transform.GetChild(0).GetComponent<Toggle>().isOn = false;
        Third.transform.GetChild(1).GetComponent<Toggle>().isOn = false;
        Third.transform.GetChild(2).GetComponent<Toggle>().isOn = false;
    }

}
