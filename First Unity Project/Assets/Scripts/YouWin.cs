using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{
    public GameObject youWinPanel;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (RedFill.currentFill == 1 && YellowFill.currentFill == 1 && GreenFill.currentFill == 1 && BlueFill.currentFill == 1 && PurpleFill.currentFill == 1)
        {
            Destroy(player.gameObject);
            youWinPanel.SetActive(true);
        }
    }
}
