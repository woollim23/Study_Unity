using UnityEngine;

public class Player : MonoBehaviour
{
    public RuntimeAnimatorController[] animatorControllers;
    public Animator animator;
    private string playerName;

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
    }
}

