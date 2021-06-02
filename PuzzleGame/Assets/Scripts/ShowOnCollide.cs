using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnCollide : MonoBehaviour
{
    public List<GameObject> molds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
        if (collision.gameObject.name == "ObjectiveTop")
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(molds[0]);
        }
        else if (collision.gameObject.name == "ObjectiveLeft")
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            Destroy(molds[1]);
        }
        else if (collision.gameObject.name == "ObjectiveRight")
        {
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            Destroy(molds[2]);
        }
    }
}
