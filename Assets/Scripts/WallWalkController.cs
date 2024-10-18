using UnityEngine;

public class WallWalkController : MonoBehaviour
{
    public Vector3 gravityDirection = Vector3.down;
    public float gravityStrength = 9.81f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // �⺻ �߷� ��Ȱ��ȭ
    }

    void FixedUpdate()
    {
        // Ŀ���� �߷� ����
        rb.AddForce(gravityDirection * gravityStrength, ForceMode.Acceleration);
    }
}