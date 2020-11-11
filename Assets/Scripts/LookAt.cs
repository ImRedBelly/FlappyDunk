using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform ball;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - ball.position;
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(ball.position.x + offset.x, transform.position.y, transform.position.z);
    }
}
