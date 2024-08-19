using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickCoin : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;

    void Start()
    {
        // Assuming you have an AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(soundEffect);
            Destroy(gameObject);
        }
    }
}
