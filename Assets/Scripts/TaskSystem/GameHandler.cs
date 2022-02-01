using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskSystem
{
    public class GameHandler : MonoBehaviour
    {
        void Start()
        {
            //instiantate the Task System
            TaskSystem taskSystem = new TaskSystem();

            //Spawning a worker
            //Worker worker = Worker.Create(new int(0));
            //WorkerTaskAI workerTaskAI = worker.gameObject.AddComponet<WorkerTaskAI>();
            //workerTaskAI.Setup(worker);



        }


    }
}