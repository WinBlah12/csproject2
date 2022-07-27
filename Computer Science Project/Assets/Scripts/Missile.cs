using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Missile : MonoBehaviour //Win's Code
{

    public GameObject Explosion1;
    public GameObject Explosion2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "enemyplane" || collision.gameObject.name == "enemyplane (1)"
            || collision.gameObject.name == "enemyplane (2)" || collision.gameObject.name == "enemyplane (3)"
            || collision.gameObject.name == "enemyplane (4)" || collision.gameObject.name == "enemyplane (5)"
            || collision.gameObject.name == "enemyplane (6)" || collision.gameObject.name == "enemyplane (7)"
            || collision.gameObject.name == "enemyplane (8)" || collision.gameObject.name == "enemyplane (9)"
            || collision.gameObject.name == "enemyplane (10)" || collision.gameObject.name == "enemyplane (11)"
            || collision.gameObject.name == "enemyplane (12)" || collision.gameObject.name == "enemyplane (13)"
            || collision.gameObject.name == "enemyplane (14)" || collision.gameObject.name == "enemyplane (15)"
            || collision.gameObject.name == "enemyplane (16)" || collision.gameObject.name == "enemyplane (17)"
            || collision.gameObject.name == "enemyplane (18)" || collision.gameObject.name == "enemyplane (19)"
            || collision.gameObject.name == "enemyplane (20)" || collision.gameObject.name == "enemyplane (21)"
            || collision.gameObject.name == "enemyplane (22)" || collision.gameObject.name == "enemyplane (23)"
            || collision.gameObject.name == "enemyplane (24)" || collision.gameObject.name == "enemyplane (25)"
            || collision.gameObject.name == "enemyplane (26)" || collision.gameObject.name == "Plane1"
            || collision.gameObject.name == "Missile(Clone)")
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
