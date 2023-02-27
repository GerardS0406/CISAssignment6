/*
 * Gerard Lamoureux
 * BossZombie
 * Assignment 6
 * Handles all Boss Zombie Classes
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBossZombie : Enemy
{
    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 1;
        EnemyDamage = 250;
        EnemyHealth = 80;
    }

    protected override IEnumerator Attack()
    {
        isAttacking = true;
        GameManager.gameManager.TakeDamage(EnemyDamage);
        Destroy(gameObject);
        yield return null;
    }

    protected override void ShowText()
    {
        text.text = "Boss\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.green;
    }
}

public class EliteBossZombie : Enemy
{
    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 1;
        EnemyDamage = 250;
        EnemyHealth = 160;
    }

    protected override IEnumerator Attack()
    {
        isAttacking = true;
        GameManager.gameManager.TakeDamage(EnemyDamage);
        Destroy(gameObject);
        yield return null;
    }

    protected override void ShowText()
    {
        text.text = "Boss\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.yellow;
    }
}

public class SuperBossZombie : Enemy
{
    public override void Awake()
    {
        base.Awake();
        EnemySpeed = 1;
        EnemyDamage = 250;
        EnemyHealth = 240;
    }

    protected override IEnumerator Attack()
    {
        isAttacking = true;
        GameManager.gameManager.TakeDamage(EnemyDamage);
        Destroy(gameObject);
        yield return null;
    }

    protected override void ShowText()
    {
        text.text = "Boss\nHEA: " + EnemyHealth + "\nDMG: " + EnemyDamage;
    }

    private void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.red;
    }
}
