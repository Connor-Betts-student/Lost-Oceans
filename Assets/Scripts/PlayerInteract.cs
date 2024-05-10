using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
               if (collider.TryGetComponent(out ObjectInteract objectInteract))
                {
                    objectInteract.Interact();
                }
                if (collider.TryGetComponent(out ObjectInteract2 objectInteract2))
                {
                    objectInteract2.Interact2();
                }
                if (collider.TryGetComponent(out EscapePod objectInteract3))
                {
                    objectInteract3.Interact3();
                }
            }
        }
    }
    public ObjectInteract GetInteractableObject() 
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out ObjectInteract objectInteract))
            {
                return objectInteract;
            }
        }
        return null;
    }
    public ObjectInteract2 GetInteractableObject2()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out ObjectInteract2 objectInteract2))
            {
                return objectInteract2;
            }
        }
        return null;
    }
    public EscapePod GetInteractableObject3()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out EscapePod objectInteract3))
            {
                return objectInteract3;
            }
        }
        return null;
    }
}
