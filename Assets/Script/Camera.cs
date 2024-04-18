using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed;
    private float nextIncreaseTime = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextIncreaseTime)
        {
            speed *= 1.1f;
            nextIncreaseTime = Time.time + 5.0f;
        }
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
