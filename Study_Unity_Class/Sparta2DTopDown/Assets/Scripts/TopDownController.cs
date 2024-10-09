using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Vector2�� ���ڷ� �޴� �Լ�
    public event Action<Vector2> OnLookEvent; // Action�� ������ void�� ��ȯ
    public event Action OnAttackEvent;

    protected bool IsAttacking { get; set; }

    private float timeSinceLastAttack = float.MaxValue;

    private void Update()
    {
        HandleAttckDelay();
    }

    private void HandleAttckDelay()
    {
        // TODO : MAGIC NUMBER ����
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
    {// move �̺�Ʈ�� �߻����� �� Invoke �ϴ� �Լ�
        OnMoveEvent?.Invoke(direction); // ?. ������ ����, ������ �����Ѵ�
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
