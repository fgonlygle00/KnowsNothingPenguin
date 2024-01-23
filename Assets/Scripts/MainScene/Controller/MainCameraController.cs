using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public GameObject target; // ���� �ٴ� ģ��

    // ī�޶� �̵� �ӵ� = ���������� 15�� ���� �ε巯��� ����
    // �̰� �ø��� �ø����� ĳ���� �����϶� ���� �����ϰ� �������� ��������..
    [SerializeField] private float _cameraSpeed = 15f;

    public static MainCameraController instance;
    public void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        // ���� ī�޶� �̵��ؾ��� ��ġ
        Vector3 TargetPos = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
        // ī�޶� �̵� �� ���� �ε巴�� �̵��ϰ��ϴ� ����
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * _cameraSpeed);
    }
}
