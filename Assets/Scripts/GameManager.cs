using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject hoop;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        Vector2 position = transform.position;

        while (true)
        {
            position.x += 6.0f;
            Instantiate(hoop, position, Quaternion.Euler(0f, 0f, Random.Range(-20f, 50f)));
            yield return new WaitForSeconds(2.0f);
        }
    }
}
