using UnityEngine;
using UnityEngine.UI;
using WhyNullName;

public class XDebuggerCanvas : MonoBehaviour
{
    [SerializeField] private XDebuggerWindow _debuggerWindow;
    [SerializeField] private Button _openDebuggerButton;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        _openDebuggerButton.onClick.AddListener(ShowWindow);
    }

    public void InjectCategories(IDebugCategory[] categories)
    {
        _debuggerWindow.InjectCategories(categories);
    }

    public void ShowWindow()
    {
        _debuggerWindow.Show();
    }
}