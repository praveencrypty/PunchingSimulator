using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivateColliders : MonoBehaviour
{
    [SerializeField] BoxCollider LeftGlove, RightGlove;

    private void Start()
    {
        DeactivateLeftGlove();
        DeactivateRightGlove(); 
    }
    public void ActivateRightGlove()
    {
        RightGlove.enabled = true;
    }

    public void ActivateLeftGlove()
    {
        LeftGlove.enabled = true;
    }

    public void DeactivateRightGlove()
    {
        RightGlove.enabled = false;
    }

    public void DeactivateLeftGlove()
    {
        LeftGlove.enabled = false;
    }
}
