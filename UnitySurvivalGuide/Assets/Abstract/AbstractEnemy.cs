using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour
{
    public int speed;
    public int health;
    public int gems;

    public abstract void Attack();

    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}

public class MossGiant : AbstractEnemy
{
    private void Start()
    {
        Attack();
    }

    // When getting an abstract method, you use override
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    // You also have to use override when your parent class's method is virtual
    public override void Die()
    {
        // Can include custom particles implementation and any other implementation
        base.Die();
    }
}
