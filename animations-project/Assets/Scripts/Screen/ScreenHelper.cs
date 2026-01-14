using System.Collections;
using System.Collections.Generic;
using UnityEngine;

      namespace Screens
{

public class ScreenHelper : MonoBehaviour
{
    public ScreenType screentype;

    public void OnClick()
    {
        ScreenManager.Instance.ShowByType(screentype);
    }
}

}