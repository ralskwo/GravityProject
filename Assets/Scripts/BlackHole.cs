using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float gravityStrength = 100f;  // �⺻ �߷� ����
    public float maxDistance = 10f;  // ����� ���� (�߷� ����)
    public float holdThreshold = 0.5f;  // ��Ȧ �߽ɿ� ������ �Ÿ�
    private SphereCollider sphereCollider;

    private void Start()
    {
        // SphereCollider ���� �� maxDistance ����
        sphereCollider = GetComponent<SphereCollider>();
        if (sphereCollider != null)
        {
            sphereCollider.isTrigger = true;  // Ʈ���ŷ� ����
        }

        UpdateColliderRadius();
    }

    // Update���� Inspector ���� ����Ǹ� �ǽð� �ݿ�
    private void Update()
    {
        UpdateColliderRadius();
    }

    // Collider�� �ݰ��� �ǽð����� maxDistance�� ����ȭ
    private void UpdateColliderRadius()
    {
        if (sphereCollider != null)
        {
            sphereCollider.radius = maxDistance;  // SphereCollider�� �ݰ��� maxDistance�� ����
        }
    }

    // Ʈ���� �ȿ� �ִ� ������Ʈ�� �߷��� ����
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
                    // �Ÿ��� ���� �߷� ���� ���� (�Ÿ��� �ݺ��)
                    float gravityEffect = gravityStrength / Mathf.Pow(distance, 2);
                    rb.AddForce(directionToCenter.normalized * gravityEffect);
                }
                else
                {
                    // �߽ɿ� ��������� ������Ʈ�� ����
                    rb.velocity = Vector3.zero;  // ������Ʈ�� �ӵ��� 0���� ����
                    rb.position = transform.position;  // ��Ȧ �߽����� �̵�
                }
            }
        }
    }
}
