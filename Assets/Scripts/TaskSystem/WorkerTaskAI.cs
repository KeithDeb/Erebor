using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskSystem
{
    public class WorkerTaskAI : MonoBehaviour
    {
        //set of states of the worker
        private enum State
        {
            WaitingForNextTask,
            ExecutingTask,
        }
        private WorkerTaskAI worker;
        private State state;
        public void Setup(IWorker worker)
        {
            this.worker = worker;
        }
    }
}