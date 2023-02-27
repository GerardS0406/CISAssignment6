/*
 * Gerard Lamoureux
 * Enemy
 * Assignment 6
 * Handles the Enemy Abstract Class
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected int EnemyHealth = 20;

    protected float EnemySpeed = 2;

    protected int EnemyDamage = 1;

    protected bool isAttacking = false;

    protected TextMeshProUGUI text;

    protected Rigidbody2D rb;

    protected Coroutine attackRoutine;

    public virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        Move();
        ShowText();
        StartAttack();
    }

    protected virtual void ShowText()
    {
        text.text = "Enemy\nHealth: " + EnemyHealth + "\nDamage: " + EnemyDamage;
    }

    protected virtual void StartAttack()
    {
        if (transform.position.x > 9 && attackRoutine == null && !GameManager.gameManager.gameOver)
        {
            attackRoutine = StartCoroutine(Attack());
        }
        if(GameManager.gameManager.gameOver)
        {
            Destroy(gameObject);
        }
    }

    protected virtual IEnumerator Attack()
    {
        isAttacking = true;
        GameManager.gameManager.TakeDamage(EnemyDamage);
        yield return new WaitForSeconds(1);
        attackRoutine = null;
    }

    public virtual void Move()
    {
        if (!isAttacking)
            rb.velocity = Vector2.right * EnemySpeed;
        else
            rb.velocity = Vector2.zero;
    }

    public virtual void TakeDamage(int damage)
    {
        EnemyHealth -= damage;
        if (EnemyHealth <= 0)
            Die();
    }

    private void Die()
    {
        GameManager.gameManager.PlayerScore++;
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        TakeDamage(GameManager.gameManager.playerDamage);
    }
}
