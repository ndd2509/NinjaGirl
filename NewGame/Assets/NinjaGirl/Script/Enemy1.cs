using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public int heath = 100;
    public GameObject deathEffect;

  
     void Damage(int damage)
    {
        heath -= damage;
         if(heath <= 0){
           Die();
        }
        
    }
void Die(){
  GameObject clone = Instantiate(deathEffect, transform.position, Quaternion.identity);
  Destroy(clone,0.5f);
    Destroy(gameObject);
}
}

