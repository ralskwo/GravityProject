using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravityField : MonoBehaviour
{
    private Transform gravitySource;  // 중력의 중심 (예: 행성)
    public float gravityStrength = 9.81f;  // 중력 세기

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
