using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigureBaseTowers : MonoBehaviour
{
    private GameObject[] bases;
    private GameObject toolbarBaseTower;
    private Animator animatorToolbarTower;
    void Start()
    {
        PressetBaseTowers();
    }

    private void PressetBaseTowers()
    {
        HideTowersInBase();

        toolbarBaseTower = GameObject.FindGameObjectWithTag("ToolbarBaseTower");
        animatorToolbarTower = toolbarBaseTower.GetComponent<Animator>();
        bases = GameObject.FindGameObjectsWithTag("BaseTower");
        foreach (GameObject go in bases)
        {
            go.GetComponent<SelectBase>().SetToolbarBase(toolbarBaseTower);
        }

    }

    private static void HideTowersInBase()
    {
        GameObject[] towersInBase = GameObject.FindGameObjectsWithTag("Tower");
        foreach (GameObject tb in towersInBase)
        {
            tb.SetActive(false);
        }
    }

    public void CloseToolbarBase()
    {
        animatorToolbarTower.SetBool("isOpen", false);
        animatorToolbarTower.SetBool("isClose", true);
    }

}
