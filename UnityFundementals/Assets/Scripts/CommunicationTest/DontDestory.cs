using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestory : MonoBehaviour {
	void OnEnable(){
		DontDestroyOnLoad(gameObject);
	}
}
