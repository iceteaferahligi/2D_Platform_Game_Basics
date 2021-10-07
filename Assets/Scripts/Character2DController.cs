using UnityEngine;

public class Character2DController : MonoBehaviour
{

    public float MovementSpeed = 10;
    public float JumpForce = 10;

    private Rigidbody2D _rigidbody;
    public Animator animator;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;

        animator.SetBool("Moving", false);
        animator.SetBool("Jumping", false);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f) 
        {
            _rigidbody.AddForce(new Vector2(0,JumpForce),ForceMode2D.Impulse);
            animator.SetBool("Jumping", true);
            animator.SetBool("Moving", false);

        }

        //Karakterin yürürken saða sola dönmesini saðlar
        if (!Mathf.Approximately(0, movement))
        {

            if (movement < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                animator.SetBool("Moving", true);
            }
            else
            {
                transform.rotation = Quaternion.identity;
                animator.SetBool("Moving", true);
            }
            //transform.rotation  = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }
}
