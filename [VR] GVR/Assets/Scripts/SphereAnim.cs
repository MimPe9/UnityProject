using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAnim : MonoBehaviour
{

    private Animator anim;

    void Start()
    {

        anim = GetComponent<Animator>();

    }

    public void StartGame()
    
    {

        anim.SetTrigger("Start");

    }
}
