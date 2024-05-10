using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInteract : MonoBehaviour
{
    [SerializeField] private TMP_Text ObjectiveText;
    [SerializeField] private GameObject PowerStatusText;

    public void Interact()
    {
        ObjectiveText.SetText("Turn on the backup generator");
        PowerStatusText.SetActive(true);
        StartCoroutine(RemoveAfterSeconds(3, PowerStatusText));

        IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
        {
            yield return new WaitForSeconds(seconds);
            obj.SetActive(false);
        }
    }
}