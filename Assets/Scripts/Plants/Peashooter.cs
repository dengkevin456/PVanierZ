using UnityEngine;

public class Peashooter : Plant
{
    public GameObject projectile;
    public LayerMask zombieLayer;
    public float detectionDistance;

    public override bool AttackCondition()
    {
        return false;
    }
    public override void Attack()
    {
        Instantiate(projectile);
    }
}
