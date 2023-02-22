using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public GameObject Object5;
    public GameObject Object6;
    public GameObject Object7;
    public GameObject Object8;
    public GameObject ActiveObject;
    public void ChangeWheels()
    {
        ActiveObject.SetActive(true);
        Object1.SetActive(false);
        Object2.SetActive(false);
        Object3.SetActive(false);
        Object4.SetActive(false);
        Object5.SetActive(false);
        Object6.SetActive(false);
        Object7.SetActive(false);
        Object8.SetActive(false);
    }
}
