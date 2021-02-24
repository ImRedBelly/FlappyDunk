using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject backgroundOne;
    public GameObject backgroundTwo;

    bool isChange = true;

    float step = 28.9f;



    void Update()
    {
        if (step < Ball.instance.transform.position.x && isChange)
        {
            isChange = false;

            step += 28.9f;
            backgroundOne.transform.position = new Vector2(step, 0);
        }
        else if (step < Ball.instance.transform.position.x && !isChange)
        {

            isChange = true;

            step += 28.9f;
            backgroundTwo.transform.position = new Vector2(step, 0);
        }
    }
}
