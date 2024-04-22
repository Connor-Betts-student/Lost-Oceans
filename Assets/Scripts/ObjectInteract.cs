using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInteract : MonoBehaviour
{
    [SerializeField] private TMP_Text ObjectiveText;
    [SerializeField] private GameObject PowerStatusText;
    bool isPowered = false;

    public OpenDoor OpenDoor;
    public void Interact()
    {
        if (isPowered != true) 
        {
            ObjectiveText.SetText("Turn on the backup generator");
            PowerStatusText.SetActive(true);
            StartCoroutine(RemoveAfterSeconds(3, PowerStatusText));
            
        }  
        else
        {
            OpenDoor.Door();
        }

        IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
        {
            yield return new WaitForSeconds(seconds);
            obj.SetActive(false);
        }
    }
}