using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
	public float minX;
	public float maxX;
	public float minZ;
	public float maxZ;
	public GameObject prefab;

	public new MeshRenderer renderer;

	// Start is called before the first frame update
	void Start()
	{
		renderer = GetComponent<MeshRenderer>();
		minX = renderer.bounds.min.x;
		maxX = renderer.bounds.max.x;
		minZ = renderer.bounds.min.z;
		maxZ = renderer.bounds.max.z;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (prefab == null)
			{	Debug.LogError("No prefab assigned to Bomb script!");
				
			}
			else
			{
				Vector3 position = new Vector3(25 + Random.Range(minX, maxX), 40, 10 + Random.Range(minZ, maxZ));
				Instantiate(prefab, position, Quaternion.Euler(0,0,180));
			
			}
		}
	}
}
