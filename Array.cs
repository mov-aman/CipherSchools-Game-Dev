using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //public int student1 = 1;
    //public int student2 = 2;
    public int[] myArray = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < myArray.Length; i++)
        {
            Debug.Log("Value : " + myArray[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
