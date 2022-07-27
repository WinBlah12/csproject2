using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour //Win's Code
{
    public Transform firePoint;
    public GameObject missilePrefab;
    private float delay;

    public float missileForce = 15f;

    // Start is called before the first frame update
    void Start()
    {
        delay = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (delay > 0)
        {
            delay -= Time.deltaTime;
        }

        if (delay <= 0)
        {
            delay = 2f;  // this is the interval between firing.
            Debug.Log("Enemy Fired");
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject missile = Instantiate(missilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * missileForce, ForceMode2D.Impulse);
    }
}
