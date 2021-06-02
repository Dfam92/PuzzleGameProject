using UnityEngine;

public class OutLinePaint : MonoBehaviour,ISelectionResponse
{
    private bool isSelected = false;

    public void OnDeselect(Transform selection)
    {
        if(Input.GetKeyDown(KeyCode.Mouse1) && isSelected)
        {
            var outline = selection.GetComponent<Outline>();
            if (outline != null) outline.OutlineWidth = 0;
            isSelected = false;
            selection.gameObject.GetComponent<PlayerControl>().enabled = false;
        }
       
    }

    public void OnSelect(Transform selection)
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && !isSelected)
        {
            var outline = selection.GetComponent<Outline>();
            if (outline != null) outline.OutlineWidth = 10;
            isSelected = true;
            selection.gameObject.GetComponent<PlayerControl>().enabled = true;
        }
       
       
        
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
