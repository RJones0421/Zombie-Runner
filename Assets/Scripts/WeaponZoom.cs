using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 30f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = 1f;

    [SerializeField] RigidbodyFirstPersonController player = null;
    [SerializeField] Camera FPCamera = null;
    bool isZoomedIn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Zoom();
        }
    }

    private void OnDisable()
    {
        ZoomOut();
    }

    private void Zoom()
    {
        if (isZoomedIn)
        {
            ZoomOut();
        }
        else
        {
            ZoomIn();
        }

        isZoomedIn = !isZoomedIn;
    }

    private void ZoomIn()
    {
        FPCamera.fieldOfView = zoomedInFOV;
        player.mouseLook.XSensitivity = zoomedInSensitivity;
        player.mouseLook.YSensitivity = zoomedInSensitivity;
    }

    private void ZoomOut()
    {
        FPCamera.fieldOfView = zoomedOutFOV;
        player.mouseLook.XSensitivity = zoomedOutSensitivity;
        player.mouseLook.YSensitivity = zoomedOutSensitivity;
    }
}
