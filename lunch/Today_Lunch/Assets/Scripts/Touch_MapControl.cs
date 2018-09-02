using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_MapControl : MonoBehaviour {

    float dis1;
    float dis2;

    public float Speed = 1;
    public Vector2 nowPos, prePos;
    public Vector3 movePos;
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                prePos = touch.position - touch.deltaPosition;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                float cameraX = Camera.main.orthographicSize * 1080 / 1920;
                float cameraX2 = cameraX / 2;
                float cameraY = cameraX * 1920 / 1080;
                float cameraY2 = cameraY / 2;
                
                if( Camera.main.transform.position.x + cameraX2 < -1528 && Camera.main.transform.position.x - cameraX2 > -7438
                    && Camera.main.transform.position.y + cameraY2 < 3035 && Camera.main.transform.position.y - cameraY2 > -1125)
                {
                    nowPos = touch.position - touch.deltaPosition;
                    movePos = (Vector3)(prePos - nowPos) * Speed;
                    Camera.main.transform.Translate(movePos);
                    prePos = touch.position - touch.deltaPosition;
                }
            }
        }
        else if (Input.touchCount == 2)
        {
            Touch touch = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);
            if (touch.phase == TouchPhase.Began)
            {
                dis1 = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
            }
            else if (touch.phase == TouchPhase.Moved || touch1.phase == TouchPhase.Moved)
            {
                dis2 = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);

                if(dis1 > dis2)
                {
                    Camera.main.orthographicSize -= (dis1 - dis2);
                }
                else
                {
                    Camera.main.orthographicSize += (dis2 - dis1);
                }
            }
        }
    }


}
