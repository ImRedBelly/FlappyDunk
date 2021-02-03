using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;
    public float maxSpeedX;
    public float maxSpeedY;

    public Text point;
    int points;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartBall();
        }
    }

    private void StartBall()
    {
        //Vector2 force = new Vector3(maxSpeedX, maxSpeedY, 0) * speed;
        //rb.AddForce(force);

     
            var newVelocity = rb.velocity;

            Vector3 force = new Vector3(0.3f, 5, 0) * speed;
            rb.AddForce(force);

            newVelocity.x = maxSpeedX;
            newVelocity.y = maxSpeedY;


            rb.velocity = newVelocity;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trigger"))
        {
            points++;
            point.text = "POINTS: " + points;
            Destroy(collision.transform.parent.gameObject);
        }
    }
}
