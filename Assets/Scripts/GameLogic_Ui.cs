using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class GameLogic_Ui : MonoBehaviour
{
    private List<GameObject> spawnedObjects = new List<GameObject>();
    [SerializeField] private TextMeshProUGUI objectCounterText;
    [SerializeField] private Transform movableObject;
    [SerializeField] private XRJoystick joystick;

    public void CreateObject(GameObject prefab)
    {
        spawnedObjects.Add(Instantiate(prefab, Camera.main.transform.position + 2 * Camera.main.transform.forward, Quaternion.identity));
        UpdateObjectCounter();
    }

    public void CleanUp()
    { 
        foreach (GameObject obj in spawnedObjects) 
        {
            Destroy(obj);
        }
        spawnedObjects.Clear();
        UpdateObjectCounter();
    }

    private void UpdateObjectCounter()
    {
        objectCounterText.text = $"{spawnedObjects.Count} objects";
    }

    private void Update()
    {
        movableObject.localPosition = 0.20f * new Vector3(joystick.value.x, 0, joystick.value.y);
    }
}
