using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour //Win's Code
{
    public Transform player;
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 movement;
    public GameObject Explosion1;
    public GameObject Explosion2;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Plane1") != null)
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            direction.Normalize();
            movement = direction;
        }
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Plane1" || collision.gameObject.name == "Missile(Clone)")
        {
            GameObject effect = Instantiate(Explosion1, transform.position, Quaternion.identity);
            Debug.Log("Explosion");
            Destroy(effect, 5f);
            Debug.Log("Explosion Destroyed");
            Destroy(gameObject);
            Debug.Log("Missile Destroyed");
        }
    }
}
