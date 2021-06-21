using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShell : MonoBehaviour
{
    public GameObject shellPrefab;
    public AudioClip sound;
    private int count;

    void Update()
    {
        count += 1;

        if (count % 60 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            shellRb.AddForce(transform.forward * 500);
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
}
