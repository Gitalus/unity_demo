using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool hasPackage;
  // Receive the information of the colliding object
  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("Hola, esto es un log");
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package")
    {
      hasPackage = true;
      Debug.Log("This is triggered");
    }
    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Package delivered");
      hasPackage = false;
    }
  }
}
