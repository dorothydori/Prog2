using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemon : MonoBehaviour
{
    [SerializeField] private AudioClip fruit;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            YellowFill.Fill();
            Destroy(this.gameObject);
            SoundManager.instance.PlaySound(fruit);
        }
    }
}
