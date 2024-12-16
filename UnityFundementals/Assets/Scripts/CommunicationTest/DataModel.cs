using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataModel : MonoBehaviour{
	public string currentPosition;
	public bool isHappy;

	void FixedUpdate(){
		currentPosition = gameObject.transform.ToString();
	}
}
