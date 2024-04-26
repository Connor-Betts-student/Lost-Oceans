using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInteract : MonoBehaviour
{
    [SerializeField] private TMP_Text ObjectiveText;
    [SerializeField] private GameObject PowerStatusText;
    public bool doorStatus;
    ActivatePower ActivatePower;

    public OpenDoor OpenDoor;
    public void Interact()
    {
        
        if (ActivatePower.isPowered == false)
        {
            ObjectiveText.SetText("Turn on the backup generator");
            PowerStatusText.SetActive(true);
            StartCoroutine(RemoveAfterSeconds(3, PowerStatusText));
            doorStatus = false;
        }
        else
        {
            OpenDoor.Door();
            doorStatus = true;
        }

        IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
        {
            yield return new WaitForSeconds(seconds);
            obj.SetActive(false);
        }
    }

    public void Interact2()
    {
        if (doorStatus == false)
        {
            ActivatePower.isPowered = true;
            ObjectiveText.SetText("Get to the escape pod");
            return;
        }
    }
}