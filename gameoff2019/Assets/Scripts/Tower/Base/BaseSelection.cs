using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSelection : MonoBehaviour
{
    private Animator animator;
    private ControlChangingTowers controlChangingTowers;

    private void Start()
    {
        controlChangingTowers = FindObjectOfType<ControlChangingTowers>();
    }

    public void SetToolBarBase(GameObject baseToolBar)
    {
        animator = baseToolBar.GetComponent<Animator>();
    }
    public void Select()
    {
        controlChangingTowers.SetChangeTowers(GetComponent<TowerChange>());
        animator.SetBool("isOpen", true);
        animator.SetBool("isClose", false);
    }
}
