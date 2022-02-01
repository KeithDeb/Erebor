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
        private float waitingTimer;

        public void Setup(IWorker worker)
        {
            this.worker = worker;
            //initial state
            state = State.WaitingForNextTask;
        }

        private void Update()
        {
            switch (state)
            {
                case State.WaitingForNextTask:
                    //waiting to request new task
                    waitingTimer -= Time.deltaTime;
                    if (waitingTimer <= 0)
                    {
                        //reset timer
                        float waitingTimerMax = .2f; //200ms
                        waitingTimer = waitingTimerMax;
                        RequestNextTask();
                    }
                    break;
            }
        }
        private void RequestNextTask()
        {
            Debug.Log("Request Next Task!!");
        }
    }
}