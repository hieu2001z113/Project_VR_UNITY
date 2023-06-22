using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
public class AddXRGrab : MonoBehaviour
{
    /* public float outlineWidth;
     public Color outlineColor;*/
    // Start is called before the first frame update
    public TextMeshProUGUI textMesh;
    private GameObject[] targets;
    private bool[] check;
    private int d = 1;
    private int k = 0;
    private string[] mess = new string[29];
    void Start()
    {

        
        mess[0]= "Tháo các bộ phận trên nắp mặt trước động cơ";
        mess[1]= "Tháo ốc cố định nắp mặt trước động cơ";
        mess[2]= "Tháo ốc cố định trục cam";
        mess[3]= "Tháo gioăng";
        mess[4]= "Tháo ốc cố định mặt sau ốp bảo vệ dây cu loa";
        mess[5]= "Tháo bộ chia điện";
        mess[6]= "Tháo bộ góp nạp";
        mess[7]= "Tháo chốt cố định trục vs bánh quay";
        mess[8]= "Tháo tháo bánh quay";
        mess[9]= "Tháo ốp bảo vệ dây cu loa";
        mess[10]= "Tháo bánh răng và dây truyền";
        mess[11]= "Tháo ốp bảo vệ và dây cu loa";
        mess[12]= "Tháo ống xả phụ";
        mess[13]= "Tháo trục cam";
        mess[14]= "Tháo ốc giữ xupap";
        mess[15]= "Tháo ốc cố định mặt trước";
        mess[16]= "Tháo ống xả chính";
        mess[17]= "Tháo mặt trước";
        mess[18]= "Tháo xupap";
        mess[19]= "Tháo xi lanh";
        mess[20]= "Tháo xéc măng";
        mess[21]= "Tháo chốt pít tông";
        mess[22]= "Tháo bánh đà";
        mess[23]= "Tháo đáy các te";
        mess[24]= "Tháo tay biên";
        mess[25]= "Tháo các te";
        mess[26]= "Tháo trục khuỷu";
        mess[27]= "Tháo bugi";
        textMesh.text = "<color=green><i>" + mess[0] + "</i></color>";
        targets = GameObject.FindGameObjectsWithTag(d.ToString());
        check = new bool[targets.Length];
        //Debug.Log(check.Length);
        foreach (var i in targets)
        {
            //add them component:
            if (i.GetComponent<XRGrabInteractable>() == null)
            {
                i.AddComponent<Rigidbody>().useGravity = false;
                i.AddComponent<XRGrabInteractable>();
                i.AddComponent<Outline>().OutlineColor= Color.red;
                i.GetComponent<Outline>().OutlineWidth = 5f;
            }
        }
    }
    // Update is called once per frame
    private int x=-1;
    void Update()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            if (check[i] == false && targets[i].GetComponent<XRGrabInteractable>().isSelected)
            {
                check[i] = true;
                x = i;
            }
            if (check[i]){
                //targets[i].GetComponent<Outline>().OutlineColor = color.green;
                MeshCollider collider  = targets[i].GetComponent<MeshCollider>();
                collider.isTrigger= false;
                targets[i].GetComponent<Rigidbody>().useGravity = true;
                Outline mau = targets[i].GetComponent<Outline>();
                if(mau!= null){
                    Destroy(mau);
                }
                
            } 

        }
        if (check.All(b => b == true) && !targets[x].GetComponent<XRGrabInteractable>().isSelected)
        {
            //Debug.Log(x);
            x = -1;
            
            k++;
            hthi(d-1);
            d++;
            Array.Clear(targets, 0, targets.Length);
            Array.Clear(check, 0, check.Length);
            if (GameObject.FindGameObjectsWithTag(d.ToString()).Length != 0)
            {
                targets = GameObject.FindGameObjectsWithTag(d.ToString());
                check = new bool[targets.Length];
                foreach (var i in targets)
                {
                    //add them component:
                    if (i.GetComponent<XRGrabInteractable>() == null)
                    {
                        i.AddComponent<Rigidbody>().useGravity = false;
                        i.AddComponent<XRGrabInteractable>();
                        i.AddComponent<Outline>().OutlineColor = Color.red;
                        i.GetComponent<Outline>().OutlineWidth = 5f;
                    }
                }
            }
            else
                enabled = false;
        }
        else
        {
            //Debug.Log("Sai");
        }

    }
    void hthi(int j){
        if(j==3){
            textMesh.text = "<color=green><i>" + mess[1] + "</i></color>";
        }
        if(j==5){
            textMesh.text = "<color=green><i>" + mess[2] + "</i></color>";
        }
        if(j==9){
            textMesh.text = "<color=green><i>" + mess[3] + "</i></color>";
        }if(j==10){
            textMesh.text = "<color=green><i>" + mess[4] + "</i></color>";
        }if(j==12){
            textMesh.text = "<color=green><i>" + mess[5] + "</i></color>";
        }if(j==13){
            textMesh.text = "<color=green><i>" + mess[6] + "</i></color>";
        }if(j==15){
            textMesh.text = "<color=green><i>" + mess[7] + "</i></color>";
        }if(j==16){
            textMesh.text = "<color=green><i>" + mess[8] + "</i></color>";
        }if(j==17){
            textMesh.text = "<color=green><i>" + mess[9] + "</i></color>";
        }if(j==18){
            textMesh.text = "<color=green><i>" + mess[10] + "</i></color>";
        }if(j==19){
            textMesh.text = "<color=green><i>" + mess[11] + "</i></color>";
        }if(j==22){
            textMesh.text = "<color=green><i>" + mess[12] + "</i></color>";
        }if(j==25){
            textMesh.text = "<color=green><i>" + mess[13] + "</i></color>";
        }if(j==27){
            textMesh.text = "<color=green><i>" + mess[14] + "</i></color>";
        }if(j==28){
            textMesh.text = "<color=green><i>" + mess[15] + "</i></color>";
        }if(j==29){
            textMesh.text = "<color=green><i>" + mess[16] + "</i></color>";
        }if(j==32){
            textMesh.text = "<color=green><i>" + mess[17] + "</i></color>";
        }if(j==33){
            textMesh.text = "<color=green><i>" + mess[18] + "</i></color>";
        }if(j==35){
            textMesh.text = "<color=green><i>" + mess[19] + "</i></color>";
        }if(j==36){
            textMesh.text = "<color=green><i>" + mess[20] + "</i></color>";
        }if(j==37){
            textMesh.text = "<color=green><i>" + mess[21] + "</i></color>";
        }if(j==38){
            textMesh.text = "<color=green><i>" + mess[22] + "</i></color>";
        }if(j==40){
            textMesh.text = "<color=green><i>" + mess[23] + "</i></color>";
        }if(j==41){
            textMesh.text = "<color=green><i>" + mess[24] + "</i></color>";
        }if(j==42){
            textMesh.text = "<color=green><i>" + mess[25] + "</i></color>";
        }if(j==44){
            textMesh.text = "<color=green><i>" + mess[26] + "</i></color>";
        }if(j==46){
            textMesh.text = "<color=green><i>" + mess[27] + "</i></color>";
        }if(j==48){
            textMesh.text = "<color=green><i>" + mess[28] + "</i></color>";
        }
    }
    /*void FixedUpdate()
    {
        targets[targets.Length - 1].AddComponent<Rigidbody>().useGravity = true;
    }*/
}