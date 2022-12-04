using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public abstract class Enemy : MonoBehaviour,ILivingObject
{
    public float VisibilityRadius = 10;

    private GameObject _hostilObject;

    public float speed;
    
    public int health = 100;

    public int demage;

    private void AssignmentHostilObject()
    {
        if (_hostilObject == null)
        {
            RaycastHit2D hit = Physics2D.CircleCast(transform.position, VisibilityRadius, transform.position,0f);

            if (hit.collider.gameObject.GetComponent<Player>() != null)
            {
                _hostilObject = hit.collider.gameObject;

            }
        }
    }

    private void Attack()
    {
        
    }

    private void GoToHostilObject()
    {
        if (Vector2.Distance(_hostilObject.transform.position,transform.position) > 3)
        {
            transform.Translate((_hostilObject.transform.position - transform.position) * speed * Time.deltaTime);
        }
    }

    public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Dead();
        }
    }
    public void Dead()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        GoToHostilObject();
    }
}
