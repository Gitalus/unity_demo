using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 0, 255);
  [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
  [SerializeField] float destroyDelay = 0.5f;

  bool hasPackage;

  SpriteRenderer spriteRenderer;
  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
  // Receive the information of the colliding object
  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("Hola, esto es un log");
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package" && !hasPackage)
    {
      hasPackage = true;
      Debug.Log("Packag Picked");
      spriteRenderer.color = hasPackageColor;
      Destroy(other.gameObject, destroyDelay);
    }
    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Package delivered");
      spriteRenderer.color = noPackageColor;
      hasPackage = false;
    }
  }
}
