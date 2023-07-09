using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statements : MonoBehaviour
{
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if(age > 18)
        {
            Debug.Log("You can Vote");
        }
        else
        {
            Debug.Log("You cannot Vote");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
