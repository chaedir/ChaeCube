using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SidewayForce = 500f;

	// We used "Fixed"Update because we are
    // using it to mess with physics.
	void FixedUpdate () {
        // Add a forward force on the z-axis.
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); /*ForceMode utk mengambil 
            property tertentu dari Forcemode itu, saya memilih "VelocityChange" yang berfungsi untuk menghiraukan
            mass dari objek yang ada*/
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().RestarLevel();
        }
	}
}
