using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float speed;
    public Renderer renderer;

    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset += new Vector2(speed + Time.deltaTime, 0f);
    }
}
