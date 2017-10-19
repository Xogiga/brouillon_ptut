using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Spawn : MonoBehaviour {
	
	public GameObject[] vent;
	public GameObject bateau;
	public GameObject map;
	public Canvas canvas;
	public Text tquest;
	private bool jalouxtest = false;


	public void initMap()
	{
		GameObject carte = Instantiate(map, new Vector3(0,0, 0f), Quaternion.identity);
	}
	public void spawnvent()
	{
		int rng = Random.Range(4, 8);

		for (int i = 0; i < rng; i++) {
			int random = Random.Range (0, 100);
			if (jalouxtest == false) {
				if (random <= 1) {
					GameObject tocreate = vent [1];
					GameObject vents = Instantiate (tocreate, new Vector3 (Random.Range (-8, 8), Random.Range (-4, 4), 0f), Quaternion.identity);
					jalouxtest=true;
				} else {
					GameObject tocreate = vent [0];
					GameObject vents = Instantiate (tocreate, new Vector3 (Random.Range (-8, 8), Random.Range (-4, 4), 0f), Quaternion.identity);
				}
			} else {
				GameObject tocreate = vent [0];
				GameObject vents = Instantiate (tocreate, new Vector3 (Random.Range (-8, 8), Random.Range (-4, 4), 0f), Quaternion.identity);
			}
		}
	}

	public void spawnBateau()
	{
		GameObject boat = Instantiate(bateau, new Vector3(0,0, 0f), Quaternion.identity);
	}

	public void quest()
	{
		tquest.text = "Find the Jaloux in the Emerald Islands";
		Canvas can = canvas;
		Instantiate (can);
	}



	void Start()
	{
		spawnvent();
		spawnBateau();
		initMap();
		quest();
	}


	void Update () {
		if (Input.GetKey ("escape")) 
		{
			Application.Quit ();
		}
		if (!GameObject.Find("Event 1(Clone)")&&!GameObject.Find("Event 2(Clone)")) 
		{
			spawnvent();
		}

	}
}
