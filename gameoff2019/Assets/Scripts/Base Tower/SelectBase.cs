using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBase : MonoBehaviour
{
    private GameObject toolbarBase;
    private Animator animator;
    private ControlChangingTowers controlChangingTowers;

    private void Start()
    {
        controlChangingTowers = FindObjectOfType<ControlChangingTowers>();
    }

    public void SetToolbarBase(GameObject goToolbarBaseTower)
    {
        toolbarBase = goToolbarBaseTower;
        animator = toolbarBase.GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        controlChangingTowers.SetChangeTowers(GetComponent<ChangeTowers>());
        animator.SetBool("isOpen", true);
        animator.SetBool("isClose", false);
    }
}
