using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private static Player1 instance;

    private void Start()
    {
        instance = this;
    }

    public static Vector3 GetPosition()
    {
        return instance.transform.position;
    }

    public static void SetPosition(Vector3 position)
    {
        instance.transform.position = new Vector3(position.x, 1f, position.z);
    }
}
