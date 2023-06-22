using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HuongDanLap : MonoBehaviour
{
    public Button nextbtn;
    public Button prebtn;
    private int index;
    public TextMeshProUGUI textMesh;
    private string[] mess = new string[45];
    private string qtl ;
    // Start is called before the first frame update
    void Start()
    {
        qtl = "QUY TRÌNH LẮP";
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
        textMesh.text =qtl+ "\n\nBước "+(index+1)+" : "+ mess[0];
        nextbtn.onClick.AddListener(OnButtonNext);
        prebtn.onClick.AddListener(OnButtonPre);
    }
    private void OnButtonNext()
    {
        index++;
        if(index >43){
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
        textMesh.text = qtl+"\n\nBước "+(index+1)+" : "+ mess[index];
    }
}
