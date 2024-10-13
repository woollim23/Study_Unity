using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpartaMovement : MonoBehaviour
{
    // 실제로 이동이 일어날 컴포넌트

    private SpartaController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // controller랑 TopdownMovement랑 같은 게임 오브젝트 안에 있다라는 가정
        controller = GetComponent<SpartaController>(); // GetComponent는 같은 게임 오브젝트 내에서 찾음
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // 이벤트에 Move 함수 추가
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        // 실제 움직임을 적용하는 함수
        // 고정된 시간 간격으로 호출되며, 물리 연산 관련 작업에 적합
        // rigidbody 값을 바꿀 예정
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}