using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

  [SerializeField]
  Vector3 v3;
  [SerializeField]
  KeyCode pos;
  [SerializeField]
  KeyCode neg;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void FixedUpdate()
  {
      if(Input.GetKey(pos)) {
          GetComponent<Rigidbody>().velocity += v3;
      }

      if(Input.GetKey(neg)) {
          GetComponent<Rigidbody>().velocity -= v3;
      }
  }
}
