using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject red;
    private void OnTriggerEnter(Collider other)
    {
        red.gameObject.GetComponent<Light>().intensity = 100;
    }
}
