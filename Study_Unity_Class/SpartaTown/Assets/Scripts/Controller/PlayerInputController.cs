using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : SpartaController
{
    //플레이어와 몬스터의 움직임 입력, 호출이 다르므로 따로 만든다.

    private Camera _camera;

    protected override void Awake()
    {
        base.Awake(); // 부모 클래스의 Awake 함수를 실행토록 함
        _camera = Camera.main; // 메인 카메라 라는 태그를 붙은 카메라를 가져온다
    }


    public void OnMove(InputValue value) // 입력이 있을때 이 함수 호출
    {
        // 아래 같은 전처리 작업을 하기 위해 부모 클래스의 CallMoveEvent 와 분리 되어 만들어진 함수
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput); // 상속받은 이벤트 액션 함수
        // 실제 움직임 처리는 여기서 하는게 아니라 PlayerMovement에서 함
        // 이곳은 이벤트 호출만 함
    }

    public void OnLook(InputValue value) // 입력이 있을때 이 함수 호출
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
        
    }
}
