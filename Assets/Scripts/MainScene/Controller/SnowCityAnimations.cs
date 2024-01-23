using UnityEngine;

public class SnowCityAnimations : MonoBehaviour
{
    protected Animator animator;
    protected SnowCityCharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<SnowCityCharacterController>();
    }
}
