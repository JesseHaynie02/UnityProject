using UnityEngine;

public class CharacterMechanic : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float moveSpeed = 275.0f;

    // FixedUpdate is used for being in-step with the physics engine, 
    // so anything that needs to be applied to a rigidbody should happen 
    // in FixedUpdate.
    void FixedUpdate()
    {
        // Horizontal and Vertical are defined in project settings
        // get the Input from Horizontal axis
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        // get the Input from Vertical axis
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector2 moveVector = new Vector2(horizontalInput, verticalInput);
        // Update the velocity of the characters rigid body.
        // This allows for this object to behave correctly with other
        // collider objects because you are moving the object
        // through unitys physics engine.
        // Use Time.deltaTime even though FixedUpdate runs at a set #
        // of times per second Time.deltaTime locks that # to be constant.
        rigidBody.linearVelocity = moveSpeed * Time.deltaTime * moveVector;
    }
}
