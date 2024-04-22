using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator DoorAnimator;

    public void Door()
    {
        DoorAnimator.SetBool("BoolDoor", true);
    }

}