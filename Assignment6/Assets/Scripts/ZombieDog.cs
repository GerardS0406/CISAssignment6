/*
 * Gerard Lamoureux
 * ZombieDog
 * Assignment 6
 * Handles all Zombie Dog Classes
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalZombieDog : Enemy
{
    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 6;
        EnemyDamage = 40;
        EnemyHealth = 10;
    }

    protected override void ShowText()
    {
        text.text = "Dog\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.green;
    }
}

public class EliteZombieDog : Enemy
{
    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 6;
        EnemyDamage = 40;
        EnemyHealth = 20;
    }

    protected override void ShowText()
    {
        text.text = "Dog\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.yellow;
    }
}

public class SuperZombieDog : Enemy
{
    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 6;
        EnemyDamage = 40;
        EnemyHealth = 30;
    }

    protected override void ShowText()
    {
        text.text = "Dog\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.red;
    }
}
