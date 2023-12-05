using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public float moveSpeed = 20;

    private Rigidbody2D _rigidbody;
    private SpriteRenderer _spriterenderer;

    private Vector3 directionVector = new Vector3(0, 0, 1);

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriterenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        Debug.Log("NpcMovement started");
        InvokeRepeating("ChangeNpcDirection", Random.Range(0f, 1f), Random.Range(0.2f, 2f));
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        Vector3 newPosition = ((Vector3.Normalize(directionVector) / 100) * moveSpeed) + transform.position;
        _rigidbody.MovePosition(newPosition);
    }

    void ChangeNpcDirection()
    {
        directionVector = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 1);
        _spriterenderer.color = Random.ColorHSV();
    }
}
