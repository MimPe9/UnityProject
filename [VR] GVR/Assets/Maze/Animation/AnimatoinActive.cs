using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatoinActive : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void ActiveAnim(string nameTrigger)
    {
        anim.SetTrigger(nameTrigger);
    }
}
