﻿using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace todoWebApi.Models
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options)
            : base(options)
        { }

        public DbSet<Task> taskslist { get; set; }


    }
}
