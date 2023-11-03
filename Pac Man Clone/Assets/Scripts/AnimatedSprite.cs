using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]//This means that the object needs to have a aprite renderer before it can run this script
public class AnimatedSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] sprites;
    public float animationFrameTime = 0.25f;
    public int animationFrame { get; private set; }
    public bool loop = true;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(Advance), this.animationFrameTime, this.animationFrameTime);
    }

    private void Advance()
    {
        if(!this.spriteRenderer.enabled) 
        {
            return;
        }
        this.animationFrame++;

        if(this.animationFrame >= this.sprites.Length && this.loop)
        {
            animationFrame = 0;
        }

        if(this.animationFrame >= 0 && this.animationFrame < this.sprites.Length)
        {
            this.spriteRenderer.sprite = this.sprites[this.animationFrame];
        }
    }

    public void Reset()
    {
        this.animationFrame = -1;

        Advance();
    }
}
