using UnityEngine;
using System.Collections;

public class SpawnPoints : MonoBehaviour {
	public GameObject Bot;
	public GameObject Ammo;
	public int botNum = 5;
	public int ammoNum = 10;

	// Use this for initialization
	void Start () {
		/*
		for ( int i = 0; i < botNum; i++)
		{
			Instantiate(Bot, transform.position+ new Vector3(10,10,50), transform.rotation);

			Debug.Log(botNum);
		}
		for ( int i = 0; i < ammoNum; i++)
		{
			Instantiate(Ammo, transform.position+ new Vector3(50,10,50), transform.rotation);
			Debug.Log(ammoNum);
		}
	*/
	}
	
	// Update is called once per frame
	void Update () { 

	}
}
