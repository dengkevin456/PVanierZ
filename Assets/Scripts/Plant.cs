using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private float health;

    private PSTATE CurrentState = PSTATE.IDLE;

    public enum PSTATE
    {
        IDLE, ATTACKING, DYING
    }

    void Start()
    {

    }

    public virtual bool AttackCondition()
    {
         return false;
    }

    public virtual void Die()
    {
        Debug.Log("Die");
    }

    public virtual void TakeDamage()
    {
        Debug.Log("TakeDamage");
    }

    public virtual void Attack()
    {
        Debug.Log("Attack");
    }
}