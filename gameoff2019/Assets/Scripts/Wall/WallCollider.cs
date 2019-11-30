using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    private ControlChips controlChips;
    private void Start()
    {
        controlChips = FindObjectOfType<ControlChips>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject enemy = other.gameObject;
            controlChips.ReceiveDamage();
            enemy.SetActive(false);
        }
    }
}
