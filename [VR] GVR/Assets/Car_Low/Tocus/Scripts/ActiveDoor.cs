using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDoor : MonoBehaviour
{
    private Animator _anim;
    public bool _isOpened;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
   public void ActiveObj()
    {
        _anim.SetBool("isOpened", _isOpened);
        _isOpened = !_isOpened;
    }
}
