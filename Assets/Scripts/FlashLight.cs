using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    private Light flashLightBlub;

    void Start()
    {
        flashLightBlub = GetComponentInChildren<Light>();
    }

    public void FlashLightToggle()
    {
        flashLightBlub.enabled = !flashLightBlub.enabled;
    }

}
