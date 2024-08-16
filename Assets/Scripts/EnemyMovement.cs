using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public float movementSpeed;
    public GameObject agent;
    public int health;

    private bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            agent.transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            if (health > 0)
            {
                GameObject playerHUD = GameObject.FindGameObjectWithTag("PlayerHUD");
                PlayerEnergy playerEnergy = playerHUD.GetComponent<PlayerEnergy>();
                playerEnergy.GainEnergy(10f);
            }
            health -= 1;
            if (health == 0){
                alive = false;
                agent.GetComponent<Rigidbody>().freezeRotation = false;
                Destroy(agent, 3);
            }
            
        }
        
        else if (collision.gameObject.name == "Player")
        {
            GameObject playerHUD = GameObject.FindGameObjectWithTag("PlayerHUD");
            PlayerHealth playerHealth = playerHUD.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(10f);
        }

    }

    public void death()
    {
        alive = false;
    }
}
