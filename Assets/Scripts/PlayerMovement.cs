using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 7f;
    public float gravity = 1f;

    CharacterController characterController;
    Vector3 velocity;

    void Start()
    {
        characterController = GetComponentInChildren<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(move * Time.deltaTime * playerSpeed);

        //velocity.y += gravity * Time.deltaTime;
        //characterController.Move(velocity * Time.deltaTime);
    }
}
