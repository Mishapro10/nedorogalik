using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class PlayerMove : MonoBehaviour
{
    float x = 0.49f;
    float y = 2.45f;
    float z = -12.36f;
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 5f; 
   private Vector3 direction;
    
    void Start()
    {
        transform.position = new Vector3(x, y, z);
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        direction = new Vector3(moveHorizontal, 0, moveVertical);
        direction = transform.TransformDirection(direction) * speed;
        controller.Move(direction * Time.deltaTime);
    }
}
