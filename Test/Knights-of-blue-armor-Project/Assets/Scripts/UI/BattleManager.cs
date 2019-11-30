using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public partial class BattleManager : MonoBehaviour
{

    //Atributes and constructors

    //characters for combat
    public GameObject player, enemyLeader;
    public GameObject[] allySquad = new GameObject[5];
    public GameObject[] enemySquad = new GameObject[5];

    public bool playerTurn; //current turn chooser

    public ItemManager currentInventory; // equipped inventory for combat

    public AttackManager Combat; // attack chooser

    public HealthManager playerStatus, enemyStatus; //current health of both ally and enemy

}

public partial class BattleManager : MonoBehaviour
{

    //Renderers
    void Start()
    {
        StartConfigurationPosition();
        StartConfigurationStatus();
    }


    void Update()
    {
        Fight();
    }

}

public partial class BattleManager : MonoBehaviour
{
    //Methods: startups

    private void StartConfigurationPosition() // sets the position of all characters 
    {
        float playerPosX = -3.18f, playerPosY = -0.8f;
        float enemyLeaderPosX = 3.78f, enemyLeaderPosY = -0.8f;
        float[] allyPosX = { -3.31f, -5.28f, -8.81f, -10.76f, -6.1f };
        float[] allyPosY = { 1.64f, 1.37f, 0.27f, -1.15f, -1.51f };
        float[] enemySPosX = { 4.17f, 7.16f, 8.92f, 6.57f, 3.34f };
        float[] enemySPosY = { 2.22f, 2.26f, -1.64f, -3.71f, -3.15f };
        Quaternion playerSideRotation = player.transform.rotation;
        Quaternion enemySideRotation = enemyLeader.transform.rotation;

        Instantiate(player, new Vector2(playerPosX, playerPosY), playerSideRotation);
        Instantiate(enemyLeader, new Vector2(enemyLeaderPosX, enemyLeaderPosY), enemySideRotation);

        for (int Cont1 = 0; Cont1 < allySquad.Length; Cont1++)
        {
            Instantiate(allySquad[Cont1], new Vector2(allyPosX[Cont1], allyPosY[Cont1]), playerSideRotation);
            Instantiate(enemySquad[Cont1], new Vector2(enemySPosX[Cont1], enemySPosY[Cont1]), enemySideRotation);
        }

    }

    private void SetCombatUIs() // sets the interfaces for the player
    {
        
    }

    private void StartConfigurationStatus() // initiate the UI objects
    {
        playerStatus = new HealthManager();
        enemyStatus = new HealthManager();
        Combat = new AttackManager();
        playerTurn = true;
    }

}

public partial class BattleManager : MonoBehaviour
{
    //Methods: combat

    public void Fight() // sets the combat for every player
    {
      
        Combat.PerformAttack(playerTurn);
     
        
    }

    
}
