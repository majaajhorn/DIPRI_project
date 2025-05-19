using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SimpleCarController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 100f;

    private Rigidbody rb;
    private float moveInput;
    private float turnInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Vertical"); // W/S or Up/Down
        turnInput = Input.GetAxis("Horizontal"); // A/D or Left/Right

        // Move forward/backward
        Vector3 move = transform.forward * moveInput * moveSpeed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + move);

        // Turn left/right
        Quaternion turn = Quaternion.Euler(0f, turnInput * turnSpeed * Time.fixedDeltaTime, 0f);
        rb.MoveRotation(rb.rotation * turn);

        
    }
}


// promijeni da koriti rigidbody umjesto transform komponente