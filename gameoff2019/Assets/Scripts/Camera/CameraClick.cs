using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CameraClick : MonoBehaviour
{
    GraphicRaycaster graphicRaycaster;
    PointerEventData pointerEventData;
    EventSystem eventSystem;

    private void Start()
    {
        graphicRaycaster = GameObject.FindGameObjectWithTag("CanvasDialogTower").GetComponent<GraphicRaycaster>();
        eventSystem = GetComponent<EventSystem>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointerEventData = new PointerEventData(eventSystem);
            pointerEventData.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            graphicRaycaster.Raycast(pointerEventData, results);
            if (results.Count <= 0)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit[] hitsInfo = Physics.RaycastAll(ray, Mathf.Infinity);
                for (int x = 0; x < hitsInfo.Length; x++)
                {
                    RaycastHit hit = hitsInfo[x];
                    switch (hit.transform.tag)
                    {
                        case "BaseTower":
                            hit.transform.GetComponent<BaseSelection>().Select();
                            break;
                    }
                }
            }
        }
    }
}
