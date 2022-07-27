using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour //Win's Code
{

    public Transform firePoint;
    public GameObject missilePrefab;
    
    public float missileForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            Debug.Log("Fired");
        }
    }

    void Shoot()
    {
        GameObject missile = Instantiate(missilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * missileForce, ForceMode2D.Impulse);
    }
}
