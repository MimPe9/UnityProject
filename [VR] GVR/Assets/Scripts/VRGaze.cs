using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;

    void Start()
    {
        GVROff();
    }

    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        
        if(Physics.Raycast(ray, out _hit, distanceOfRay))
        {

            if(imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport"))
            {

                _hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
                Debug.LogError("Телепорт Пашет");

            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("RotateCube") && gvrStatus)
            {
                Debug.LogError("ПАШЕТ!");
                gvrStatus = false;
            }

        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }

}
