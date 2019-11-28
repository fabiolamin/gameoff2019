using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CameraClickBase : MonoBehaviour
{
    GraphicRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;
    EventSystem m_EventSystem;

    private void Start()
    {
        m_Raycaster = GameObject.FindGameObjectWithTag("CanvasDialogTower").GetComponent<GraphicRaycaster>();
        m_EventSystem = GetComponent<EventSystem>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_PointerEventData = new PointerEventData(m_EventSystem);
            m_PointerEventData.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            m_Raycaster.Raycast(m_PointerEventData, results);
            if (results.Count <= 0)
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
}
