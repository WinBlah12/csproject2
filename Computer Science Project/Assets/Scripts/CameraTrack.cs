using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrack : MonoBehaviour //andrews code
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.x = 0;
        rotationVector.y = 0;
        rotationVector.z = 0;
        transform.rotation = Quaternion.Euler(rotationVector);
    }
}
