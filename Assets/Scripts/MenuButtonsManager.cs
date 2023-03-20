using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MenuButtonsManager : MonoBehaviour
{
    public List<GameObject> buttons;
    public float duration;
    public float deley;

    public void OnEnable()
    {
        HideAllButtons();
        showButtons();
    }

    public void HideAllButtons()
    {
        foreach(var b in buttons)
        {
            b.transform.localScale = Vector3.zero;
            b.SetActive(false);
        }
    }

    private void showButtons()
    {
        for(int i = 0; i < buttons.Count; i++ )
        {   
            var b = buttons[i];
            b.SetActive(true);
            b.transform.DOScale(1,duration).SetDelay(i*deley);
        }

    }
}
