using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour {
	public float maxTime= 60.0f;
	private float countdown=0.0f;
	public AudioSource audiosource;


	// Use this for initialization
	void Start () {
		countdown = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
		countdown -= Time.deltaTime;
		if (countdown <= 0) {
			Coin.coinsCount = 0;
			SceneManager.LoadScene ("Level_01");
		}
	}
	void onDisable(){
	
//		audiosource.clip = clipfirework;
//		AudioSource.PlayClipAtPoint (clipfirework, transform.position);
	}
}
