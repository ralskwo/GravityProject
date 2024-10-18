using UnityEngine;

public class WindSystem : MonoBehaviour
{
    public Vector3 windDirection = Vector3.right;  // 바람의 방향
    public float windStrength = 10f;  // 바람의 세기
    public float changeInterval = 5f;  // 바람 변경 간격
    public float maxStrengthChange = 5f;  // 바람 세기 변경 폭

    void Start()
    {
        InvokeRepeating("ChangeWind", changeInterval, changeInterval);
    }

    void ChangeWind()
    {
        windStrength += Random.Range(-maxStrengthChange, maxStrengthChange);
        windStrength = Mathf.Clamp(windStrength, 0f, 20f);
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(windDirection.normalized * windStrength);
        }
    }
}