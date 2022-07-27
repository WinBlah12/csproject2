using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lives : MonoBehaviour //andrews code
{
    private float life;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Plane1") != null)
        {
            life = GameObject.Find("Plane1").GetComponent<PlaneMovement>().life;
            text.text = "Lives: " + life.ToString();
        }
    }
}
