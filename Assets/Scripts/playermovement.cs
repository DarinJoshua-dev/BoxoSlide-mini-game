using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Force=2000f;
    public float sideForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Force * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        } 
        if(rb.position.y <= 0.70f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
