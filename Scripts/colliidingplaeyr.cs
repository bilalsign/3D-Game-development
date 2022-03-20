using UnityEngine;

public class colliidingplaeyr : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5;
    public bool isOnGround = true;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody rb;
    // Update is called once per frame

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime* speed * horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("plane"))
        {
            isOnGround = true;
        }
    }
}
