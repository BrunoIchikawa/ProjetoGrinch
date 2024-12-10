using UnityEngine;

public class Movement
{
    private Transform cameraTransform;

    public Movement(Transform cameraTransform)
    {
        this.cameraTransform = cameraTransform;
    }

    public Vector3 CalculateMovement(Vector3 input, float deltaTime)
    {
        Vector3 movement = cameraTransform.TransformDirection(input);
        movement.y = 0; // Garante que não há movimento no eixo vertical
        return movement * deltaTime * 5f;
    }

    public Quaternion CalculateRotation(Vector3 movement, Quaternion currentRotation, float deltaTime)
    {
        if (movement != Vector3.zero)
        {
            return Quaternion.Slerp(currentRotation, Quaternion.LookRotation(movement), deltaTime * 10);
        }
        return currentRotation;
    }
}
