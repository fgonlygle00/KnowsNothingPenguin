using UnityEngine;

public class PlayerAimRotation : MonoBehaviour
{
    private SnowCityCharacterController _controller;

    [SerializeField] private SpriteRenderer _characterRenderer;

    private void Awake()
    {
        _controller = GetComponent<SnowCityCharacterController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateAim(newAimDirection);
    }

    private void RotateAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        _characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
    
}
