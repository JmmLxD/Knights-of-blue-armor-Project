using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
<<<<<<< HEAD



public partial class BattleManager : MonoBehaviour
{
=======
>>>>>>> b2a2611a785ce0f9ba93992a942a0d68df9c4f3e

    //Atributes and constructors

    public GameObject player, enemyLeader;
    public GameObject[] allySquad = new GameObject[5];
    public GameObject[] enemySquad = new GameObject[5];
    public bool playerTurn;
    public ItemManager currentInventory;
    public AttackManager Combat;
    public HealthManager playerStatus, enemyStatus;

}

public partial class BattleManager : MonoBehaviour
{

<<<<<<< HEAD
    //Renderers
    void Start()
    {
        StartConfigurationPosition();
        StartConfigurationStatus();
    }

=======
	
	Character[] allySquad=new Character[5];
	Character[] enemySquad=new Character[5];
	bool Playerturn;
    Rhythmn currentRhythmn;
    Items inventory;

    BattleManager(){
>>>>>>> b2a2611a785ce0f9ba93992a942a0d68df9c4f3e

    void Update()
    {

    }

}

public partial class BattleManager : MonoBehaviour
{
    //Methods

    private void StartConfigurationPosition()
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

    private void StartConfigurationStatus()
    {
        playerStatus = new HealthManager();
        enemyStatus = new HealthManager();
        playerTurn = true;
    }

}

