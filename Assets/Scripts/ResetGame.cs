using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public void ResetShootingExperience()
    {
        WatchController.instance.ResetShootingExperience();
        foreach (Bulet hole in FindObjectsOfType<Bulet>())
        {
            Destroy(hole.gameObject);
        }
    }
}
