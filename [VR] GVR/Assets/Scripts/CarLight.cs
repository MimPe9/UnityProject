using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLight : MonoBehaviour
{
    public GameObject light;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            light.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            light.SetActive(false);
        }
    }
    /*void Start()
    {
        light = GetComponent<GameObject>();
    }
    public void Activelight()
    {
        light.SetActive(true);
    }

    void inActivelight()
    {
        light.SetActive(false);
    }
    */
}
