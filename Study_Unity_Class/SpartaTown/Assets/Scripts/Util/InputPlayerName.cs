using UnityEngine;
using UnityEngine.UI;

public class InputPlayerName : MonoBehaviour
{
    public InputField playerNameInput;

    public Button joinButton;

    private void Awake()
    {
        joinButton.interactable = false;

        playerNameInput.onValueChanged.AddListener(delegate { InputName(); });
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
