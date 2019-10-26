﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
	private Transform bar;
    private Player player;
    private float health;
    private float healthTakeDamage;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        health = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        healthTakeDamage = (float)player.CurrentHealth() / (float)player.maxHealth;
        if (health > healthTakeDamage)
        {
            setSize(healthTakeDamage);
            health = healthTakeDamage;
        }
    }

    public void setSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f); 
    }

    public void setColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }
}