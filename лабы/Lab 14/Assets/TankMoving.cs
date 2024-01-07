using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMoving : MonoBehaviour
{
    float get_z;

    float mouse_x;
    float mouse_y;

    float Turret_rotation_y;
    float Barrel_rotation_x;

    GameObject turret;
    GameObject barrel;
    Camera mainCamera;

    AudioSource zvtank;
    bool isPlaying = false;
   

    // Use this for initialization
    void Start()
    {
        turret = GameObject.Find("tower");
        barrel = GameObject.Find("tower_2");
        mainCamera = Camera.current; 
        Cursor.lockState = CursorLockMode.Locked;
        zvtank = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        get_z = Input.GetAxis("Vertical");
        transform.Translate(0, 0, get_z / 20);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -0.25f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.25f, 0);
        }

        if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && !isPlaying)
        { zvtank.Play(); isPlaying = true; }
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 && isPlaying)
        { zvtank.Stop(); isPlaying = false; }


        mouse_x = Input.GetAxis("Mouse X");
        mouse_y = Input.GetAxis("Mouse Y");

        turret.transform.Rotate(0, mouse_x, 0);

        Turret_rotation_y += mouse_x;

        barrel.transform.localRotation = Quaternion.Euler(-mouse_y, 0, 0);

        Barrel_rotation_x += -mouse_y;
        Barrel_rotation_x = Mathf.Clamp(Barrel_rotation_x, -20f, 5f);

        turret.transform.localRotation = Quaternion.Euler(0, Turret_rotation_y, 0);
        barrel.transform.localRotation = Quaternion.Euler(Barrel_rotation_x, 0, 0);

        if (mainCamera != null)
        {
            float cameraRotationX = mainCamera.transform.localEulerAngles.x;
            cameraRotationX += mouse_y;
            mainCamera.transform.localEulerAngles = new Vector3(-cameraRotationX, mainCamera.transform.localEulerAngles.y, mainCamera.transform.localEulerAngles.z);
        }
    }
}
