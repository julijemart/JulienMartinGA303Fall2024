using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HWDatatypeEquation : MonoBehaviour
{

    public int num1;
    public long num2;
    public float num3 = 30;

    public int additionTotal;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting total is 1" + additionTotal);
        additionTotal = additionTotal + num1;
        Debug.Log("Added 1" + num1 + "to additionTotal, making additionTotal 2" + 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
