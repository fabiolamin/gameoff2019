using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLock : MonoBehaviour
{
    void Start()
    {
        Invoke("Initiate", 3f);
    }

    public void Initiate()
    {
        gameObject.SetActive(false);
    }
}
