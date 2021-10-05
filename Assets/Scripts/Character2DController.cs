using UnityEngine;

public class Character2DController : MonoBehaviour
{

    public float MovementSpeed = 10;
    public float JumpForce = 10;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f) 
        {
            _rigidbody.AddForce(new Vector2(0,JumpForce),ForceMode2D.Impulse);
        }

        //Karakterin yürürken saða sola dönmesini saðlar
        if(!Mathf.Approximately(0,movement))
        {

            if(movement > 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                transform.rotation = Quaternion.identity;
            }
            //transform.rotation  = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }
}
