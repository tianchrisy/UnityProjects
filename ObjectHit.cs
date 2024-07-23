using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
  /// <summary>
  /// OnCollisionEnter is called when this collider/rigidbody has begun
  /// touching another rigidbody/collider.
  /// </summary>
  /// <param name="other">The Collision data associated with this collision.</param>
  private void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "Player")
    {
      Debug.Log(GetComponent<MeshRenderer>().material.color = Color.red);
      gameObject.tag = "Hit";
    }

  }



}
