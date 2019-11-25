using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    ControlChips controlChips;
    private void Start()
    {
        controlChips = FindObjectOfType<ControlChips>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            controlChips.Damage();
            GameObject enemy = other.gameObject;
            enemy.SetActive(false);
        }
    }
}
