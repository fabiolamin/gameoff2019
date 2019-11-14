using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBase : MonoBehaviour
{
    private GameObject toolbarBase;
    private Animator animator;
    private ConfigureBaseTowers cbt;

    private void Start()
    {
        cbt = FindObjectOfType<ConfigureBaseTowers>();
    }

    public void SetToolbarBase(GameObject goToolbarBaseTower)
    {
        toolbarBase = goToolbarBaseTower;
        animator = toolbarBase.GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        animator.SetBool("isOpen", true);
        animator.SetBool("isClose", false);
        cbt.AddTimeToolbarBase(3);
    }
}
