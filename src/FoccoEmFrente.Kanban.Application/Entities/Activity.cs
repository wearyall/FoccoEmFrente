﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FoccoEmFrente.Kanban.Application.Entities
{
    public class Activity : Entity, IAggregateRoot
    {
        public string Title { get; set; }
      
        public ActivityStatus Status { get; set; }

    }
}
