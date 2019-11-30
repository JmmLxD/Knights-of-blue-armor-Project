using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AttackManager : MonoBehaviour
{
    public static Rhythmn[] equippedCombos = new Rhythmn[3];
    public Rhythmn enemyDefaultAttack = new Rhythmn();

    public void PerformAttack(bool turnOfPlayer)
    {
        if (turnOfPlayer)
        {
            Debug.Log("PlayerTurn");
        }

        else 
        {
            Debug.Log("EnemyTurn");
        }

       

    }

}
