using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataFiller : MonoBehaviour {
	[SerializeField] SO_EnemyDataModel enemyDataModel;

	void OnEnable(){
		GetComponent<MeshRenderer>().material.color = enemyDataModel.GetEnemyColor();
	}
}