using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastFood : MonoBehaviour
{
    [SerializeField] private AudioClip fastfood;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            RedFill.Unfill();
            YellowFill.Unfill();
            GreenFill.Unfill();
            BlueFill.Unfill();
            PurpleFill.Unfill();
            Destroy(this.gameObject);
            SoundManager.instance.PlaySound(fastfood);
        }
    }
}

