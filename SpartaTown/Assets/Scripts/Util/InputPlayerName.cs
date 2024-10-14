using UnityEngine;
using UnityEngine.UI;

public class InputPlayerName : MonoBehaviour
{
    public InputField playerNameInput;

    public Button joinButton;

    private void Awake()
    {
        joinButton.interactable = false;
        // interactable : UI 요소(버튼, 슬라이더 등)의 상호작용 가능 여부를 제어하는 속성

        playerNameInput.onValueChanged.AddListener(delegate { InputName(); });
        // 사용자가 입력 필드에 값을 입력하거나 수정할 때마다 onValueChanged 이벤트가 발생
        // 이 이벤트에 InputName() 메서드를 연결해서, 입력이 변경될 때마다 InputName()을 호출하도록 설정함
        // AddListener : 이벤트가 발생하면 실행될 함수를 지정
    }

    public void InputName()
    {
        // InputField의 텍스트를 GameManager의 playerName에 저장
        GameManager.instance.playerName = playerNameInput.text;

        // 플레이어 이름 길이에 따라 버튼 활성화/비활성화
        if (GameManager.instance.playerName.Length >= 2 && GameManager.instance.playerName.Length <= 10)
        {
            joinButton.interactable = true;
        }
        else
        {
            joinButton.interactable = false;
        }
    }

}