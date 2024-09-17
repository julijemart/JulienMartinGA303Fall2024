using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Ball;
    public Transform BallSpawnpoint;
    public GameObject tinglesprite;

    // Start is called before the first frame update
    void Start()
    {
        Transform bullet = Instantiate(BallSpawnpoint) as Transform;
        Physics.IgnoreCollision(BallSpawnpoint.GetComponent<Collider>(), GetComponent<Collider>());

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(Ball, BallSpawnpoint.position, BallSpawnpoint.rotation);

            go.GetComponent<Rigidbody>().AddForce(go.transform.up);

        
        }
        
        
    }
}
