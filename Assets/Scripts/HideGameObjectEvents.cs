using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGameObjectEvents : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public void Show()
    { 
        foreach (GameObject go in gameObjects) 
        {
            go.SetActive(true);
        }
    }

    public void Hide()
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(false);
        }
        GrowthSimulationGameManager.instance.HoneyPollenCollectionUpdate();
    }
}
