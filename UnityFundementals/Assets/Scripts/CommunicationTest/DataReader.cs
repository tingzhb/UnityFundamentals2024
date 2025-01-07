using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataReader : MonoBehaviour{

	void Awake(){
		// GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
	}
	
	// void FixedUpdate(){
	//  GameObject enemy = gameObjects[0];
	// 	Debug.Log(enemy.GetComponent<DataModel>().currentPosition);
	// 	Debug.Log(enemy.GetComponent<DataModel>().isHappy);
	// }

	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag("Enemy")){
			// GameObject enemy = other.gameObject;
			// Debug.Log(enemy.GetComponent<DataModel>().isHappy);
			// enemy.transform.GetChild(0).gameObject.SetActive(true);
			// StartCoroutine(ChangeScene());
		}
	}

	IEnumerator ChangeScene(){
		yield return new WaitForSeconds(2);
		var nextScene = SceneManager.GetActiveScene().buildIndex + 1;
		// SceneManager.LoadScene(nextScene);
		// SceneManager.LoadSceneAsync(nextScene);
		SceneManager.LoadSceneAsync(nextScene, LoadSceneMode.Additive);
		yield return new WaitForSeconds(2);
		SceneManager.UnloadSceneAsync(0);
	}
}
