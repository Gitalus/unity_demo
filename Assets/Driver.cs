using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
  [SerializeField] float steerSpeed = 300f;
  [SerializeField] float moveSpeed = 10f;
  [SerializeField] float slowSpeed = 5f;
  [SerializeField] float boostSpeed = 20f;

  void Update()
  {
    // Input.GetAxis return a 1 every frame
    float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
    // Se multiplica por Time.deltaTime ya que dependiendo del computador, se generarán x frames por segundo
    // deltaTime será lo que se demora cada frame, por lo tanto, si se multiplica la cantidad de frames por segundo, por el delta
    // siempre será uno, independiente del computador
    float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    transform.Rotate(0, 0, -steerAmount);
    transform.Translate(0, moveAmount, 0);
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Boost")
    {
      moveSpeed = boostSpeed;
    }
    if (other.tag == "Stop")
    {
      moveSpeed = slowSpeed;
    }
  }
}
