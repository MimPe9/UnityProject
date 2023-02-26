using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadlightColor : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            rend.sharedMaterial = material[1];
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            rend.sharedMaterial = material[0];
        }
    }
}
