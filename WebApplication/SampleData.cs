using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Hospitals.Any() &&
                !context.Doctors.Any() &&
                !context.Patients.Any() &&
                !context.Rooms.Any())
            {
                var hospital = new Hospital
                {
                    Name = "Больница №1",
                    Address = "Улица Пушкина, дом Колотушкина"
                };

                var room1 = new Room
                {
                    Number = "1",
                    Hospital = hospital
                };

                var room2 = new Room
                {
                    Number = "2",
                    Hospital = hospital
                };

                var doctor = new Doctor
                {
                    Name = "Вася Пупкин",
                    Specialization = "Эксперт по программистам",
                    Hospital = hospital
                };

                var patient1 = new Patient
                {
                    Name = "Иван Иванов",
                    Symptoms = "Много программировал",
                    Hospital = hospital,
                    Room = room1
                };

                var patient2 = new Patient
                {
                    Name = "Петя Петров",
                    Symptoms = "Мало программировал",
                    Hospital = hospital,
                };

                context.Add(hospital);
                context.Add(room1);
                context.Add(room2);
                context.Add(doctor);
                context.Add(patient1);
                context.Add(patient2);

                context.SaveChanges();
            }
        }
    }
}
