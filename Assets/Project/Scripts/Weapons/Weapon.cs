using UnityEngine;

public abstract class Weapon : Thing
{
    public int damage = 10;
    public abstract void Attack();
}
