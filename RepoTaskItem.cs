using ConsoleApp8.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp8.Repo;



public class RepoTaskItem
{
    private Context context = new Context();
    public bool Creattask(TaskItem task)
    {
        context.TaskItems.Add(task);
        return context.SaveChanges() > 0;
    }
    public List<TaskItem> GetAllTasks ()
    {
        return context.TaskItems.AsNoTracking().ToList();
    }

    public TaskItem? GetTaskById(int id)
    {
        return context.TaskItems
            .FirstOrDefault(p => p.Id == id);
    }
    public bool UpdateTask(TaskItem task)
    {
        context.TaskItems.Update(task);
        return context.SaveChanges() > 0;
    }
    public bool DeleteTask(int id)
    {
        TaskItem? task = GetTaskById(id);

        if (task == null)
            return false;

        context.TaskItems.Remove(task);
        return context.SaveChanges() > 0;
    }

}
