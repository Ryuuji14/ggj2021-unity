using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	
	public static int coinsCount = 0;
	public AudioSource coinsource;
	public AudioClip clipcoin;
	public AudioClip clipfirework;

	// Use this for initialization
	void Start () {
		Coin.coinsCount++;
		//Debug.Log ("hola");
		coinsource=GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collider){
		if (collider.CompareTag ("Player")) {
			AudioSource.PlayClipAtPoint (clipcoin, transform.position);
			Debug.Log ("Te faltan por recolectar " + (coinsCount-1).ToString () + " monedas.");
			Destroy (gameObject);
		}
	}
	void OnDestroy(){
		Coin.coinsCount--;
		if (Coin.coinsCount <= 0) {
			GameObject timer = GameObject.Find ("GameTimer");



			Debug.Log ("Ganaste!! :)");
			GameObject[] fireworks = GameObject.FindGameObjectsWithTag ("Firework");
			foreach (GameObject firework in fireworks) {
				firework.GetComponent<ParticleSystem> ().Play ();
			}
			Destroy (timer);
		}
	
	}

}
