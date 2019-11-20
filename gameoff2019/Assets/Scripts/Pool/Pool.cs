using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    private GameObject prefab;
    private float timerAux;
    [SerializeField]
    private float recycleInterval = 0.5f;
    [SerializeField]
    private GameObject prefabToInstantiate;
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
            prefab = Instantiate(prefabToInstantiate, transform.position, Quaternion.identity);
            prefab.SetActive(false);
            InstantiatePrefabs[x] = prefab;
        }
    }

    public GameObject GetPrefab(int position)
    {
        prefab = InstantiatePrefabs[position];
        prefab.SetActive(true);
        return prefab;
    }

    public void RecyclePrefabs()
    {
        for (int x = 0; x < InstantiatePrefabs.Length; x++)
        {
            prefab = InstantiatePrefabs[x];
            prefab.SetActive(false);
            prefab.transform.position = transform.position;
        }
    }
}
