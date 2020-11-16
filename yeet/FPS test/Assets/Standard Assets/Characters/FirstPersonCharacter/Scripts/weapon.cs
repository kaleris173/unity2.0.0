using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class weapon : MonoBehaviour
{
    public GameObject bullet;
        public Transform Muzzle;
    public int CurAmmo;
    public int MaxAmmo;
    public float Speed;
    public float FireRate;
    private float LastShootTime;
    public bool isPlayer;
    // Start is called before the first frame update
    private void Awake()
    {
        if (GetComponent<FirstPersonController>())
        {
            isPlayer = true;
        }
    }

    public bool Canshoot()
    { if (Time.time - LastShootTime >= FireRate)
        {
            if (CurAmmo> 0)
            {
                return true;

            }
        }
        return false;
    }

    public void shoot()
    {
        LastShootTime = Time.time;
        CurAmmo--;
        GameObject projectile = Instantiate(bullet, Muzzle.position, Muzzle.rotation);
        projectile.GetComponent<Rigidbody>().velocity = Muzzle.forward * Speed; 
    }
    
}
