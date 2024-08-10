using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float SpawnInterval;
    private float CD = 0f;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnInterval <= CD)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            CD = 0f;
        }
        else
        {
            CD += Time.deltaTime;
        }
    }
}
