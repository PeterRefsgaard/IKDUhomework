using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * 10f * Time.deltaTime,
            Input.GetAxis("Vertical") * 10f * Time.deltaTime, 0f);
    }
}
