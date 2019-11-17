using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    private GameObject[] InstantiatePrefabs;

    private void Awake()
    {
        InstantiatePrefabs = new GameObject[60];
        SetPrefabs();
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

    public GameObject GetPrefabs()
    {
        for (int x = 0; x < InstantiatePrefabs.Length; x++)
        {
            GameObject prefab = InstantiatePrefabs[x];
            prefab.SetActive(true);
            return prefab;
        }

        RecyclePrefabs();
        return null;
    }

    private void RecyclePrefabs()
    {
        for (int x = 0; x < InstantiatePrefabs.Length; x++)
        {
            GameObject prefab = InstantiatePrefabs[x];
            prefab.transform.position = transform.position;
        }
    }
}
