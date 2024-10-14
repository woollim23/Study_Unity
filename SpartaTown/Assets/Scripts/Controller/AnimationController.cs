using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected SpartaController controller;

    protected virtual void Awake()
    {
        controller = GetComponent<SpartaController>();
    }
}

