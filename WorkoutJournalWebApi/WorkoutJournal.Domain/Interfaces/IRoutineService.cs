﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Dtos;
using WorkoutJournal.Domain.Models;

namespace WorkoutJournal.Domain.Interfaces
{
    public interface IRoutineService
    {

        Task<IEnumerable<Routine>> GetAllRoutinesAsync();

        Task<RoutineDto> AddNewRoutine(RoutineDto newRoutine);


    }
}
