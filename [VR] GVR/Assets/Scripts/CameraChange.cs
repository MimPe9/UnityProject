using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject player1;
    public Camera theCamera;
    bool c1 = true;
    

    public GameObject player2;
    public Camera cam;
    bool c2 = false;
    

    void Start()
    {
        player1.SetActive(c1);
        player2.SetActive(c2);
        /*theCamera.gameObject.GetComponent<GvrEditorEmulator>().enabled = c1;
        cam.gameObject.GetComponent<GvrEditorEmulator>().enabled = c2;*/

        /*gvr1.GetComponent<GvrReticlePointer>().enabled = c1;
        gvr2.GetComponent<GvrReticlePointer>().enabled = c2;*/

        /*theCamera.gameObject.SetActive(c1);
        cam.gameObject.SetActive(c2);*/
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            c1 = !c1;  
            c2 = !c2;
            player1.SetActive(c1);
            player2.SetActive(c2);
            /*theCamera.gameObject.GetComponent<GvrEditorEmulator>().enabled = c1;
            cam.gameObject.GetComponent<GvrEditorEmulator>().enabled = c2;*/

            /*gvr1.GetComponent<GvrReticlePointer>().enabled = c1;
            gvr2.GetComponent<GvrReticlePointer>().enabled = c2;*/

            /*theCamera.gameObject.SetActive(c1);
            cam.gameObject.SetActive(c2);
            */
        }
    }
}
