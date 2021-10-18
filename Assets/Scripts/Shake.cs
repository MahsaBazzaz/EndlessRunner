using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    [SerializeField] private Animator CameraAnimator;
    public void ShakeHorizontal()
    {
        CameraAnimator.SetTrigger("Horizontal");
    }
    public void ShakeVertical()
    {
        CameraAnimator.SetTrigger("Vertical");
    }
}
