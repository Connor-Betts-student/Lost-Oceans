using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePod : MonoBehaviour
{
    [SerializeField] private GameObject UserInterface;
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject Monster;
    private bool InCapsule = false;
    public Animator MonsterAnimator;

    public void Interact3()
    {
        if (InCapsule == false)
        {
            Show();
            Hide();
            InCapsule = true;
            MonsterAnimator.SetBool("EnemyGoUp", true);
        }
        else
        {
            Hide2();
            Show2();
            InCapsule = false;
            MonsterAnimator.SetBool("EnemyGoUp", false);
        }

    }

    private void Hide()
    {
        UserInterface.SetActive(false);
    }

    private void Show()
    {
        Camera.SetActive(true);
        Monster.SetActive(true);
    }

    private void Hide2()
    {
        Camera.SetActive(false);
        Monster.SetActive(false);

    }

    private void Show2()
    {
        UserInterface.SetActive(true);
    }
}
