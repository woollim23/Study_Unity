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
}

