using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;  // ���� �� ����
    public int maxJumpCount = 2;  // �ִ� ���� Ƚ�� ���� (���� ����)
    private int jumpCount;  // ���� ���� Ƚ��
    private bool isGrounded;  // ���� ����
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpCount = 0;  // ���� Ƚ�� �ʱ�ȭ
    }

    void Update()
    {
        // ���� ó��
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || jumpCount < maxJumpCount))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);  // Y�� �ӵ� �ʱ�ȭ
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);  // ���� �� ����
            jumpCount++;  // ���� Ƚ�� ����
        }
    }

    // ���鿡 ����� �� ���� Ƚ�� �ʱ�ȭ
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0;  // ���鿡 ������ ���� Ƚ�� �ʱ�ȭ
        }
    }

    // ���鿡�� ����� ��
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
