using UnityEngine;

public class WindSystem : MonoBehaviour
{
    public Vector3 windDirection = Vector3.right;  // �ٶ��� ����
    public float windStrength = 10f;  // �ٶ��� ����
    public float changeInterval = 5f;  // �ٶ� ���� ����
    public float maxStrengthChange = 5f;  // �ٶ� ���� ���� ��

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