using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMovement : MonoBehaviour //Win's Code
{
    private Vector3 mousePosition;
    public float playerSpeed = 10f;
    public float life = 3f;
    public GameObject Explosion1;
    public int enemyCount;

    // Update is called once per frame
    void FixedUpdate()
    {
        //rotation
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        //movement
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, mousePosition, playerSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "enemyplane" || collision.gameObject.name == "Missile(Clone)")
        {
            life = life - 1;
            GameObject effect = Instantiate(Explosion1, transform.position, Quaternion.identity);
            Debug.Log("Explosion");
            Destroy(effect, 5f);
            Debug.Log("Explosion Destroyed");
            if (life <= 0)
            {
                transform.DetachChildren();
                Destroy(gameObject);
                Debug.Log("Plane Destroyed");
                //testing code
                Invoke("Delay", 2);
                SceneManager.LoadScene(1);

            }

        }
    }
}
