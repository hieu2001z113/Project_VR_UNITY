using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    private Vector3 x;
    private XRGrabInteractable grabInteractable1;
    private XRGrabInteractable grabInteractable2;
    private XRGrabInteractable grabInteractable3;
    private int d = 0;
    //private ExampleScript exampleScript;
    void Start()
    {
        Debug.Log("Tên đối tượng 1 : " + object1.name);
        x = object1.transform.position;
        Debug.Log("o1: " + x);
        
        object2.layer = 4;
        Debug.Log("layer: " + object2.layer);
        //exampleScript= new ExampleScript();
        grabInteractable1 = object1.AddComponent<XRGrabInteractable>();

        // Cài đặt thuộc tính của component XRGrabInteractable

    }

    // Update is called once per frame
    void Update()
    {
        if(grabInteractable1.isSelected && d==0)
        {
            d = 1;
        }
        if(d== 1 && grabInteractable2==null)
        {
            grabInteractable2= object2.AddComponent<XRGrabInteractable>();
            grabInteractable3= object3.AddComponent<XRGrabInteractable>();
        }
    }

}