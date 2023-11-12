using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyAnimatorController : MonoBehaviour
{
    public Animator targetAnimator;
    public void UpdateAnimatorController(RuntimeAnimatorController animation)
    {
        targetAnimator.runtimeAnimatorController = animation;
    }


}
