using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskSystem
{
    public class GameHandler : MonoBehaviour
    {
        public GameObject worker;

        private void Start()
        {
            //instantiate the Task System
            TaskSystem taskSystem = new TaskSystem();

            Debug.Log(taskSystem.RequestNextTask());
            TaskSystem.Task task = new TaskSystem.Task();
            taskSystem.AddTask(task);
            Debug.Log(taskSystem.RequestNextTask());
            Debug.Log(taskSystem.RequestNextTask());

            //Spawning a worker
            //Worker worker = Worker.Create(0);


            Instantiate(worker);

            taskSystem.AddTask();
            //worker.workerTaskAI.Setup(worker, taskSystem);

            //WorkerTaskAI workerTaskAI = worker.AddComponent<WorkerTaskAI>();
            //workerTaskAI.Setup(worker);

        }
    }
}