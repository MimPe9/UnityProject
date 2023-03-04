using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCarColor : MonoBehaviour
{
    public void ChangeColor(Material material)
    {
        gameObject.GetComponent<Renderer>().material = material;
    }
}
