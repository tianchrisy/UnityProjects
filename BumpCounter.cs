using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpCounter : MonoBehaviour
{
    int hits = 0;
    int objectHit = 0;

   private void OnCollisionEnter(Collision other)
   {

    if (other.gameObject.tag != "Hit")
    {
      hits++;

      Debug.Log("You have bumped into walls this many times: " + hits);
    }


   }
}
