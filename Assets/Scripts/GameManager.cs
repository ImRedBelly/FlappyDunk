using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform ball;//озиция мяча
    public GameObject hoop;//акой объект спавню

    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn() // спавн колец
    {
        Vector2 position = transform.position;
        while (true)
        {

            position.x += 6.0f;

            Instantiate(hoop, position,Quaternion.Euler(90f, 0f, Random.Range(-20f, 50f)));

            yield return new WaitForSeconds(2.0f);
        }
    }
}
