using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    void Start()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Trash");
        foreach(GameObject go in gameObjects)
        {
            go.transform.SetParent(gameObject.transform);
        }
    }
}
