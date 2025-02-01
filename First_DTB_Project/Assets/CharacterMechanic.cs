using UnityEngine;

public class CharacterMechanic : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public const float moveSpeed = 4.0f;
    private Vector2 location;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        location = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Since Update() runs every frame having a faster pc
        // means characters move at a rate based on fps.
        // Multiplying moveSpeed * Time.deltaTime makes the speed
        // of the character agnostic of the # of frames.
        float moveAmount = moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            location.y += moveAmount;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            location.y -= moveAmount;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            location.x += moveAmount;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            location.x -= moveAmount;
        }

        rigidBody.MovePosition(location);
    }
}
