using System;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Parameters
    public float health = 0;
    public float difficultyValue = 0;
    public float movementSpeed = 0;
    public ZState currentState = ZState.WALKING;
    private GameObject collidingPlant;
    // Components
    public Rigidbody2D rb;
    public Animation animation;

    public enum ZState { 
        WALKING, ATTACKING, DYING
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case ZState.WALKING :
            {
                Walking();
                break;
            }
            case ZState.ATTACKING :
            {
                rb.linearVelocity = Vector2.zero;
                if (animation["attacking"].normalizedTime >= 1) {
                    Attack();
                    animation["attacking"].time = 0;
                }
                break;
            }
            case ZState.DYING:
            {
                rb.linearVelocity = Vector2.zero;
                
                if (animation["dying"].normalizedTime >= 1) {
                    Die();
                    animation["dying"].time = 0;
                }
                break;
            }
        }

        if (currentState == ZState.WALKING) {
            Walking();
        }
        
    }
    
    /// <summary>
    /// Moves the zombie using Rigidbody2d
    /// </summary>
    protected virtual void Walking()
    {
        rb.linearVelocity = Vector2.left * movementSpeed;
    }
    
    // Die calls death animation (and maybe notifies the wave system)
    /// <summary>
    /// Plays death animation and removes the body once it's done
    /// + maybe notify zombie wave system
    /// </summary>
    protected virtual void Die() 
    {
        Destroy(gameObject);
    }
    
    /// <summary>
    /// Removes a specified amount of health
    /// If health drops bellow a threshold, calls Die();
    /// </summary>
    /// <param name="damage">float specified by the caller object</param>
    protected virtual void TakeDamage(float damage) {
        health -= damage;
        if (health <= 0)
        {
            animation.Play("Dying");
            currentState = ZState.DYING;
        }
    }

    /// <summary>
    /// Calls TakeDamage() of the collidingPlant
    /// </summary>
    protected virtual void Attack()
    {
        if (!collidingPlant)
        {
            return;
        }
        // TODO: Plant takes damage
    }

    /// <summary>
    /// Detects if it collides with a plant
    /// If so it changed ZState from Walking to Attacking 
    /// </summary>
    /// <param name="collision">Object it collided with</param>
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        collidingPlant = collision.gameObject;
        currentState = ZState.ATTACKING;
        animation.Play("attacking");
    }

    /// <summary>
    /// Detects if it doesn't collide with a plant after colliding with one
    /// If so it changes ZState from Attacking to Walking
    /// (This means the plant has been eaten)
    /// </summary>
    /// <param name="collision"></param>
    protected void OnTriggerExit2D(Collider2D collision)
    {
        collidingPlant = null;
        currentState = ZState.WALKING;
    }
}
