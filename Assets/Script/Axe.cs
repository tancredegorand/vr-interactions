// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Axe : MonoBehaviour
// {
//     private Rigidbody axeRigidbody;
//     private bool isTouchingTarget = false;

//     void Start()
//     {
//         axeRigidbody = GetComponent<Rigidbody>();
//     }

//     void Update()
//     {
//         if (!isTouchingTarget)
//         {
//             axeRigidbody.useGravity = true;
//         }
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Target"))
//         {
//             isTouchingTarget = true; 
//             axeRigidbody.useGravity = false;
//             axeRigidbody.velocity = Vector3.zero;
//             axeRigidbody.angularVelocity = Vector3.zero;
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.CompareTag("Target"))
//         {
//             isTouchingTarget = false;
//         }
//     }


// }