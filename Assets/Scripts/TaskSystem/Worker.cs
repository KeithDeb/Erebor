using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskSystem
{
    public class Worker : IWorker
    {
        private int position;
        public GameObject gameObject;

        public static Worker Create(int position)
        {
            return new Worker(position);
        }

        private Worker(int position)
        {

        }

        public void MoveTo(int position, Action onArrivedAtPosition = null)
        {

        }

        public int GetPosition()
        {
            return this.position;
        }

    }
}