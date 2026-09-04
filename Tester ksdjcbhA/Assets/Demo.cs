using TMPro;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    private string tempString;
    public void OnClick()
    {
        textbox.text = "I have changed";
    }

}
