using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.InputSystem.XR;
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private CharacterController controller;
    private Vector3 velocity;
    public float jumpHeight = 1.5f;
    public float gravity = -9.81f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        Move();
        Jump();
        ApplyGravity();

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interaction key pressed");
        }
    }
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h, 0f, v);
        transform.Translate(movement * speed * Time.deltaTime);
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = Mathf.Sqrt(
                jumpHeight * -2f * gravity
            );
        }
    }
    void ApplyGravity()
    {
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
