﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayEx : MonoBehaviour {

	public string[] sArray;

	// Use this for initialization
	void Start () {
		sArray = new string[10];

		sArray[0]="These";
		sArray[1]="are";
		sArray[2]="some";
		sArray[3]="words";

		print("The lenght of sArray is: "+sArray.Length);

		string str="";

		foreach(string sTemp in sArray){
			str += "|"+sTemp;
			if(sTemp == null) break;
		}
		print(str);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
