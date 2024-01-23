using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // private ������ ǥ���� �� �տ� _�� ����Ѵ� (private ������ ǥ���ϴ� ������(�����ڵ� ���̿��� ��Ű�� �����̸�?)�� �������ִٰ� �Ѵ�.)
    private SnowCityCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody; 

    // public���� �ٰ��� ���� ������ ����Ƽ �ν�����â���� ���� �Ͱ� �׷��� �̷��� �غ�����!!
    [SerializeField] private float speed = 2f; // �ӵ� ����

    private void Awake()
    {
        _controller = GetComponent<SnowCityCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;
        _rigidbody.velocity = direction;
    }
}
