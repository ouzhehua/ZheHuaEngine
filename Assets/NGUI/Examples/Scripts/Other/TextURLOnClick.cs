using System;
using UnityEngine;
using UnityEngine.Events;

public class TextURLOnClick : MonoBehaviour
{
    [Serializable]
    public class URLEventTrigger : UnityEvent { }
    [SerializeField]
    private URLEventTrigger onClickURL = new URLEventTrigger();

    /// <summary>
    /// Use In Call Back Function
    /// </summary>
    public static string currentURL;
    void OnClick()
    {
        UILabel lbl = GetComponent<UILabel>();

        if (lbl != null)
        {
            string url = lbl.GetUrlAtPosition(UICamera.lastWorldPosition);
            if (!string.IsNullOrEmpty(url))
            {
                if (onClickURL != null && onClickURL.GetPersistentEventCount() > 0)
                {
                    currentURL = url;
                    onClickURL.Invoke();
                    currentURL = null;
                }
            }
        }
    }
}