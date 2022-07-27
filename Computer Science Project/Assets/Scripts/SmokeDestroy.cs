using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeDestroy : MonoBehaviour //andrews code
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Plane1") == null)
        {
            Destroy(gameObject);
        }
    }
}
