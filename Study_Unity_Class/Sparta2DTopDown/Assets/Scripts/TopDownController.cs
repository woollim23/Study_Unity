using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Vector2를 인자로 받는 함수
    public event Action<Vector2> OnLookEvent; // Action은 무조건 void만 반환


    public void CallMoveEvent(Vector2 direction)
    {// move 이벤트가 발생했을 때 Invoke 하는 함수
        OnMoveEvent?.Invoke(direction); // ?. 없으면 말고, 있으면 실행한다
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
