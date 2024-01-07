using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float pushForce = 10f;
    public Camera cam1;
    public GameObject bullet;

    void Start()
    {
     
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(cam1.pixelWidth / 2, (cam1.pixelHeight / 2), 0);
            Ray ray = cam1.ScreenPointToRay(point);

            var rot = cam1.transform.rotation;
            Vector3 forwardOffset = cam1.transform.position;

            Instantiate(bullet, forwardOffset, rot);
             GameObject.Find("ShotSound").GetComponent<AudioSource>().PlayOneShot(GameObject.Find("ShotSound").GetComponent<AudioSource>().clip);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.collider.gameObject;
                Debug.Log(hitObject.CompareTag("goal"));

                if (hitObject.CompareTag("goal"))
                {
                    Rigidbody hitRigidbody = hitObject.GetComponent<Rigidbody>();
                    Vector3 pushDirection = hitObject.transform.position - transform.position;
                    hitRigidbody.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
                }
            }
        }
    }
}
