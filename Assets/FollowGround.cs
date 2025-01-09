using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;

public class FollowGround : MonoBehaviour
{
    [SerializeField] public Transform enemy;
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private float dirx = 0f;
    [SerializeField] private float moveSpeed = 15f;
    [SerializeField] public Transform player;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (enemy.position.x < player.position.y)
        {
            dirx = 1;
        }
        else
        {
            dirx = -1;
        }
        rb.velocity = new Vector2(dirx * moveSpeed, 0);
    }
}
