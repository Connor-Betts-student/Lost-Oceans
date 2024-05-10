using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePod : MonoBehaviour
{
    [SerializeField] private GameObject UserInterface;
    [SerializeField] private GameObject Camera;
    private bool InCapsule = false;

    public void Interact3()
    {
        if (InCapsule == false)
        {
            Show();
            Hide();
            InCapsule = true;
        }
        else
        {
            Hide2();
            Show2();
            InCapsule = false;
        }
        
    }

    private void Hide()
    {
        UserInterface.SetActive(false);
    }

    private void Show()
    {
        Camera.SetActive(true);
    }

    private void Hide2()
    {
        Camera.SetActive(false);
        
    }

    private void Show2()
    {
        UserInterface.SetActive(true);
    }
}
