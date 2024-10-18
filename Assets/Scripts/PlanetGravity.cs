using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public Transform planetCenter;  // 행성의 중심
    public float gravityStrength = 9.81f;  // 중력의 세기
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;  // 전역 중력 비활성화
    }

    void FixedUpdate()
    {
        // 행성 중심을 향한 중력 적용
        Vector3 directionToCenter = (planetCenter.position - transform.position).normalized;
        rb.AddForce(directionToCenter * gravityStrength, ForceMode.Acceleration);
    }
}
