using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurn : MonoBehaviour
{
    float  t1;
    float  t2;

    public BattleManager battle;

    void Start()
    {
        print("Enemy Turn Begins");
        t1 = Time.time;
    }

    

    void Update() // ofcourse here we would end the turn based on input , time , etc
    {
        t2 = Time.time;
        if( Mathf.Abs(t1 - t2) >= 2 )
        {
            battle.LauchTurn();
           Destroy(gameObject);
        }
    }
}
