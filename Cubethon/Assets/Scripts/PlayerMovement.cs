using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	
	// Use FixedUpdate for doing physics stuff
	void FixedUpdate()
	{
		// use deltaTime to prevent force being dependant on framerate
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);	// add a forward force

        if (Input.GetKey("d"))
        {
            // add force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            // add force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
