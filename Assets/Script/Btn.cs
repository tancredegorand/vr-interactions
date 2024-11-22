using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Btn : MonoBehaviour
{
    // Composant XR Grab Interactable pour détecter la sélection
    private XRBaseInteractable interactable;

    void Awake()
    {
        // Récupère le composant XRBaseInteractable sur cet objet
        interactable = GetComponent<XRBaseInteractable>();

        if (interactable == null)
        {
            Debug.LogError("XRBaseInteractable est manquant sur cet objet. Ajoutez XR Grab Interactable ou un autre interactable.");
            return;
        }

        // Abonne les fonctions aux événements
        interactable.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnDestroy()
    {
        // Désabonne pour éviter des fuites de mémoire
        if (interactable != null)
        {
            interactable.selectEntered.RemoveListener(OnSelectEntered);
        }
    }

    // Fonction appelée lorsqu'un utilisateur sélectionne l'objet
    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        SetCubeYToZero();
    }

    // Met à jour la position Y à 0
    private void SetCubeYToZero()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = 0.3f;
        transform.position = newPosition;

        Debug.Log("Position Y du cube définie à 0.");
    }
}