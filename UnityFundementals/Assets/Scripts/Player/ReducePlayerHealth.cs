using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducePlayerHealth : MonoBehaviour {
	[SerializeField] SO_PlayerData soPlayerData;
	[SerializeField] float healthReduction;
	
	public void ReduceHealth(){
		soPlayerData.ReducePlayerHealth(healthReduction);
	}
	
	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag("Enemy")){
			Debug.Log("Enemy Hit!");
			ReduceHealth();
		}
	}
}
