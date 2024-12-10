using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    
	[SerializeField] GameObject[] enemiesToSpawn;
	[SerializeField] Transform spawnPoint;

	void OnEnable(){
		// SpawnEnemies();
		StartCoroutine(SpawnEnemiesWithDelay()); 
	}
	
	
	// void SpawnEnemies(){
	// 	foreach (var enemy in enemiesToSpawn){
	// 		Instantiate(enemy, spawnPoint.position, Quaternion.identity);
	// 	}
	// }

	IEnumerator SpawnEnemiesWithDelay(){
		foreach (var enemy in enemiesToSpawn){
			Instantiate(enemy, spawnPoint.position, Quaternion.identity);
			yield return new WaitForFixedUpdate();
		}
	}
}
