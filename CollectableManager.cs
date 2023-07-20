using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    int childCount = 0;
    [HideInInspector] public bool allCoinsCollected = false;

    private void Start()
    {
        childCount = transform.childCount;
    }

    private void Update()
    {
        //Check if the count of child objects has changed
        if (transform.childCount < childCount)
        {
            Debug.Log("A Child Object Has Been Destroyed");
            //Update the childCount variable
            childCount = transform.childCount;

            if (childCount == 0)
            {
                allCoinsCollected=true;
            }
        }
    }
}
