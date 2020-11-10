using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouseClicked : MonoBehaviour
{
    public CameraShake cs;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(cs.Shake(.15f, .4f));
        }
    }
}
