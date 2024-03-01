using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingButton : MonoBehaviour
{

    public Animator Player_Animations;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Player_Animations.SetBool("Bool", true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Player_Animations.SetBool("Bool", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Player_Animations.SetBool("Bool", false);
        }
    }
}