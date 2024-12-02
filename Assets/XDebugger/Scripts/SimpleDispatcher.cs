using System;
using System.Collections.Generic;
using UnityEngine;

namespace WhyNullName
{
    public class SimpleDispatcher : MonoBehaviour
    {
        private object _lockObject;
        private readonly Queue<Action> _actionsQueue = new Queue<Action>();

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        private void Update()
        {
            if (_actionsQueue.Count > 0)
            {
                lock (_lockObject)
                {
                    _actionsQueue.Dequeue()?.Invoke();
                }
            }
        }

        public void Enqueue(Action action)
        {
            _actionsQueue.Enqueue(action);
        }
    }
}