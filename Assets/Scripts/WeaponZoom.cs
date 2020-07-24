using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] float zoomedOutFOV = 30f;
    [SerializeField] float zoomedInFOV = 60f;

    Camera FPCamera;
    bool isZoomedIn = false;

    // Start is called before the first frame update
    void Start()
    {
        FPCamera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Zoom();
        }
    }

    private void Zoom()
    {
        isZoomedIn = !isZoomedIn;

        if (isZoomedIn)
        {
            FPCamera.fieldOfView = zoomedInFOV;
        }
        else
        {
            FPCamera.fieldOfView = zoomedOutFOV;
        }
    }
}
