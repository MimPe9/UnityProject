using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControll : MonoBehaviour
{

    private Animator anim;
    public GameObject cube;

    void Start()
    {
        //cube.GetComponent<BoxCollider>().enabled = false;
        anim = GetComponent<Animator>();
        //anim.SetTrigger("Start");

    }

    public void StartAnimation()
    {

        anim.SetTrigger("Start");

    }



}
