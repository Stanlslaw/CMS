using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{

	public float movespeed = 0.25f; 
	public float rotspeedtank = 0.75f; 
	public float rotspeedbash = 0.5f; 
	public float speedcore = 3f;      
	public Transform bash;
	public Transform stvol; 
	public GameObject core;
	public bool canshoot = true; 
	public int life = 3;           

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Player");			
			Vector3 relativePos = other.transform.position - transform.position;
			Quaternion newrot = Quaternion.LookRotation(relativePos) * Quaternion.AngleAxis(0, Vector3.up);
			bash.rotation = Quaternion.Slerp(bash.rotation, newrot, Time.deltaTime * rotspeedbash);
			RaycastHit hit;
			if (Physics.Raycast(bash.position, bash.TransformDirection(Vector3.forward), out hit))
			{
				if ((hit.transform.tag =="Player") && canshoot) 	
				StartCoroutine(botshoot());
			}
			float distance = Vector3.Distance(other.transform.position, transform.position);
           
            if (distance > 6 && distance < 20)
			{
			
                transform.position = Vector3.Lerp(transform.position, other.transform.position, Time.deltaTime * movespeed);
                transform.rotation = Quaternion.Slerp(transform.rotation, newrot, Time.deltaTime * rotspeedtank);
            }
		}
	}

    IEnumerator botshoot()
	{
		canshoot = false;
		Vector3 forwardofstvol = stvol.transform.position + stvol.TransformDirection(Vector3.forward * 4f);
		GameObject newcore = Instantiate(core, forwardofstvol, stvol.rotation);
		yield return new WaitForSeconds(3f);
		canshoot = true;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Core")
		{
			life--;
			if (life < 1)
				Destroy(gameObject);
				
		}
	}
}
