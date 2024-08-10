using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public float movementSpeed;
    public GameObject agent;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {    
        agent.transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }
}
