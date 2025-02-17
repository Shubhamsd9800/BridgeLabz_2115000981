﻿using System;

namespace CustomTaskScheduler
{
    public class TaskNode
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;

        public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskID = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = this;
        }
    }

    public class TaskScheduler
    {
        private TaskNode head = null;
        private TaskNode current = null;

        public void AddTaskAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                TaskNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
                head = newNode;
            }
            if (current == null)
                current = head;
        }

        public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                TaskNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
            }
            if (current == null)
                current = head;
        }

        public void AddTaskAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position)
        {
            if (position <= 0)
            {
                AddTaskAtBeginning(taskId, taskName, priority, dueDate);
                return;
            }

            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            TaskNode temp = head;
            int count = 0;
            while (temp.Next != head && count < position - 1)
            {
                temp = temp.Next;
                count++;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void RemoveTask(int taskId)
        {
            if (head == null) return;
            TaskNode temp = head, prev = null;
            do
            {
                if (temp.TaskID == taskId)
                {
                    if (prev != null)
                    {
                        prev.Next = temp.Next;
                    }
                    else
                    {
                        TaskNode last = head;
                        while (last.Next != head)
                            last = last.Next;
                        last.Next = head.Next;
                        head = head.Next;
                    }
                    if (current == temp)
                        current = head;
                    return;
                }
                prev = temp;
                temp = temp.Next;
            } while (temp != head);
        }

        public void DisplayAllTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            TaskNode temp = head;
            do
            {
                Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
                temp = temp.Next;
            } while (temp != head);
        }

        public void SearchTaskByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            TaskNode temp = head;
            bool found = false;
            do
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
            {
                Console.WriteLine("No tasks found with the given priority.");
            }
        }

        public void ViewCurrentTask()
        {
            if (current != null)
            {
                Console.WriteLine($"Current Task -> ID: {current.TaskID}, Name: {current.TaskName}, Priority: {current.Priority}, Due: {current.DueDate}");
            }
            else
            {
                Console.WriteLine("No current task available.");
            }
        }
    }
}
