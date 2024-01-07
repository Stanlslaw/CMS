using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject blue;
    private void OnTriggerExit(Collider other)
    {
        blue.gameObject.GetComponent<Light>().intensity = 100;
    }
}
