using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Vector2를 인자로 받는 함수
    public event Action<Vector2> OnLookEvent; // Action은 무조건 void만 반환
    public event Action OnAttackEvent;

    protected bool IsAttacking { get; set; }

    private float timeSinceLastAttack = float.MaxValue;

    private void Update()
    {
        HandleAttckDelay();
    }

    private void HandleAttckDelay()
    {
        // TODO : MAGIC NUMBER 수정
        if(timeSinceLastAttack < 0.2f)
        {
            timeSinceLastAttack = Time.deltaTime;
        }
        else if(IsAttacking && timeSinceLastAttack >= 0.2f)
        {
            timeSinceLastAttack = 0f;
            CallAttckEvent();

        }
    }


    public void CallMoveEvent(Vector2 direction)
    {// move 이벤트가 발생했을 때 Invoke 하는 함수
        OnMoveEvent?.Invoke(direction); // ?. 없으면 말고, 있으면 실행한다
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
    private void CallAttckEvent()
    {
        OnAttackEvent?.Invoke();
    }
}
