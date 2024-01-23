using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // private 변수를 표시할 때 앞에 _를 사용한다 (private 변수를 표시하는 컨벤션(개발자들 사이에서 지키는 변수이름?)을 따르고있다고 한다.)
    private SnowCityCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody; 

    // public으로 다같이 쓰긴 싫은데 유니티 인스펙터창에는 보고 싶고 그럴땐 이렇게 해보세요!!
    [SerializeField] private float speed = 2f; // 속도 조절

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
