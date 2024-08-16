using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBulletCollision : MonoBehaviour
{
    public GameObject EBullet;
    public float power = 5000f;
    public float radius = 300;
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
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        Destroy(EBullet);
        foreach (Collider hit in colliders){
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (hit.name == "Enemy(Clone)")
            {
                hit.gameObject.GetComponent<EnemyMovement>().death();
                hit.attachedRigidbody.freezeRotation = false;
                rb.AddExplosionForce(power, transform.position, radius, 2f);
                Destroy(hit.gameObject, 3);

            }
        }
    }
}
