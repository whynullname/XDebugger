using System.Collections.Generic;

namespace XDebugger
{
    public class XDebugger
    {
        private IDebugCategory[] _debugCategories;
        private XDebuggerWindow _debuggerWindow;

        public void Init(IDebugCategory[] debugCategories)
        {
            _debugCategories = debugCategories;
            //TODO: надо тут типо инициализровать окно и контроллер, хотя по факту дебаггер и может быть контроллером
            InstantiateDebuggerWindow();
        }

        private void InstantiateDebuggerWindow()
        {
            
        }
    }
}