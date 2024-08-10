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
            health -= 1;
            if (health == 0){
                alive = false;
                agent.GetComponent<Rigidbody>().freezeRotation = false;
                Destroy(agent, 3);
            }
            
        }
        
    }
}
