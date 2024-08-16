using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject playerHUD = GameObject.FindGameObjectWithTag("PlayerHUD");
            PlayerHealth playerHealth = playerHUD.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(10f);
        }
    }
}
