using UnityEngine;
using System;
using TMPro;

public class DebugButton : MonoBehaviour 
{
    [SerializeField]
    private TextMeshProUGUI _label;

    private Action _onClickAction;

    public void Init(string label, Action onButtonClicked) 
    {
        _label.text = label;
        _onClickAction = null;
        _onClickAction += onButtonClicked;
    }
    
    public void OnButtonClickedHandler()
    {
        _onClickAction?.Invoke();
    }
}