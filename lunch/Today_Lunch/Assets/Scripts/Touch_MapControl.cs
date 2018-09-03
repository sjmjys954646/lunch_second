using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_MapControl : MonoBehaviour {

    public float moveSpeed;
    public Transform cam;

    Vector2 prevPos = Vector2.zero;
    float prevDistance = 0f;

    private void Start()
    {
        cam = Camera.main.transform;
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
            Vector3 vec = new Vector3(dir.x, 0, dir.y);

            cam.position -= vec * moveSpeed * Time.deltaTime;
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

            Vector3 pos = cam.position;

            if (move < 0) pos.y -= moveSpeed * Time.deltaTime;
            else if (move > 0) pos.y += moveSpeed * Time.deltaTime;

            cam.position = pos;
            prevDistance = curDistance;
        }
    }

    public void ExitDrag()
    {
        prevPos = Vector2.zero;
        prevDistance = 0f;
    }


    //void Update()
    //{
    //    if (Input.touchCount == 1)
    //    {
    //        Touch touch = Input.GetTouch(0);
    //        if (touch.phase == TouchPhase.Began)
    //        {
    //            prePos = touch.position - touch.deltaPosition;
    //        }
    //        else if (touch.phase == TouchPhase.Moved)
    //        {
    //            float cameraX = Camera.main.orthographicSize * 1080 / 1920;
    //            float cameraX2 = cameraX / 2;
    //            float cameraY = cameraX * 1920 / 1080;
    //            float cameraY2 = cameraY / 2;
                
    //            if( Camera.main.transform.position.x + cameraX2 < -1528 && Camera.main.transform.position.x - cameraX2 > -7438
    //                && Camera.main.transform.position.y + cameraY2 < 3035 && Camera.main.transform.position.y - cameraY2 > -1125)
    //            {
    //                nowPos = touch.position - touch.deltaPosition;
    //                movePos = (Vector3)(prePos - nowPos) * Speed;
    //                Camera.main.transform.Translate(movePos);
    //                prePos = touch.position - touch.deltaPosition;
    //            }
    //        }
    //    }
    //    else if (Input.touchCount == 2)
    //    {
    //        Touch touch = Input.GetTouch(0);
    //        Touch touch1 = Input.GetTouch(1);
    //        if (touch.phase == TouchPhase.Began)
    //        {
    //            dis1 = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
    //        }
    //        else if (touch.phase == TouchPhase.Moved || touch1.phase == TouchPhase.Moved)
    //        {
    //            dis2 = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);

    //            if(dis1 > dis2)
    //            {
    //                Camera.main.orthographicSize -= (dis1 - dis2);
    //            }
    //            else
    //            {
    //                Camera.main.orthographicSize += (dis2 - dis1);
    //            }
    //        }
    //    }
    //}


}
