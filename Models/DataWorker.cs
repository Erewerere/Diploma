using Diploma.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public static class DataWorker
    {
        #region PatientOperation
       
        // Create patient
        public static bool CreatePatient(Patient patient )
        {
            DiplomaContext db = new();
            if (db.Patients.Any(p => p.Id == patient.Id))            
                return false;         
            patient.BirthDate = DateTime.Now;
            patient.DeceaseId = 1;
            patient.IntegrationId = 1;
            patient.DisabilityGroupId = 1;            
            db.Patients.Add(patient);
            db.SaveChanges();
            return true;
        }

        // Get patient 
        public static  List<Patient> GetPatients()
        {
            DiplomaContext db = new();
            db.Patients.Load();
            return db.Patients.ToList();
        }
        
        // Delete patient
        public static bool DeletePatient(Patient patient)
        {
            DiplomaContext db = new();
            if (!db.Patients.Any(p => p.Id == patient.Id))
                return false;
            db.Patients.Remove(patient);
            db.SaveChanges();
            return true;
        }

        #endregion

        #region Services Operation
        // Create patient
        public static bool CreateService(Service service)
        {
            DiplomaContext db = new();
            db.ReabilitationTypes.LoadAsync();
            if (db.Services.Any(p => p.Id == service.Id))
                return false;
           
            db.Services.AddAsync(service);
            db.SaveChanges();
            return true;
        }

        // Get patient 
        public static Task<List<Service>> GetServices()
        {
            DiplomaContext db = new();            
            return db.Services.ToListAsync();
        }

        // Delete patient
        public static bool DeleteService(Service service)
        {
            DiplomaContext db = new();
            if (!db.Services.Any(p => p.Id == service.Id))
                return false;
            db.Services.Remove(service);
            db.SaveChanges();
            return true;
        }
        #endregion

        #region User Operation

        #endregion




    }
}
