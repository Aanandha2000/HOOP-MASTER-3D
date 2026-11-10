Assets/Scripts/BasketballController.cs

using UnityEngine;

public class BasketballController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float shootForce = 10f;

    public Rigidbody ball;

    private Vector2 moveInput;

    public void SetMoveInput(Vector2 input)
    {
        moveInput = input;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(
            moveInput.x, 0, moveInput.y
        );

        transform.Translate(
            movement * moveSpeed * Time.fixedDeltaTime
        );
    }

    public void Shoot()
    {
        if (ball != null)
        {
            ball.AddForce(
                transform.forward * shootForce
                + Vector3.up * 4f,
                ForceMode.Impulse
            );
        }
    }
}
