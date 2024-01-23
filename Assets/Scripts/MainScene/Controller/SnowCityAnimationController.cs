using UnityEngine;

public class SnowCityAnimationController : SnowCityAnimations
{
    private static readonly int IsWalk = Animator.StringToHash("IsWalk");

    //protected override void Awake()
    //{
    //    base.Awake();
    //}

    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalk, obj.magnitude > .9f);
    }
}
