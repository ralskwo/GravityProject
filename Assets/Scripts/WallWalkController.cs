using UnityEngine;

public class WallWalkController : MonoBehaviour
{
    public Vector3 gravityDirection = Vector3.down;
    public float gravityStrength = 9.81f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // 기본 중력 비활성화
    }

    void FixedUpdate()
    {
        // 커스텀 중력 적용
        rb.AddForce(gravityDirection * gravityStrength, ForceMode.Acceleration);
    }
}