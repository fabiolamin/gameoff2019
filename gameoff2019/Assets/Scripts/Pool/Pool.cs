using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    private GameObject prefab;
    [SerializeField]
    private GameObject[] prefabToInstantiate;
    [SerializeField]
    private int amountToInstantiate = 10;
    [SerializeField]
    private GameObject allObjects;
    [SerializeField]
    private string namePool;

    public GameObject[] InstantiatePrefabs { get; private set; }

    private void Awake()
    {
        allObjects = Instantiate(allObjects, transform.position, Quaternion.identity); ;
        allObjects.name = namePool;
        InstantiatePrefabs = new GameObject[amountToInstantiate];
        SetPrefabs();
    }

    private void SetPrefabs()
    {
        for (int x = 0; x < InstantiatePrefabs.Length; x++)
        {
            int random = Random.Range(0, prefabToInstantiate.Length);
            prefab = Instantiate(prefabToInstantiate[random], transform.position, Quaternion.identity);
            prefab.transform.SetParent(allObjects.transform);
            prefab.SetActive(false);
            InstantiatePrefabs[x] = prefab;
        }
    }

    public GameObject GetPrefab(int position)
    {
        ChangePrefabStatus(position,true);
        return prefab;
    }

    public void ChangePrefabStatus(int position, bool status)
    {
        prefab = InstantiatePrefabs[position];
        prefab.SetActive(status);
    }

    public void RecyclePrefabs()
    {
        for (int x = 0; x < InstantiatePrefabs.Length; x++)
        {
            ChangePrefabStatus(x, false);
            prefab.transform.position = transform.position;
        }
    }

    public int GetInstances()
    {
        return amountToInstantiate;
    }
}
