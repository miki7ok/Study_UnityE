using TMPro;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;

    public void SetContent(string title, string content)
    {
        titleText.text = title;
        contentText.text = content;
    }


    public void ClosePopup()
    {
        Destroy(gameObject);//컴포넌트를 장착한 GameObject를 파괴한다.
    }
}
