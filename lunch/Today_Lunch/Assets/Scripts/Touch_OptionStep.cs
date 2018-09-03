using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Touch_OptionStep : MonoBehaviour
{
    public Text debugingX;
    public Text debugingY;
    public Text steping;

    /// <summary>
    /// 
    /// </summary>

    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;

    public GameObject coins;
    public GameObject ma;
    public GameObject checkGa;
    public CheckManager checkScr;
    public GameObject canvas;
    public Animator anim;

    public Image swipe;

    private float begin_x;
    private float begin_y;
    private Vector3 begin;
    private float end_x;
    private float end_y;

    private int step = 1;
    public bool ready = false;
    private bool temp1 = false;
    private bool temp2 = false;

    void Update()
    {

        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            begin = Input.GetTouch(0).position;
            begin_x = begin.x;
            begin_y = begin.y;

            debugingX.text = begin_x + "";
            debugingY.text = begin_y + "";
        }
        else if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {

            if (Vector2.Distance(begin, Input.GetTouch(0).position) > (Screen.width / 3))
            {
                end_x = Input.GetTouch(0).position.x;
                end_y = Input.GetTouch(0).position.y;

                debugingX.text = end_x + "";
                debugingY.text = end_y + "";

                float x = Mathf.Abs(end_x - begin_x);
                float y = Mathf.Abs(end_y - begin_y);

                if (x > y)
                {
                    if (begin_x > end_x)
                    {
                        if (step < 1)
                        {
                            step--;
                            coins.transform.GetChild(step).transform.DOMove(new Vector3(1080, coins.transform.GetChild(step).transform.position.y, 0), 0.3f).SetEase(Ease.OutQuart);
                        }

                    }
                    else if (begin_x < end_x)
                    {
                        if (step < 4)
                        {
                            step++;
                            coins.transform.GetChild(step - 1).transform.DOMove(new Vector3(0, coins.transform.GetChild(step - 1).transform.position.y, 0), 0.3f).SetEase(Ease.OutQuart);
                        }

                    }
                }
                else
                {
                    if(end_y > begin_y)
                    {
                        if (step == 4 && ready && !temp2)
                        {
                            temp2 = true;
                            StartCoroutine(StartStep());
                        }
                    }
                }

                steping.text = step + "";

            }
        }

        if (step == 4 && ready && !temp1)
        {
            swipe.gameObject.SetActive(true);
            temp1 = true;
        }
        else if (step != 4)
        {
            temp1 = false;
            swipe.gameObject.SetActive(false);
        }
    }


    void start()
    {
        StartCoroutine(SwipeMotion());
        anim = ma.GetComponent<Animator>();
        checkScr = checkGa.GetComponent<CheckManager>();
    }
    IEnumerator SwipeMotion()
    {
        while (true)
        {
            swipe.DOFade(0, 1f);
            yield return new WaitForSeconds(1);
            swipe.DOFade(255, 1f);
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator StartStep()
    {
        coins.transform.DOScale(0, 1);
        coins.transform.DOMove(new Vector3(coins.transform.position.x, 1000, coins.transform.position.z), 0.5f).SetEase(Ease.OutQuad);
        yield return new WaitForSeconds(0.5f);
        coins.transform.DOMove(new Vector3(coins.transform.position.x, 850, coins.transform.position.z), 0.5f).SetEase(Ease.InCirc);
        yield return new WaitForSeconds(0.5f);

        anim.SetBool("start", true);

        checkScr.StartRoulette();
        checkScr.Pickrandom();

        canvas.SetActive(true);
        canvas.transform.localScale = new Vector3(0, 0, 0);

        canvas.transform.DOScale(1, 0.5f);
        anim.SetBool("start", false);
    }
}
