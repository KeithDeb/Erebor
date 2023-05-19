using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskSystem
{
    public class TaskSystem
    {
        public class Task
        {
            public int position;

        }

        //List of available Tasks to do
        private List<Task> taskList;

        //constructor
        public TaskSystem()
        {
            taskList = new List<Task>();
        }

        public Task RequestNextTask()
        {
            //Worker requesting a task
            if (taskList.Count > 0)
            {
                //task reference/give worker first task
                Task task = taskList[0];
                taskList.RemoveAt(0);

                return task;
            }
            else
            {
                //no tasks available
                return null;
            }
        }

        public void AddTask(Task task)
        {
            //add a task to the list
            taskList.Add(task);
        }

    }
}