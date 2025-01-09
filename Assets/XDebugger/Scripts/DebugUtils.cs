using System;
using UnityEngine;

public class DebugUtils : MonoBehaviour 
{
    [SerializeField] private DebugButton _debugButton;
    [SerializeField] private Transform _content;

    //TODO: Надо это все прокинуть через пулы и фабрику
    public void CreateDebugButton(string label, Action onButtonClicked)
    {
        var button = Instantiate(_debugButton, _content);
        button.Init(label, onButtonClicked);
    }
}