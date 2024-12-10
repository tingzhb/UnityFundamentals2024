using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    
	[SerializeField] GameObject[] enemiesToSpawn;
	[SerializeField] Transform spawnPoint;

	List<GameObject> spawnedEnemies = new();

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
			var enemyReference = Instantiate(enemy, spawnPoint.position, Quaternion.identity);
			spawnedEnemies.Add(enemyReference);
			yield return new WaitForFixedUpdate();
		}
		StartCoroutine(DespawnEnemies());
	}

	IEnumerator DespawnEnemies(){
		yield return new WaitForSeconds(2);
		foreach (var spawnedEnemy in spawnedEnemies){
			Destroy(spawnedEnemy);
			yield return new WaitForFixedUpdate();
		}
	}
}
