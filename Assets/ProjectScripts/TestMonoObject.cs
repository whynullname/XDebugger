using System.Collections.Generic;
using UnityEngine;
using WhyNullName;

public class TestMonoObject : MonoBehaviour
{
    private void Awake()
    {
        List<IDebugCategory> categories = new List<IDebugCategory>() { new TestDebugCategory() };
        //Надо протестировать в Zenject и похожих штуках, по идеи диспатчер должен норм инстанцироваться и туда все прокинуться, но все же
        new XDebugger(categories.ToArray());
    }
}