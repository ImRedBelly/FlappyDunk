using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject hoop;
    public Text point;
    public int points;
    void Start()
    {
        instance = this;
        StartCoroutine(Spawn());
    }
    void Update()
    {
        point.text = "POINTS: " + points;
    }
    IEnumerator Spawn()
    {
        Vector2 position = transform.position;

        while (true)
        {
            position.x += 6f;
            Instantiate(hoop, position, Quaternion.Euler(0f, 0f, Random.Range(-20f, 50f)));
            yield return new WaitForSeconds(3);
        }
    }
}
