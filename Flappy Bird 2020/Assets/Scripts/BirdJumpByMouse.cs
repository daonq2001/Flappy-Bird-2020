using UnityEngine;

public class BirdJumpByMouse : MonoBehaviour
{
    Rigidbody2D rb2D;
    public float jumpForce = 10f;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            if(rb2D.velocity.y != jumpForce)
            {
                rb2D.velocity = new Vector2(rb2D.transform.position.x, 10f);
            }
        }
    }
}
