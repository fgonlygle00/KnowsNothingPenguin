using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : SnowCityCharacterController
{
    // �׳� Camera �ٷξ��� �Ǵ°� �ƴѰ�? ��� ������ �� ������
    // �׷����ϸ� ������ ó���ϴ� �� ���� ���� �� �ִ�.
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    // �̰͵��� �Ʊ� ���� ����Ƽ�� ������ Input Action ���� ģ�����̸�
    // �Ű������� �ִ°͵��� �ش� ���� ������ Ű�� ������ ����.
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
