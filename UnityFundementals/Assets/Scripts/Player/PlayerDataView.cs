using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class PlayerDataView : MonoBehaviour {
	[SerializeField] private SO_PlayerData soPlayerData;
	[SerializeField] TMP_Text playerHealthText;
	

	public void UpdateUI(){
		var playerHealth = soPlayerData.GetPlayerHealth();
		playerHealthText.text = playerHealth.ToString(CultureInfo.InvariantCulture);
	}
}
