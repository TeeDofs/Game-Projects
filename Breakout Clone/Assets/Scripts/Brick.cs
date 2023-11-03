using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int health { get; private set; }
    public SpriteRenderer SpriteRenderer { get; private set; }
    public Sprite[] states;
    public bool unbreakable;
    public int points = 100;

    private void Awake()
    {
        this.SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        if(!this.unbreakable)
        {
            this.health = this.states.Length;
            this.SpriteRenderer.sprite = this.states[health - 1];
        }
    }

    private void Hit()
    {
        if (this.unbreakable)
        {
            return;
        }
        this.health--;

        if(this.health <= 0)
        {
            this.gameObject.SetActive(false);
        } else
        {
            this.SpriteRenderer.sprite = this.states[health - 1];
        }
        FindObjectOfType<GameManager>().Hit(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            Hit();
        }
    }
}
