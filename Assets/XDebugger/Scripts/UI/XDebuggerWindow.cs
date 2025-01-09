using UnityEngine;
using WhyNullName;

public class XDebuggerWindow : MonoBehaviour
{
    [SerializeField] private DebugUtils _debugUtils;
    private IDebugCategory[] _categories;

    public void InjectCategories(IDebugCategory[] categories)
    {
        _categories = categories;
    }

    public void Show()
    {
        foreach (IDebugCategory category in _categories)
        {
            _debugUtils.CreateDebugButton(category.CategoryName, null);
        }
    }
}