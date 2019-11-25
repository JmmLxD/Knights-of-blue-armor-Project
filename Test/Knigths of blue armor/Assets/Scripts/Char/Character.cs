using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Character : MonoBehaviour {

	//TODO: Test its fuctionality and efficency

	String name;
	bool ally;
	Attack attacks;
	String armorType;
	int Health;
	int proficiency;

	Character(){

	}

	
	Character(String name, bool ally, Attack attacks, String armorType, int Health, int proficiency){
		this.name=name;
		this.ally=ally;
		this.attacks= attacks;
		this.armorType=armorType;
		this.Health=Health;
		this.proficiency=proficiency;
	}

	static int AdjustHealth(int Amount){

		return 0;
	}



}
