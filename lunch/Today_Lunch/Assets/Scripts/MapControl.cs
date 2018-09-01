using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControl : MonoBehaviour {


    public float Speed;
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
                nowPos = touch.position - touch.deltaPosition;
                movePos = (Vector3)(prePos - nowPos) * Speed;
                Camera.main.transform.Translate(movePos);
                prePos = touch.position - touch.deltaPosition;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
            }
        }
    }
}
