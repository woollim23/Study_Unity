using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Vector2�� ���ڷ� �޴� �Լ�
    public event Action<Vector2> OnLookEvent; // Action�� ������ void�� ��ȯ


    public void CallMoveEvent(Vector2 direction)
    {// move �̺�Ʈ�� �߻����� �� Invoke �ϴ� �Լ�
        OnMoveEvent?.Invoke(direction); // ?. ������ ����, ������ �����Ѵ�
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
