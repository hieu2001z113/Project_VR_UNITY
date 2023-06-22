using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HuongDanThao : MonoBehaviour
{
    public Button nextbtn;
    public Button prebtn;
    private int index;
    private string qtt;
    public TextMeshProUGUI textMesh;
    private string[] mess = new string[29];
    // Start is called before the first frame update
    void Start()
    {
        qtt="QUY TRÌNH THÁO";
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
        textMesh.text =qtt+ "\n\nBước "+(index+1)+" : "+ mess[0];
        nextbtn.onClick.AddListener(OnButtonNext);
        prebtn.onClick.AddListener(OnButtonPre);
    }


    private void OnButtonNext()
    {
        index++;
        if(index >27){
            index = 27;
        }
        
    }
    private void OnButtonPre()
    {
        index--;
        if(index<0){
            index=0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        textMesh.text = qtt+ "\n\nBước "+(index+1)+" : "+ mess[index];
    }
}
