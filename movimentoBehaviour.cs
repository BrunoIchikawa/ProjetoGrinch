using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    private Movement movement;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        movement = new Movement(Camera.main.transform);
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 input = new Vector3(horizontal, 0, vertical);

        Vector3 movementVector = movement.CalculateMovement(input, Time.deltaTime);
        controller.Move(movementVector);

        Vector3 gravity = new Vector3(0, -9.81f, 0) * Time.deltaTime;
        controller.Move(gravity);

        transform.rotation = movement.CalculateRotation(movementVector, transform.rotation, Time.deltaTime);
    }
}
