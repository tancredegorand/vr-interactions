// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Target : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//  private void OnTriggerEnter(Collider other)
//     {
//         // Vérifier si l'objet entrant a le tag "Blade"
//         if (other.CompareTag("Blade"))
//         {
//             Debug.Log("Blade a touché la Target !");

//             // Accéder à l'objet parent qui a le tag "Axe"
//             Transform parentAxe = other.transform.parent;

//             if (parentAxe != null && parentAxe.CompareTag("Axe"))
//             {
//                 // Accéder au Rigidbody de l'objet parent (Axe)
//                 Rigidbody axeRigidbody = parentAxe.GetComponent<Rigidbody>();
//                 if (axeRigidbody != null)
//                 {
//                     // Désactiver la gravité
//                     axeRigidbody.useGravity = false;

//                     // Désactiver le mouvement
//                     axeRigidbody.velocity = Vector3.zero;
//                     axeRigidbody.angularVelocity = Vector3.zero;

//                     Debug.Log($"Mouvement de {parentAxe.name} arrêté !");
//                 }
//                 else
//                 {
//                     Debug.LogWarning($"Le Rigidbody de l'objet {parentAxe.name} est manquant !");
//                 }
//             }
//             else
//             {
//                 Debug.LogWarning("Le parent de Blade n'a pas le tag Axe !");
//             }
//         }
//     }
// }
