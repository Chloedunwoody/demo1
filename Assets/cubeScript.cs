using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int myNumber = 1;
    //public int mySecondNumber = 10;
    public float myFloatNumber = 5f;

    void Start()
    {
        //Debug.Log("Started");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Updating...");
        transform.Rotate(1, 0, 0);
    }
}
