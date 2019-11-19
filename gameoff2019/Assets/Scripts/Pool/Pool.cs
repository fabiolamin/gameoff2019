using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    private float timerAux;
    [SerializeField]
    private float recycleInterval = 0.5f;
    [SerializeField]
    private GameObject prefab;
    public GameObject[] InstantiatePrefabs { get; private set; }

    private void Awake()
    {
        InstantiatePrefabs = new GameObject[10];
        SetPrefabs();

        timerAux = recycleInterval;
    }

    private void SetPrefabs()
    {
        for (int x = 0; x < InstantiatePrefabs.Length; x++)
        {
            GameObject newPrefab = Instantiate(prefab, transform.position, Quaternion.identity);
            newPrefab.SetActive(false);
            InstantiatePrefabs[x] = newPrefab;
        }
    }

    public void RecyclePrefab(GameObject prefab)
    {
        recycleInterval -= Time.deltaTime;
        if (recycleInterval <= 0)
        {
            prefab.transform.position = transform.position;
            prefab.SetActive(false);
            recycleInterval = timerAux;
        }
    }
}
