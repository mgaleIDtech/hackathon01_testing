using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        if (Input.GetKey(KeyCode.W))
            pos.y = pos.y + 1f * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            pos.y = pos.y + -1f * Time.deltaTime;
        else if (Input.GetKey(KeyCode.D))
            pos.x = pos.x + 1f * Time.deltaTime;
        else if (Input.GetKey(KeyCode.A))
            pos.x = pos.x - 1f * Time.deltaTime;

        transform.position = pos;
    }
}
