using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    public float speed = 5;
    public GameObject effect;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("goal"))
        {
            collision.gameObject.GetComponent<AudioSource>().PlayOneShot(collision.gameObject.GetComponent<AudioSource>().clip);
            Debug.Log("Buum");
            Instantiate(effect, gameObject.transform);
           // collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
       
    }
}
