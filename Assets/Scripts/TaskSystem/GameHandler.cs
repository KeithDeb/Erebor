using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskSystem
{
    public class GameHandler : MonoBehaviour
    {
        void Start()
        {
            //instantiate the Task System
            TaskSystem taskSystem = new TaskSystem();

            //Spawning a worker
            Worker worker = Worker.Create(0);
            WorkerTaskAI workerTaskAI = worker.gameObject.AddComponent<WorkerTaskAI>();
            workerTaskAI.Setup(worker);

        }
    }
}