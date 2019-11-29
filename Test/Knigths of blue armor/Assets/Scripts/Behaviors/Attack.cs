using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Attack : MonoBehaviour {

	//TODO: Test the behavior patterns

	String name;
	String elementalType;
	int baseDamage;

	Attack(){
		
	}

	Attack(String name, String elementalType, int baseDamage){

		this.name=name;
		this.elementalType=elementalType;
		this.baseDamage=baseDamage;
		
	}
}
