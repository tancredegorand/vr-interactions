using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Btn : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    private Vector3 newPosition = new Vector3(71.22f, 22.88f, 42.85f);
    private Vector3 originalPosition = new Vector3(71.22f, 22.89f, 42.85f);

    void Start()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        
        // Ajoute des écouteurs pour les événements selectEntered et selectExited
        interactable.selectEntered.AddListener(OnSelect);
        interactable.selectExited.AddListener(OnDeselect);
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        // Déplace l'objet à la nouvelle position
        transform.position = newPosition;
    }

    private void OnDeselect(SelectExitEventArgs args)
    {
        // Restaure la position originale
        transform.position = originalPosition;
    }

    void Update()
    {
        Debug.Log(transform.position);
    }
}