using UnityEngine;

public class TalkDistance : MonoBehaviour
{
    private Transform ClosetTarget { get; set; }
    public GameObject talkUI; // Talk 버튼

    [SerializeField][Range(0f, 100f)] private float TalkRange; // 대화 활성화 거리
    private bool buttonPop; // 버튼 표기 유무

    private void Start()
    {
        TalkRange = 3f;
        buttonPop = true;
    }

    private void FixedUpdate()
    {
        ClosetTarget = GameManager.instance.PlayerTransform;
        if (ClosetTarget) // 타겟(플레이어) 객체가 있는지부터 검사
        {
            //Debug.LogError(DistanceToTarget());
            if (DistanceToTarget() < TalkRange)
            {
                talkUI.SetActive(buttonPop); 
            }
            else
            {
                talkUI.SetActive(false); // 멀어지면 버튼 없애기
            }
        }
    }

    private float DistanceToTarget()
    {
        return Vector3.Distance(transform.position, ClosetTarget.position);
    }

    public void OffTalkButton()
    {
        buttonPop = false; // 대화창 띄우는 중에는 Talk버튼 비활성화
    }

    public void ONTalkButton()
    {
        buttonPop = true; // 대화창 닫으면 중에는 Talk버튼 활성화
    }
}
