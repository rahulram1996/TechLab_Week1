using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPoints : MonoBehaviour
{
    /// <summary>
    /// Player 
    /// </summary>
    [SerializeField] private GameObject player;
    [SerializeField] private Transform location;

    public void Teleport()
    {
        player.transform.position = location.position;
    }
}
