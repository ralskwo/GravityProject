using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravityField : MonoBehaviour
{
    private Transform gravitySource;  // �߷��� �߽� (��: �༺)
    public float gravityStrength = 9.81f;  // �߷� ����

    private void Start()
    {
        gravitySource = transform;
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 gravityDirection = (gravitySource.position - other.transform.position).normalized;
            rb.AddForce(gravityDirection * gravityStrength);
        }
    }
}
