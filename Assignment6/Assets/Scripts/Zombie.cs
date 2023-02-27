/*
 * Gerard Lamoureux
 * Zombie
 * Assignment 6
 * Handles all Base Zombie Classes
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalZombie : Enemy
{

    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 4;
        EnemyDamage = 60;
        EnemyHealth = 20;
    }

    protected override void ShowText()
    {
        text.text = "Zombie\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.green;
    }
}

public class EliteZombie : Enemy
{

    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 4;
        EnemyDamage = 60;
        EnemyHealth = 40;
    }

    protected override void ShowText()
    {
        text.text = "Zombie\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.yellow;
    }
}

public class SuperZombie : Enemy
{

    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 4;
        EnemyDamage = 60;
        EnemyHealth = 60;
    }

    protected override void ShowText()
    {
        text.text = "Zombie\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.red;
    }
}
