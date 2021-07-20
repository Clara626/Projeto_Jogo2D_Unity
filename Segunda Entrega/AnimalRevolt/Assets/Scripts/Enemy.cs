using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Enemy : MonoBehaviour{

    public GameObject deathEffect;

    public static int EnemiesAlive = 0; 

    public float health = 4f;

    void Start(){

        EnemiesAlive++;
    }

    void OnCollisionEntar2D(Collision2D colInfo){

        if (colInfo.relativeVelocity.magnitude > health){

            Die();
        }

    }

    void Die(){

        Instantiate(deathEffect, transform.position, Quaternion.identity);

        EnemiesAlive++;
        if (EnemiesAlive <= 0)
            Debug.Log("Level Won!")


        Destroy(gameObject);

    }
}
