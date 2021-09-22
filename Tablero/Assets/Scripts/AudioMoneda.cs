using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMoneda : MonoBehaviour
{
    public AudioClip clip;
    public float volumen = 1;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position, volumen);
    }
}
