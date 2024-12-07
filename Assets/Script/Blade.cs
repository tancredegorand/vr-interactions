using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Rigidbody axeRigidbody; 
    private bool isTouchingTarget = false;

    void Start()
    {
        axeRigidbody = GetComponentInParent<Rigidbody>();
    }

    void Update()
    {
        if (!isTouchingTarget)
        {
            axeRigidbody.useGravity = true;
            isTouchingTarget = false; 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            isTouchingTarget = true;
            axeRigidbody.useGravity = false;
            axeRigidbody.velocity = Vector3.zero;
            axeRigidbody.angularVelocity = Vector3.zero;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            isTouchingTarget = false;
        }
    }
}