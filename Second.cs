using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second.cs : MonoBehaviour
{
private int[] ids;

    private void Awake()
    {
        Debug.Log("My scond code");
    }


    void Start()
    {
        Debug.Log("My second script towards learning");
    }

  
    void Update()
    {
        Debug.Log("My second script towards learning");
    }

    private void LateUpdate()
    {

    }

    private void OnDestroy()
    {
    ids=null;
    }
}
