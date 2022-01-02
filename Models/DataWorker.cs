using Diploma.EF;
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
        public static List<Patient> GetPatients()
        {
            DiplomaContext db = new();
            return db.Patients.Local.ToList();
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
    }
}
