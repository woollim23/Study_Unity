using UnityEngine;

public class TalkDistance : MonoBehaviour
{
    protected Transform ClosetTarget { get; private set; }
    [SerializeField][Range(0f, 100f)] private float TalkRange;
    public GameObject talkUI;
    private bool buttonPop; 

    protected void Start()
    {
        TalkRange = 3f;
        buttonPop = true;
    }

    protected void FixedUpdate()
    {
        ClosetTarget = GameManager.instance.Player;
        if (ClosetTarget)
        {
            //Debug.LogError(DistanceToTarget());
            if (DistanceToTarget() < TalkRange)
            {
                talkUI.SetActive(buttonPop);
            }
            else
            {
                talkUI.SetActive(false);
            }
        }
    }

    protected float DistanceToTarget()
    {
        return Vector3.Distance(transform.position, ClosetTarget.position);
    }

    public void OffTalkButton()
    {
        buttonPop = false;
    }

    public void ONTalkButton()
    {
        buttonPop = true;
    }
}
