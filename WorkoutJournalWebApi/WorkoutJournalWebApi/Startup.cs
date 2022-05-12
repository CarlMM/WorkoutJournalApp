using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutJournal.Domain.Interfaces;
using WorkoutJournal.Domain.Models;
using WorkoutJournal.Domain.RepositoryInterfaces;
using WorkoutJournal.Domain.Services;
using WorkoutJournal.Infrastructure.Context;
using WorkoutJournal.Infrastructure.Interfaces;
using WorkoutJournal.Infrastructure.Repository;

namespace WorkoutJournalWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Enable CORS
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            services.AddDbContext<IWorkoutDBContext, WorkoutDBContext>();

            services.AddTransient<IRoutineRepository, RoutineRepository>();
            services.AddTransient<IRoutineService, RoutineService>();

            services.AddTransient<IMuscleRepository, MuscleRepository>();
            services.AddTransient<IMuscleService, MuscleService>();

            services.AddTransient<IWeekdayService, WeekdayService>();
            services.AddTransient<IWeekdayRepository, WeekdayRepository>();

            services.AddTransient<IExerciseService, ExerciseService>();
            services.AddTransient<IExerciseRepository, ExerciseRepository>();

            services.AddTransient<IWorkoutExerciseService, WorkoutExerciseService>();
            services.AddTransient<IWorkoutExerciseRepository, WorkoutExerciseRepository>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WorkoutJournalWebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WorkoutJournalWebApi v1"));
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
