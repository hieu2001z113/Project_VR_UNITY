using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectGrabbing : MonoBehaviour
{
    
    public XRGrabInteractable firstObject; // đối tượng thứ nhất
    public XRGrabInteractable secondObject; // đối tượng thứ hai

    private void Start()
    {
        // Khởi đầu, ta chỉ đặt secondObject có thể tương tác với layer mặc định của nó
        secondObject.interactionLayerMask = LayerMask.GetMask("Nothing");
    }

    private void Update()
    {
        // Nếu đối tượng thứ nhất đang được cầm
        if (firstObject.isSelected)
        {
            // Đặt secondObject có thể tương tác với tất cả các layer
            secondObject.interactionLayerMask = LayerMask.GetMask("Everything");
        }
        else
        {
            // Nếu đối tượng thứ nhất không được cầm, ta đặt secondObject lại chỉ có thể tương tác với layer mặc định của nó
            secondObject.interactionLayerMask = LayerMask.GetMask("Nothing");
        }
    }
}


