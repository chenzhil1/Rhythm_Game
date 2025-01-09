using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;

public class Follow : MonoBehaviour
{
    [SerializeField] public Transform enemy;
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private float dirx = 0f;
    private float diry = 0f;
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
            dirx = 1 * Mathf.Abs(enemy.position.x - player.position.x);
        }
        else
        {
            dirx = -1 * Mathf.Abs(enemy.position.x - player.position.x);
        }
        if (enemy.position.y < player.position.y)
        {
            diry = 1 * Mathf.Abs(enemy.position.x - player.position.x);
        }
        else
        {
            diry = -1 * Mathf.Abs(enemy.position.x - player.position.x);
        }
        transform.position = Vector2.Lerp(enemy.position, player.position, 100);
    }
}
