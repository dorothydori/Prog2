using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedFill : MonoBehaviour
{
    private Image im;
    public static float currentFill;
    public static float filling;

    // Start is called before the first frame update
    void Start()
    {
        im = GetComponent<Image>();
        currentFill = 0;
        filling = (float)0.2;
    }

    // Update is called once per frame
    void Update()
    {
        im.fillAmount = currentFill;
    }

    public static void Fill()
    {
        if (currentFill < 1 && currentFill >= 0)
            currentFill += filling;
        if (currentFill < 0)
            currentFill += 2 * filling;

    }

    public static void Unfill()
    {
        if (currentFill >= 0)
            currentFill -= filling;
    }
}