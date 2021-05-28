using UnityEngine;

public class OutLinePaint : MonoBehaviour,ISelectionResponse
{
    public void OnDeselect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if (outline != null) outline.OutlineWidth = 0;
    }

    public void OnSelect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if (outline != null) outline.OutlineWidth = 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
