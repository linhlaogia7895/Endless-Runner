using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    public Text scoreText;
    public AudioSource audioName;
    private int coinCollect = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
         float directionX = Input.GetAxisRaw("Horizontal");
        direction = new Vector2(directionX, directionY).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);

    }
    private void OnTriggerEnter2D(Collider2D collide)
    {
        if(collide.tag == "coin")
        {
            coinCollect++;
            audioName.Play();
            scoreText.text = ((int)coinCollect).ToString();
        }
    }
}
