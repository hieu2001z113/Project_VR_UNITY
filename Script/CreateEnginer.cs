using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class CreateEnginer : MonoBehaviour
{
   /* public float outlineWidth;
     public Color outlineColor;*/
    // Start is called before the first frame update
    public TextMeshProUGUI textMesh;
    private GameObject[] targets; // các đối tượng cần phải tương tác
    private GameObject[] sokets;// vị trí đúng của từng đối tượnbg khi tháo lap

    private GameObject[] starts;// vị trí ban đầu của những đối tượng cần được lắp vào 
    private bool[] check;
    private int d = 2000;
    private int e = 1000;
    private int k = 0;
    private string layerName;
    private float positionThreshold = 0.001f;
    //private float rotationThreshold = 0.1f;
    private string[] mess = new string[45];
    void Start()
    {
        


        mess[0]= "Lắp bugi vào đúng vị trí";
        mess[1]= "Lắp trục khuỷu";
        mess[2]= "Lắp bộ chia điện";
        mess[3]= "Lắp dây truyền, bánh răng, chốt cố định";
        mess[4]="Lắp ốc bảo vệ dây cu loa";
        mess[5]="Lắp bánh quay và dây cu loa";
        mess[6]="Lắp tay biên";
        mess[7]="Lắp chốt tay biên";
        mess[8]="Lắp xéc măng";
        mess[9]="Lắp xi lanh";
        mess[10]="Lắp tay biên";
        mess[11]="Lắp chốt tay biên";
        mess[12]="Lắp xéc măng";
        mess[13]="Lắp pít tông";
        mess[14]="Lắp tay biên và trục khuỷu";
        mess[15]="Lắp các te";
        mess[16]="Lắp đáy các te";
        mess[17]="Lắp bánh đà";
        mess[18]="Lắp bộ chia điện";
        mess[19]="Lắp dây cu loa, bánh xa và chốt cố định";
        mess[20]="Lắp bộ góp nạp";
        mess[21]="Lắp chốt ốp bảo vệ dây truyền, dây cu loa";
        mess[22]="";
        mess[23]="Lắp ống xả phụ";
        mess[24]="Lắp xupap";
        mess[25]="Lắp lò xo xupap";
        mess[26]="Lắp mặt trước";
        mess[27]="Lắp ống xả chính";
        mess[28]="Lắp ốc cố định mặt trước";
        mess[29]="Lắp ốc cố định ống xả phụ";
        mess[30]="Lắp gioăng";
        mess[31]="Lắp trục cam";
        mess[32]="Lắp ốp bảo vệ bánh răng";
        mess[33]="Lắp ốc cố định trục cam";
        mess[34]="Lắp xupap";
        mess[35]="Lắp mặt trước";
        mess[36]="Lắp ốc cố định ống xả phụ";
        mess[37]="Lắp ốc cố định mặt trước";
        mess[38]="Lắp ống xả chính";
        mess[39]="Lắp gioăng";
        mess[40]="Lắp trục cam";
        mess[41]="Lắp ốc cố định trục cam";
        mess[42]="Lắp nắp mặt trước";
        mess[43]="Lắp ráp thành công";

        textMesh.text = "<color=green><i>" + mess[0] + "</i></color>";
        targets = GameObject.FindGameObjectsWithTag(d.ToString());
        sokets = GameObject.FindGameObjectsWithTag(e.ToString());
        starts = GameObject.FindGameObjectsWithTag("3000");

        // Debug.Log("The "+ d+" co: " + targets.Length);
        // Debug.Log("The "+ e+" co: " + sokets.Length);
        check = new bool[targets.Length];
        
        

        
        for(int i = 0; i<targets.Length ; i++)
        {
            
            //add them component:
            if (targets[i].GetComponent<XRGrabInteractable>() == null )
            {
                
                targets[i].AddComponent<Rigidbody>().useGravity = false;
                targets[i].AddComponent<XRGrabInteractable>();

                
                
            }
            //starts[i].GetComponent<XRSocketInteractor>().startingSelectedInteractable = targets[i].GetComponent<XRGrabInteractable>();
            //starts[i].GetComponent<XRSocketInteractor>().startingSelectedInteractable = targets[i].GetComponent<XRGrabInteractable>();
            targets[i].transform.position = starts[i].transform.position;
            targets[i].AddComponent<Outline>().OutlineColor= Color.blue;
            targets[i].GetComponent<Outline>().OutlineWidth = 5f;
            
        }
    }
    // Debug.Log("target: "+targets[i].transform.position);
    //         Debug.Log("Soket: "+sokets[i].transform.position);
    //         Debug.Log("target: "+targets[i].transform.rotation);
    //         Debug.Log("Soket: "+sokets[i].transform.rotation);
    // Update is called once per frame
    //private int x=-1;
    void Update()
    {
        for (int i = 0; i < targets.Length; i++)
        {   
            
            if (check[i] == false  && Vector3.Distance(targets[i].transform.position, sokets[i].transform.position) < positionThreshold )
            {
                check[i] = true;
                //x = i;
            }
            if (check[i] ){
                //targets[i].GetComponent<Rigidbody>().useGravity=false;
                targets[i].GetComponent<Outline>().OutlineColor = Color.green;
                MeshCollider collider  = targets[i].GetComponent<MeshCollider>();
                collider.isTrigger= true;
                XRGrabInteractable grabInteractable = targets[i].GetComponent<XRGrabInteractable>();
                
                if(grabInteractable !=null){
                    Destroy(grabInteractable);
                }
            } 

        }
        //Debug.Log(check.Length );
        if (check.All(b => b == true) )
        {
            //Debug.Log(check.Length + " alo alo alo alo alo    "+ sokets.Length);
            //Debug.Log(x);
            //x = -1;
            
            //k++;
            hthi(d-1);
            d--;
            e--;
            Array.Clear(targets, 0, targets.Length);
            Array.Clear(check, 0, check.Length);
            Array.Clear(sokets, 0, sokets.Length);
            Array.Clear(starts, 0, starts.Length);
            targets = GameObject.FindGameObjectsWithTag(d.ToString());
            sokets = GameObject.FindGameObjectsWithTag(e.ToString());
            check = new bool[targets.Length];
            starts = GameObject.FindGameObjectsWithTag("3000");
            if(starts.Length==null){
                Debug.Log("Khong co the 3000");
            }
            Debug.Log("The "+ d+" co: " + targets.Length);
                
            Debug.Log("The "+ e+" co: " + sokets.Length);
            Debug.Log("The 3000 co: " + starts.Length);
            if (GameObject.FindGameObjectsWithTag(d.ToString()).Length != null)
            {
                
                
                for (int i = 0;i<targets.Length;i++)
                {
                    //add them component:
                    if (targets[i].GetComponent<XRGrabInteractable>() == null)
                    {
                        targets[i].AddComponent<Rigidbody>().useGravity = false;
                        targets[i].AddComponent<XRGrabInteractable>();
                        //targets[i].AddComponent<XRGrabInteractable>().
                        targets[i].AddComponent<Outline>().OutlineColor = Color.blue;
                        targets[i].GetComponent<Outline>().OutlineWidth = 5f;
                    }
                    targets[i].transform.position = starts[i].transform.position;
                }
            }
            else
                Debug.Log("Khong co the : "+ d);
        }

        void hthi(int j){
            
            if(j==1996){
                textMesh.text = "<color=green><i>" + mess[1] + "</i></color>";   
            }
            if(j==1994){
                textMesh.text = "<color=green><i>" + mess[2] + "</i></color>";   
            }if(j==1986){
                textMesh.text = "<color=green><i>" + mess[3] + "</i></color>";   
            }if(j==1977){
                textMesh.text = "<color=green><i>" + mess[4] + "</i></color>";   
            }if(j==1976){
                textMesh.text = "<color=green><i>" + mess[5] + "</i></color>";   
            }if(j==1974){
                textMesh.text = "<color=green><i>" + mess[6] + "</i></color>";   
            }if(j==1970){
                textMesh.text = "<color=green><i>" + mess[7] + "</i></color>";   
            }if(j==1969){
                textMesh.text = "<color=green><i>" + mess[8] + "</i></color>";   
            }if(j==1968){
                textMesh.text = "<color=green><i>" + mess[9] + "</i></color>";   
            }if(j==1964){
                textMesh.text = "<color=green><i>" + mess[10] + "</i></color>";   
            }if(j==1960){
                textMesh.text = "<color=green><i>" + mess[11] + "</i></color>";   
            }if(j==1959){
                textMesh.text = "<color=green><i>" + mess[12] + "</i></color>";   
            }if(j==1958){
                textMesh.text = "<color=green><i>" + mess[13] + "</i></color>";   
            }if(j==1957){
                textMesh.text = "<color=green><i>" + mess[14] + "</i></color>";   
            }if(j==1945){
                textMesh.text = "<color=green><i>" + mess[15] + "</i></color>";   
            }if(j==1943){
                textMesh.text = "<color=green><i>" + mess[16] + "</i></color>";   
            }if(j==1940){
                textMesh.text = "<color=green><i>" + mess[17] + "</i></color>";   
            }if(j==1938){
                textMesh.text = "<color=green><i>" + mess[18] + "</i></color>";   
            }if(j==1937){
                textMesh.text = "<color=green><i>" + mess[19] + "</i></color>";   
            }if(j==1931){
                textMesh.text = "<color=green><i>" + mess[20] + "</i></color>";   
            }if(j==1927){
                textMesh.text = "<color=green><i>" + mess[21] + "</i></color>";   
            }if(j==1914){
                textMesh.text = "<color=green><i>" + mess[22] + "</i></color>";   
            }if(j==1911){
                textMesh.text = "<color=green><i>" + mess[23] + "</i></color>";   
            }if(j==1908){
                textMesh.text = "<color=green><i>" + mess[24] + "</i></color>";   
            }if(j==1907){
                textMesh.text = "<color=green><i>" + mess[25] + "</i></color>";   
            }if(j==1905){
                textMesh.text = "<color=green><i>" + mess[26] + "</i></color>";   
            }if(j==1904){
                textMesh.text = "<color=green><i>" + mess[27] + "</i></color>";   
            }if(j==1899){
                textMesh.text = "<color=green><i>" + mess[28] + "</i></color>";   
            }if(j==1898){
                textMesh.text = "<color=green><i>" + mess[29] + "</i></color>";   
            }if(j==1897){
                textMesh.text = "<color=green><i>" + mess[30] + "</i></color>";   
            }if(j==1896){
                textMesh.text = "<color=green><i>" + mess[31] + "</i></color>";   
            }if(j==1895){
                textMesh.text = "<color=green><i>" + mess[32] + "</i></color>";   
            }if(j==1893){
                textMesh.text = "<color=green><i>" + mess[33] + "</i></color>";   
            }if(j==1883){
                textMesh.text = "<color=green><i>" + mess[34] + "</i></color>";   
            }if(j==1889){
                textMesh.text = "<color=green><i>" + mess[35] + "</i></color>";   
            }if(j==1887){
                textMesh.text = "<color=green><i>" + mess[36] + "</i></color>";   
            }if(j==1886){
                textMesh.text = "<color=green><i>" + mess[37] + "</i></color>";   
            }if(j==1885){
                textMesh.text = "<color=green><i>" + mess[38] + "</i></color>";   
            }if(j==1884){
                textMesh.text = "<color=green><i>" + mess[39] + "</i></color>";   
            }if(j==1880){
                textMesh.text = "<color=green><i>" + mess[40] + "</i></color>";   
            }if(j==1879){
                textMesh.text = "<color=green><i>" + mess[41] + "</i></color>";   
            }if(j==1873){
                textMesh.text = "<color=green><i>" + mess[42] + "</i></color>";   
            }if(j==1872){
                textMesh.text = "<color=green><i>" + mess[43] + "</i></color>";   
            }if(j==1870){
                textMesh.text = "<color=green><i>" + mess[44] + "</i></color>";   
            }
        }
        // else
        // {
        //     //Debug.Log("Sai +1");
        // }

    }
    /*void FixedUpdate()
    {
        targets[targets.Length - 1].AddComponent<Rigidbody>().useGravity = true;
    }*/
}
