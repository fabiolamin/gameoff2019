using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLevelUp : MonoBehaviour
{
    [SerializeField]
    GameObject levelUp;
    [SerializeField]
    int minimumScore;
    [SerializeField]
    float factor;
    // Start is called before the first frame update
    void Start()
    {
        DisableLevelUpGameObject();
    }

    public void CheckLevelUp(int points)
    {
        if (points > minimumScore)
        {
            factor = factor * 1.25f;
            minimumScore += minimumScore;
            EnableLevelUp();
        }
    }

    public void DisableLevelUpGameObject()
    {
        levelUp.SetActive(false);
    }

    public void EnableLevelUp()
    {
        levelUp.SetActive(true);
    }

    public float GetFactor()
    {
        return factor;
    }
}
