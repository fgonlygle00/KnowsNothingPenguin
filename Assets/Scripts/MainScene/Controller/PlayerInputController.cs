using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : SnowCityCharacterController
{
    // 그냥 Camera 바로쓰면 되는거 아닌가? 라고 생각할 수 있지만
    // 그렇게하면 데이터 처리하는 데 좋지 않을 수 있다.
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    // 이것들이 아까 내가 유니티에 설정한 Input Action 관련 친구들이며
    // 매개변수로 있는것들이 해당 내가 설정한 키의 값들이 들어간다.
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }
}
