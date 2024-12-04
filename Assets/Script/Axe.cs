// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Axe : MonoBehaviour
// {
//     // Cette méthode est appelée lorsque la Blade entre en collision avec un autre objet en mode trigger
//     private void OnTriggerEnter(Collider other)
//     {
//         // Vérifier si l'objet entrant a le tag "Target"
//         if (other.CompareTag("Target"))
//         {
//             Debug.Log("Blade a touché la Target !");

//             // Accéder à l'objet parent qui a le tag "Axe" (c'est-à-dire la hache complète)
//             Transform parentAxe = transform.parent;

//             if (parentAxe != null && parentAxe.CompareTag("Axe"))
//             {
//                 // Accéder au Rigidbody de l'objet parent (Axe)
//                 Rigidbody axeRigidbody = parentAxe.GetComponent<Rigidbody>();
//                 if (axeRigidbody != null)
//                 {
//                     // Désactiver la gravité pour que l'axe ne bouge plus
//                     axeRigidbody.useGravity = false;

//                     // Désactiver le mouvement de l'axe
//                     axeRigidbody.velocity = Vector3.zero;
//                     axeRigidbody.angularVelocity = Vector3.zero;

//                     // Désactiver la physique de la lame pour qu'elle reste plantée
//                     Rigidbody bladeRigidbody = GetComponent<Rigidbody>();
//                     if (bladeRigidbody != null)
//                     {
//                         bladeRigidbody.isKinematic = true;
//                     }

//                     Debug.Log($"Mouvement de {parentAxe.name} arrêté !");
//                 }
//                 else
//                 {
//                     Debug.LogWarning($"Le Rigidbody de l'objet {parentAxe.name} est manquant !");
//                 }
//             }
//             else
//             {
//                 Debug.LogWarning("Le parent de la Blade n'a pas le tag Axe !");
//             }
//         }
//     }
// }