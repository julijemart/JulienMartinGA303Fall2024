using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemover : MonoBehaviour
{
    public List<GameObject> cubesquad;
    // Start is called before the first frame update

    public Vector3 scaleChange, positionChange;
    void Start()
    {
        //cubesquad[0].transform.position += new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0;i<cubesquad.Count;i++)
        {
            cubesquad[i].transform.position += new Vector3(0, 3, 0) * Time.deltaTime;
        }
        foreach (GameObject ONEcube in cubesquad)
        {
            ONEcube.transform.Rotate(20 * Time.deltaTime , 0, 0);
        }
        for (int i = 2;i<cubesquad.Count;i++)
        {
            cubesquad[i].transform.localScale += scaleChange = new Vector3(0.001f, 0.001f, 0.001f);
        }
    }
}
