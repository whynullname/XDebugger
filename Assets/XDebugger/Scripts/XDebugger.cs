using UnityEngine;

namespace WhyNullName
{
    public class XDebugger
    {
        private const string CanvasName = "XDebuggerCanvas";

        private IDebugCategory[] _debugCategories;
        private XDebuggerCanvas _debuggerCanvas;
        private SimpleDispatcher _simpleDispatcher;

        public XDebugger(IDebugCategory[] debugCategories, bool initInMainThread = true)
        {
            _debugCategories = debugCategories;
            InstantiateDispatcher();

            if (initInMainThread)
            {
                _simpleDispatcher.Enqueue(() => InstantiateDebuggerCanvas(debugCategories));
            }
            else
            {
                InstantiateDebuggerCanvas(debugCategories);
            }
        }

        private void InstantiateDispatcher()
        {
            var dispatcherGo = new GameObject("Debugger Simple Disaptcher");
            _simpleDispatcher = dispatcherGo.AddComponent<SimpleDispatcher>();
        }

        private void InstantiateDebuggerCanvas(IDebugCategory[] categories)
        {
            var canvasPrefab = Resources.Load<XDebuggerCanvas>(CanvasName);

            if (canvasPrefab == null)
            {
                Debug.LogError($"[XDebugger] - Can't load debug canvas!");
                return;
            }

            _debuggerCanvas = Object.Instantiate(canvasPrefab);
            _debuggerCanvas.InjectCategories(categories);
        }
    }
}