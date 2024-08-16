using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject energyBulletPrefab;
    public GameObject gun;
    public float bulletSpeed;
    public float energyBulletSpeed;
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed);
        Destroy(bullet, 2);
    }
    public void ShootEnergy()
    {
        PlayerEnergy playerEnergy = GameObject.FindGameObjectWithTag("PlayerHUD").GetComponent<PlayerEnergy>();
        if (playerEnergy.energy >= 10)
        {
            playerEnergy.LoseEnergy(10);
            Vector3 EBulletPos = gun.transform.forward * 2 + gun.transform.position;
            GameObject energyBullet = Instantiate(energyBulletPrefab, EBulletPos, gun.transform.rotation);
            energyBullet.GetComponent<Rigidbody>().AddForce(energyBullet.transform.forward * energyBulletSpeed);
            Destroy(energyBullet, 7);
        }
        
    }
}
