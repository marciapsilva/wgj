﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private Collectable lostItem;
    
    public BarManager barManager;

    public int lostItA, lostItB;

    void Update ()
    {
        //lostIt = 
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        lostItA = col.GetComponent<Collectable> ().lostItA;
        lostItB = col.GetComponent<Collectable> ().lostItB;

        bar.updateBar ();

        Destroy (col.gameObject);
    }
}
