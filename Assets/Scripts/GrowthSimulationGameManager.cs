using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthSimulationGameManager : MonoBehaviour
{
    public GameObject triggerFinal;
    public GameObject triggerFinalText;

    public float maxPollenCount = 4;
    public float currentPollenCount = 0;

    public static GrowthSimulationGameManager instance;

    private void Awake()
    {
        instance = this; 
    }

    public void HoneyPollenCollectionUpdate()
    {
        currentPollenCount += 1;

        if (currentPollenCount == maxPollenCount)
            StartCoroutine(CollectionUpdate()); 
    }

    IEnumerator CollectionUpdate()
    {
        yield return new WaitForSeconds(5);
        triggerFinal.SetActive(true);
        triggerFinalText.SetActive(true);
    }
}
