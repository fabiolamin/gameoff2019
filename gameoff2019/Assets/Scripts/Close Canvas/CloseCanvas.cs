using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Close", 3f);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
