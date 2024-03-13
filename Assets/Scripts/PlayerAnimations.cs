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

    bool AreKeysDown()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.W))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            Player_Animations.SetBool("BoolWalk", true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Player_Animations.SetBool("BoolWalk", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Player_Animations.SetBool("BoolWalk", false);
        }



        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W)) 
        {
            Player_Animations.SetBool("BoolRun", true);
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            Player_Animations.SetBool("BoolRun", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.W))
        {
            Player_Animations.SetBool("BoolRun", false);
        }



        if (Input.GetKeyDown(KeyCode.A))
        {
            Player_Animations.SetBool("BoolLeft", true);
            Player_Animations.SetBool("BoolRight", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Player_Animations.SetBool("BoolLeft", true);
            Player_Animations.SetBool("BoolRight", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Player_Animations.SetBool("BoolLeft", false);
        }



        if (Input.GetKeyDown(KeyCode.D))
        {
            Player_Animations.SetBool("BoolRight", true);
            Player_Animations.SetBool("BoolLeft", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player_Animations.SetBool("BoolRight", true);
            Player_Animations.SetBool("BoolLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Player_Animations.SetBool("BoolRight", false);
        }



        if (Input.GetKeyDown(KeyCode.S))
        {
            Player_Animations.SetBool("BoolWalkBackward", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Player_Animations.SetBool("BoolWalkBackward", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Player_Animations.SetBool("BoolWalkBackward", false);
        }



        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.D))
        {
            Player_Animations.SetBool("BoolRunRight", true);
            Player_Animations.SetBool("BoolRunLeft", false);
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            Player_Animations.SetBool("BoolRunRight", true);
            Player_Animations.SetBool("BoolRunLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.D))
        {
            Player_Animations.SetBool("BoolRunRight", false);
        }



        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.A))
        {
            Player_Animations.SetBool("BoolRunLeft", true);
            Player_Animations.SetBool("BoolRunRight", false);
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            Player_Animations.SetBool("BoolRunLeft", true);
            Player_Animations.SetBool("BoolRunRight", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.A))
        {
            Player_Animations.SetBool("BoolRunLeft", false);
        }



        if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.W))
        {
            Player_Animations.SetBool("DiagWalkLeft", true);
            Player_Animations.SetBool("BoolWalk", false);
            Player_Animations.SetBool("BoolLeft", false);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            Player_Animations.SetBool("DiagWalkLeft", true);
            Player_Animations.SetBool("BoolWalk", false);
            Player_Animations.SetBool("BoolLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W))
        {
            Player_Animations.SetBool("DiagWalkLeft", false);
        }



        if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.W))
        {
            Player_Animations.SetBool("DiagWalkRight", true);
            Player_Animations.SetBool("BoolWalk", false);
            Player_Animations.SetBool("BoolRight", false);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            Player_Animations.SetBool("DiagWalkRight", true);
            Player_Animations.SetBool("BoolWalk", false);
            Player_Animations.SetBool("BoolRight", false);
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
        {
            Player_Animations.SetBool("DiagWalkRight", false);
        }
    }
}