using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    void Start()
    {
        GameObject[] trashGameObjects = GameObject.FindGameObjectsWithTag("Trash");
        foreach(GameObject trashGameObject in trashGameObjects)
        {
            trashGameObject.transform.SetParent(gameObject.transform);
        }
    }
}
