using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody ������Ʈ �ʱ�ȭ
        rb = GetComponent<Rigidbody>();
        rb.mass = 1f;  // ���� ����
        rb.drag = 0.1f;  // �׷� ����
        rb.angularDrag = 0.05f;  // �� �׷� ����
    }

    void Update()
    {
        // �����̽��ٸ� ������ �� ���� �ӵ��� ������Ű�� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.down * 10f, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �浹 �߻� �� ���� ó��
        Debug.Log("�浹 �߻�: " + collision.gameObject.name);
    }
}
