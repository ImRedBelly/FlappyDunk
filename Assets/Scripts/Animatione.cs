using UnityEngine;

public class Animatione : MonoBehaviour
{
    void Start()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play("Ball");
    }
    public void OnAnim()
    {
        Debug.Log("Trigg");
    }

}
