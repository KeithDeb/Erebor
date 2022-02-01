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
            //testing
            Debug.Log(taskSystem.RequestNextTask());
            TaskSystem.Task task = new TaskSystem.Task();
            taskSystem.AddTask(task);
            Debug.Log(taskSystem.RequestNextTask());
            Debug.Log(taskSystem.RequestNextTask());
        }


    }
}