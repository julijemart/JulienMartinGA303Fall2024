using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JMDatatypeUI: MonoBehaviour
{
    public Toggle toggleUI;
    public Image Kirby;
    public GameObject poyo;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (toggleUI.isOn)
        {
            Kirby.rectTransform.Rotate(new Vector3(0f, 30f, 30f));
        }
    }

    void FlipKirby()
    {
        Kirby.rectTransform.Rotate(new Vector3(0f, 30f, 30f));
    }
}
