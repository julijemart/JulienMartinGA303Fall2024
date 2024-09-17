using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Color green = new Color(0, 255, 0, 1);
    public MeshRenderer BallRenderer;
    public AudioSource tingle;


    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material.color = green;
            Debug.Log("Tingle, Tingle! Kooloo-Limpah!");

        tingle.Play();

        

    }
}
