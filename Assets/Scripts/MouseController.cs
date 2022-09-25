using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public static MouseController Instance;
    public Vector3 CamPos;
    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        CamPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
