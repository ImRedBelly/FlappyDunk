using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{

    public float scrollSpeed;
    public float tielSize;
    Transform currentObject;
    void Start()
    {
        currentObject = GetComponent<Transform>();
    }


    void Update()
    {
        currentObject.position = new Vector3(
            Mathf.Repeat(Time.time * scrollSpeed, tielSize),
            currentObject.position.y,
            currentObject.position.z);
    }
}
