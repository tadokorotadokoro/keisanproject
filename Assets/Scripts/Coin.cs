using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float speed;

    void Update()
    {
        // スピードは１
        speed = 1;

        transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime * speed);
    }
}
