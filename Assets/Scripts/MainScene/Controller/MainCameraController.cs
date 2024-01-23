using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public GameObject target; // 따라 다닐 친구

    // 카메라 이동 속도 = 개인적으로 15가 가장 부드러운것 같음
    // 이거 올리면 올릴수록 캐릭터 움직일때 마다 딱딱하게 움직여서 어지러움..
    [SerializeField] private float _cameraSpeed = 15f;

    public static MainCameraController instance;
    public void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        // 현재 카메라가 이동해야할 위치
        Vector3 TargetPos = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
        // 카메라 이동 및 좀더 부드럽게 이동하게하는 동작
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * _cameraSpeed);
    }
}
