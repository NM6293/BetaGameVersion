﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float speed = 25;
    private Rigidbody enemyRb;
    private GameObject player;
   private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //following

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
