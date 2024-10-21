using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEvents : MonoBehaviour
{
    public Animator flower;

    public void TriggerAnimatorEvent(string value)
    {
        flower.SetTrigger(value);
    }
}
