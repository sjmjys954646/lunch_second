using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_MapControl : MonoBehaviour
{
    public GameObject uiBack;
    public GameObject upPos;
    public GameObject downPos;

    private bool emergy = true;

    private float moveSpeed1 = 6000f;
    private float moveSpeed2 = 4500f;
    public Transform cam;

    Vector2 prevPos = Vector2.zero;
    float prevDistance = 0f;

    private void Start()
    {
        cam = Camera.main.transform;
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {

        }
    }

    public void OnDrag()
    {
        int touchCount = Input.touchCount;

        if (touchCount == 1)
        {
            if (prevPos == Vector2.zero)
            {
                prevPos = Input.GetTouch(0).position;
                return;
            }

            Vector2 dir = (Input.GetTouch(0).position - prevPos).normalized;
            Vector3 vec = new Vector3(dir.x, dir.y, 0);

            cam.position -= vec * moveSpeed1 * Time.deltaTime;
            prevPos = Input.GetTouch(0).position;
        }
        else if (touchCount == 2)
        {
            if (prevDistance == 0)
            {
                prevDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
                return;
            }
            float curDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
            float move = prevDistance - curDistance;


            if (move < 0) Camera.main.orthographicSize -= moveSpeed2 * Time.deltaTime;
            else if (move > 0) Camera.main.orthographicSize += moveSpeed2 * Time.deltaTime;

            prevDistance = curDistance;
        }
    }

    public void ExitDrag()
    {
        prevPos = Vector2.zero;
        prevDistance = 0f;
    }

    public void WhenClick()
    {
        if (emergy) uiBack.transform.DOMove(downPos.transform.position, 1f).SetEase(Ease.OutQuart);
        else if (!emergy) uiBack.transform.DOMove(upPos.transform.position, 1f).SetEase(Ease.OutQuart);
    }
}
