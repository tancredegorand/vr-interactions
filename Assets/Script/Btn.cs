

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Btn : MonoBehaviour
{
    private XRSimpleInteractable interactable;


    private Vector3 prefabPosition = new Vector3(61.965f, 23.239f, 43.193f);


    [SerializeField] private GameObject axeInstantiate;


    //private Vector3 newPositionBtn = new Vector3(71.22f, 22.88f, 42.85f);
    private Vector3 newPositionBtn = new Vector3(62.685f, 23.303f, 43.486f);
    // private Vector3 originalPositionBtn = new Vector3(71.22f, 22.89f, 42.85f);
    private Vector3 originalPositionBtn = new Vector3(62.685f, 23.313f, 43.486f);

    void Start()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        
        interactable.selectEntered.AddListener(OnSelect);
        interactable.selectExited.AddListener(OnDeselect);
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
   
        transform.position = newPositionBtn;

        
        if (axeInstantiate != null)
        {
            Debug.Log("creat");
            Instantiate(axeInstantiate, prefabPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Prefab à instancier non assigné !");
        }
    }

    private void OnDeselect(SelectExitEventArgs args)
    {

        transform.position = originalPositionBtn;
    }

    void Update()
    {
        //Debug.Log(transform.position);
        
    }
}