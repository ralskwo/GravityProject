using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody 컴포넌트 초기화
        rb = GetComponent<Rigidbody>();
        rb.mass = 1f;  // 질량 설정
        rb.drag = 0.1f;  // 항력 설정
        rb.angularDrag = 0.05f;  // 각 항력 설정
    }

    void Update()
    {
        // 스페이스바를 눌렀을 때 낙하 속도를 증가시키는 로직
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.down * 10f, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 충돌 발생 시 로직 처리
        Debug.Log("충돌 발생: " + collision.gameObject.name);
    }
}
