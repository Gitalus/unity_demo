using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField] GameObject objectToFollow;
  void LateUpdate()
  {
    // Para cambiar algo distinto del objeto del script, necesitamos una referencia
    transform.position = objectToFollow.transform.position + new Vector3(0, 0, -10);

  }
}
