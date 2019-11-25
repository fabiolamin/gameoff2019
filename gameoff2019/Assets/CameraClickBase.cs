using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClickBase : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hitsInfo = Physics.RaycastAll(ray, Mathf.Infinity);
            for (int i = 0; i < hitsInfo.Length; i++)
            {
                RaycastHit hit = hitsInfo[i];
                switch (hit.transform.tag)
                {
                    case "BaseTower":
                        hit.transform.GetComponent<SelectBase>().SelectIsBase();
                        Debug.Log("Selecionou!");
                        break;
                }
            }
        }
    }
}
