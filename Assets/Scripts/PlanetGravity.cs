using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public Transform planetCenter;  // �༺�� �߽�
    public float gravityStrength = 9.81f;  // �߷��� ����
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;  // ���� �߷� ��Ȱ��ȭ
    }

    void FixedUpdate()
    {
        // �༺ �߽��� ���� �߷� ����
        Vector3 directionToCenter = (planetCenter.position - transform.position).normalized;
        rb.AddForce(directionToCenter * gravityStrength, ForceMode.Acceleration);
    }
}
