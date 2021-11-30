using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grape : MonoBehaviour
{
    [SerializeField] private AudioClip fruit;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            GreenFill.Fill();
            Destroy(this.gameObject);
            SoundManager.instance.PlaySound(fruit);
        }
    }
}
