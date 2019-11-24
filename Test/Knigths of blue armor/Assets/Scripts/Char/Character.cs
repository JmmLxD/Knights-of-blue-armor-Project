using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Character : MonoBehaviour {



	//TODO: Test its fuctionality and efficency

	String name;
	boolean ally;
	Attack attacks;
	String armorType;
	int Health;
	int proficiency;
	Items inventory;

	Character(){

	}

	
	Character(String name, boolean ally, Attack attacks, String armorType, int Health, int proficiency, Items inventory){
		this.name=name;
		this.ally=ally;
		this.attacks= attacks;
		this.armorType=armorType;
		this.Health=Health;
		this.proficiency=proficiency;
		this.inventory=inventory;
	}

	static int AdjustHealth(int Amount){
		

		return 0;
	}



}
