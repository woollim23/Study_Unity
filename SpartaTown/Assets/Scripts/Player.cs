using UnityEngine;

public class Player : MonoBehaviour
{
    public RuntimeAnimatorController[] animatorControllers;
    public Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        animator.runtimeAnimatorController = animatorControllers[GameManager.instance.playerId];
    }

    public void ChangeAnimController()
    {
        animator.runtimeAnimatorController = animatorControllers[GameManager.instance.playerId];
        // 애니메이터 컨트롤러를 현재 선택된 playerId에 맞는 걸로 바꿈
    }
}

