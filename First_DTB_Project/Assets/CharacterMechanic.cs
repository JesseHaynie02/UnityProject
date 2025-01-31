using UnityEngine;

public class CharacterMechanic : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public const float moveScale = 0.0055f;
    private Vector2 location;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        location = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            location.y += moveScale;
        }
        if (Input.GetKey(KeyCode.S))
        {
            location.y -= moveScale;
        }
        if (Input.GetKey(KeyCode.D))
        {
            location.x += moveScale;
        }
        if (Input.GetKey(KeyCode.A))
        {
            location.x -= moveScale;
        }
        rigidBody.MovePosition(location);
    }
}
