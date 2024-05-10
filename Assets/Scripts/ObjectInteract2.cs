using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectInteract2 : MonoBehaviour
{
    [SerializeField] private TMP_Text ObjectiveText;
    [SerializeField] private GameObject PowerStatusText;

    public OpenDoor OpenDoor;
    public void Interact2()
    {
        OpenDoor.Door();
        ObjectiveText.SetText("Head to the Escape Pods");
        Destroy(GameObject.Find("Door Button (1)").GetComponent<ObjectInteract>());
        StartCoroutine(RemoveAfterSeconds(3, PowerStatusText));
        PowerStatusText.SetActive(true);
        IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
        {
            yield return new WaitForSeconds(seconds);
            obj.SetActive(false);
        }
    }


}
