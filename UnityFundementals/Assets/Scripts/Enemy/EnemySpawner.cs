using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    
	[SerializeField] GameObject[] enemiesToSpawn;

	void OnEnable(){
		foreach (var enemy in enemiesToSpawn){
			Instantiate(enemy, transform.position, Quaternion.identity);
		}
	}

}
