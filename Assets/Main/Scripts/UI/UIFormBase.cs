using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public class UIFormBase : UIFormLogic
{
    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
    }

    public void CloseForm()
    {
        GameEntry.UI.CloseUIForm(this.UIForm);
    }
}