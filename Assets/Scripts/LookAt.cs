using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform ball;

    private void Update()
    {
        transform.position = new Vector3(ball.position.x + 1, transform.position.y, transform.position.z);
    }
}
