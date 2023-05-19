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

        private IWorker worker;
        private TaskSystem taskSystem;
        private State state;
        private float waitingTimer;

        public void Setup(IWorker worker, TaskSystem taskSystem)
        {
            this.worker = worker;
            this.taskSystem = taskSystem;
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

                case State.ExecutingTask:
                    break;
            }
        }
        
        private void RequestNextTask()
        {
            Debug.Log("Request Next Task!!");
            TaskSystem.Task task = taskSystem.RequestNextTask();
            if (task == null)
            {
                state = State.WaitingForNextTask;
            }
            else
            {
                state = State.ExecutingTask;
                ExecuteTask(task);
            }
        }

        private void ExecuteTask(TaskSystem.Task task)
        {
            Debug.Log("Executing Task!!");
            worker.MoveTo(task.position, () => {
                state = State.WaitingForNextTask;
            }); 
        }
    }
}