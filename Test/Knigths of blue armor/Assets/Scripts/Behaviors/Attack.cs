using System.Collections;


using System.Collections.Generic;


using UnityEngine;



public class Attack : MonoBehaviour {



	//TODO: Test the behavior patterns

	String name;
	
	String elementalType;

	int baseDamage;

	Rhythmn currentRhythmn;

	Attack(){
		
	}

	Attack(String name, String elementalType, int baseDamage, Rhythmn currentRhythmn){

		this.name=name;
		this.elementalType=elementalType;
		this.baseDamage=baseDamage;
		this.currentRhythmn=currentRhythmn;
		
	}

}
