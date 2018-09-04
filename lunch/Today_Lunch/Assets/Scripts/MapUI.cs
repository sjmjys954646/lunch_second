using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapUI : MonoBehaviour {

    public GameObject DataOb;
    public CheckManager Data;

    private string result;
    private int resultnum;
    private int num;

    private void Start()
    {
        Data = DataOb.GetComponent<CheckManager>();
    }

    public void GetData()
    {
        //result 가게이름 따로 Data.resulttext로 불러오기 가능
        resultnum = Data.result;
        result = Data.Selectedforth[resultnum].Storename;
    }

    public void MapmoveButton()
    {
        if (Data.Selectedforth[resultnum].Area == 1)
        {
            Camera.main.transform.position = new Vector3(-6142, 1217, -2981);
        }
        if (Data.Selectedforth[resultnum].Area == 2)
        {
            Camera.main.transform.position = new Vector3(-4267, 1348, -2981);
        }
        if (Data.Selectedforth[resultnum].Area == 3)
        {
            Camera.main.transform.position = new Vector3(-4398, 2600, -2981);
        }
        if (Data.Selectedforth[resultnum].Area == 4)
        {
            Camera.main.transform.position = new Vector3(-2614, 2658, -2981);
        }
        if (Data.Selectedforth[resultnum].Area == 5)
        {
            Camera.main.transform.position = new Vector3(-2561, 1555, -2981);
        }
        if (Data.Selectedforth[resultnum].Area == 6)
        {
            Camera.main.transform.position = new Vector3(-1185, 1555, -2981);
        }
        if (Data.Selectedforth[resultnum].Area == 7)
        {
            Camera.main.transform.position = new Vector3(-1210, 2683, -2981);
        }
        if (Data.Selectedforth[resultnum].Area == 8)
        {
            Camera.main.transform.position = new Vector3(-6274, 2482, -2981);
        }
    }



}
