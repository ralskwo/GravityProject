using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float gravityStrength = 100f;  // 기본 중력 세기
    public float maxDistance = 10f;  // 사건의 지평선 (중력 범위)
    public float holdThreshold = 0.5f;  // 블랙홀 중심에 고정될 거리
    private SphereCollider sphereCollider;

    private void Start()
    {
        // SphereCollider 설정 및 maxDistance 연동
        sphereCollider = GetComponent<SphereCollider>();
        if (sphereCollider != null)
        {
            sphereCollider.isTrigger = true;  // 트리거로 설정
        }

        UpdateColliderRadius();
    }

    // Update에서 Inspector 값이 변경되면 실시간 반영
    private void Update()
    {
        UpdateColliderRadius();
    }

    // Collider의 반경을 실시간으로 maxDistance와 동기화
    private void UpdateColliderRadius()
    {
        if (sphereCollider != null)
        {
            sphereCollider.radius = maxDistance;  // SphereCollider의 반경을 maxDistance로 설정
        }
    }

    // 트리거 안에 있는 오브젝트에 중력을 적용
    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 directionToCenter = transform.position - other.transform.position;
            float distance = directionToCenter.magnitude;

            if (distance < maxDistance)
            {
                if (distance > holdThreshold)
                {
                    // 거리에 따라 중력 세기 조정 (거리에 반비례)
                    float gravityEffect = gravityStrength / Mathf.Pow(distance, 2);
                    rb.AddForce(directionToCenter.normalized * gravityEffect);
                }
                else
                {
                    // 중심에 가까워지면 오브젝트를 고정
                    rb.velocity = Vector3.zero;  // 오브젝트의 속도를 0으로 설정
                    rb.position = transform.position;  // 블랙홀 중심으로 이동
                }
            }
        }
    }
}
