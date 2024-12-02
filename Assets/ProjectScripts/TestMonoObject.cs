using UnityEngine;
using WhyNullName;

public class TestMonoObject : MonoBehaviour
{
    private void Awake()
    {
        //Надо протестировать в Zenject и похожих штуках, по идеи диспатчер должен норм инстанцироваться и туда все прокинуться, но все же
        new XDebugger(null);
    }
}