using Unity.VisualScripting;
using UnityEngine;

public class SimpleHands : Weapon
{
    private bool isAttack = false;
    
    public override void Attack()
    {
        isAttack = false;
    }

    private void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.GetComponent<ILivingObject>() != null)
        {
            
        }
    }
}
