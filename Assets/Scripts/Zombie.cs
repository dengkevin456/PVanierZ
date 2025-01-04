using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int Health = 0;
    public int DifficultyValue = 0;
    protected bool Attacking = false;
    public var MovementComponent;
    private ZState CurrentState = ZState.WALKING;

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
        
    }

    // Die calls death animation (and maybe notifies the wave system)
    public virtual void Die() 
    {
        CurrentState = ZState.DYING;
    }
    
    // Removes a specified ammount of healh
    public virtual void TakeDamage(int damage) {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }
}
