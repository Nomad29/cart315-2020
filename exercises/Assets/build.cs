using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour
{
    public GameObject thecamera;
    public GameObject create;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count = count + 1;
        if (count <= 3) count = 0;
        if (Input.GetMouseButton(1) && count == 0)
        {
            RaycastHit hit;
            Ray ray = thecamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject.Instantiate(create, hit.point, Quaternion.identity);
            }
        }
    }
}
