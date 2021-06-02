using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour,ISelectionResponse
{
    private Rigidbody objectRb;

    public void OnDeselect(Transform selection)
    {
        throw new System.NotImplementedException();
    }

    public void OnSelect(Transform selection)
    {
        throw new System.NotImplementedException();
    }

    private void Start()
    {
       
    }
    private void Update()
    {
     
    }

}
