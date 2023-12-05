using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;

    public KeyCode up = KeyCode.W;
    public KeyCode left = KeyCode.A;
    public KeyCode down = KeyCode.S;
    public KeyCode right = KeyCode.D;

    private Rigidbody2D _rigidbody;

    private Vector3 directionVector = new Vector3(0,0,0);

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Debug.Log("PlayerMovement started");
    }

    void Update()
    {
        if (Input.GetKey(up))
        {
            directionVector += Vector3.up * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            directionVector += Vector3.right * -Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            directionVector += Vector3.up * -Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            directionVector += Vector3.right * Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        Vector3 newPosition = ((Vector3.Normalize(directionVector) / 100) * moveSpeed) + transform.position;
        directionVector = new Vector3(0,0,0);
        _rigidbody.MovePosition(newPosition);
    }
}
