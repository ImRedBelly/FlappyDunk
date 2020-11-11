using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;
    public float maxSpeedX;
    public float maxSpeedY;

    public Text point; // текст очков

    int points; //очки

    void Update()
    {

        point.text = "POINTS: " + points;
        if (Input.GetMouseButtonDown(0))
        {

            StartBall();

        }

    }

   public void StartBall()
    {
        var newVelocity = rb.velocity;

        Vector3 force = new Vector3(0.3f, 5, 0) * speed;
        rb.AddForce(force);

        newVelocity.x = maxSpeedX;
        newVelocity.y = maxSpeedY;


        rb.velocity = newVelocity;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
    }
    void OnTriggerExit(Collider collision)   // проверяю коллизию с кольцом 
    {
        if (collision.gameObject.tag == "Hoop")
        {
            points++;
            Destroy(GameObject.FindWithTag("Hoop"));
        }
    }

}
