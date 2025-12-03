using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab;
    public Transform canvasTransform;
    public string TitleText;
    public string ContentText;

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform);//팝업창 GameObject를 생성
        Popup popupScript = newPopup.GetComponent<Popup>();//생성한 팝업 GameObject에서 컴포넌트 Popup을 가져온다.

        popupScript.SetContent(this.TitleText, this.ContentText);///가져온 Popup 컴포넌트에서 SetContent 함수를 호출한다.
    }
}

