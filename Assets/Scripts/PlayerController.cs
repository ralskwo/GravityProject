using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;  // 점프 힘 설정
    public int maxJumpCount = 2;  // 최대 점프 횟수 설정 (더블 점프)
    private int jumpCount;  // 현재 점프 횟수
    private bool isGrounded;  // 지면 감지
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpCount = 0;  // 점프 횟수 초기화
    }

    void Update()
    {
        // 점프 처리
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || jumpCount < maxJumpCount))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);  // Y축 속도 초기화
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);  // 점프 힘 적용
            jumpCount++;  // 점프 횟수 증가
        }
    }

    // 지면에 닿았을 때 점프 횟수 초기화
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0;  // 지면에 닿으면 점프 횟수 초기화
        }
    }

    // 지면에서 벗어났을 때
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
