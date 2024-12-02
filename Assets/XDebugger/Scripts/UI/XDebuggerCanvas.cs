using UnityEngine;

public class XDebuggerCanvas : MonoBehaviour
{
    [SerializeField]
    private XDebuggerWindow _debuggerWindow;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}