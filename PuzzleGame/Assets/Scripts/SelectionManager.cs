using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";

    private Transform _selection;

    private ISelectionResponse _selectionResponse;

    private void Awake()
    {
        _selectionResponse = GetComponent<ISelectionResponse>();
    }

    void Update()
    {
       

        //Deselection/Selection Response
        if (_selection != null)
        {
            _selectionResponse.OnDeselect(_selection);
        }

        #region MyRegion
        //creating a Ray
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        //Selection Determination
        _selection = null;
        if (Physics.Raycast(ray, out var hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                _selection = selection;
            }
        } 
        #endregion

        //Deselection/Selection Response
        if (_selection != null)
        {
            
            _selectionResponse.OnSelect(_selection);

        }

    }
}
