using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskSystem
{
    public interface IWorker
    {
        void MoveTo(int position, Action onArrivedAtPosition = null);
    }
}