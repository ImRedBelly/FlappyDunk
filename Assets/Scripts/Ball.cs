using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public float upForce;



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FlapBall();
        }
    }

    private void FlapBall()
    {
        animator.SetTrigger("Fly");
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.3f, 1) * upForce, ForceMode2D.Impulse);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trigger"))
        {
            GameManager.instance.points++;
            Destroy(collision.transform.parent.gameObject);
        }
    }
}
