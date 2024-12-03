using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataView : MonoBehaviour {
	[SerializeField] private SO_PlayerData soPlayerData;
	void OnEnable(){
		var playerHealth = soPlayerData.GetPlayerHealth();
		Debug.Log(playerHealth);
	}
}
