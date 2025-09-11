using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public bool flag;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 2; x <= 10; x++)
        {
            float result = Mathf.Pow(2, x);
            Debug.Log($"The value of 2 to the power of {x} is: {result}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}