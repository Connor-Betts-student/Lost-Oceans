using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RunningButton : MonoBehaviour
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
            Player_Animations.SetBool("BoolWalking", true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Player_Animations.SetBool("BoolWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Player_Animations.SetBool("BoolWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Player_Animations.SetBool("BoolRunning", true);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Player_Animations.SetBool("BoolRunning", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Player_Animations.SetBool("BoolRunning", false);
        }

    }
}