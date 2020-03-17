using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccionarAnimal : MonoBehaviour {

	public GameObject[] animales;

	void Start(){
		animales = GameObject.FindGameObjectsWithTag ("animal");
		animales [0].SetActive (true);
		for (int i = 1; i < animales.Length; i++) {
			animales [i].SetActive (false);
		}
	}

	public void next(){
		for (int i = 0; i < animales.Length; i++) {
			if (animales [i].activeSelf ) {
				if (i != (animales.Length-1)) {
					animales [i].SetActive (false);
					animales [i + 1].SetActive (true);
				} else {
					animales [i].SetActive (false);
					animales [0].SetActive (true);
				}
				return;
			} 
		}
	}

	public void previous(){
		for (int i = 0; i < animales.Length; i++) {
			if (animales [i].activeSelf ) {
				if (i != 0) {
					animales [i].SetActive (false);
					animales [i-1].SetActive (true);
				} else {
					animales [i].SetActive (false);
					animales [animales.Length-1].SetActive (true);
				}
				return;
			} 
		}
	}
}
