using Diploma.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class designed for working with EntityFramework and DataBase 

namespace Diploma.Models
{
    public static class DataWorker
    {
        #region PatientOperation

        // Create patient
        public static bool CreatePatient(Patient patient)
        {
            using (DiplomaContext db = new())
            {
                patient.Id = 0;
                if (db.Patients.Any(p => p.Name == patient.Name) && db.Patients.Any(p => p.Surname == patient.Surname) && db.Patients.Any(p => p.Middlename == patient.Middlename)
                    && db.Patients.Any(p => p.BirthDate == patient.BirthDate))
                    return false;

              
                db.Patients.Add(patient);
                db.SaveChanges();

                return true;
            }
        }

        // Get patient 
        public static List<Patient> GetPatients()
        {
            using (DiplomaContext db = new())
            {
                db.Patients.Load();
                return db.Patients.ToList();
            }
        }

        //Update patient
        public static bool UpdatePatient(Patient patient)
        {
            using (DiplomaContext db = new())
            {
                Patient old = db.Patients.Where(p => p.Id == patient.Id).First();
                if (old is null)
                    return false;
                db.Entry(old).CurrentValues.SetValues(patient);
                db.SaveChanges();
                return true;
            }
        }

        // Delete patient
        public static bool DeletePatient(Patient patient)
        {
            using (DiplomaContext db = new())
            {
                if (!db.Patients.Any(p => p.Id == patient.Id))
                    return false;
                db.Patients.Remove(patient);
                db.SaveChanges();
                return true;
            }
        }

        #endregion

        #region Services Operation

        public static bool CreateService(Service service)
        {
            using (DiplomaContext db = new())
            {
                db.ReabilitationTypes.LoadAsync();
                if (db.Services.Any(p => p.Id == service.Id))
                    return false;

                db.Services.AddAsync(service);
                db.SaveChanges();
                return true;
            }
        }
        public static bool UpdateServices(Service service)
        {
            using (DiplomaContext db = new())
            {
                db.ReabilitationTypes.LoadAsync();
                if (db.Services.Any(p => p.Id == service.Id))
                    return false;

                db.Services.AddAsync(service);
                db.SaveChanges();
                return true;
            }
        }

        public static List<Service> GetServices()
        {
            using (DiplomaContext db = new())
            {
                return db.Services.ToList();
            }
        }

        public static bool DeleteService(Service service)
        {
            using (DiplomaContext db = new())
            {
                if (!db.Services.Any(p => p.Id == service.Id))
                    return false;
                db.Services.Remove(service);
                db.SaveChanges();
                return true;
            }
        }
        #endregion

        #region ProvidedService
       
        public static bool CreateProvidedService(ProvidedService patient)
        {
            using (DiplomaContext db = new())
            {
                patient.Id = 0;
                //if (db.ProvidedServices.Any(p => p.Pati == patient.Name) && db.ProvidedServices.Any(p => p.Surname == patient.Surname) && db.ProvidedServices.Any(p => p.Middlename == patient.Middlename)
                //    && db.ProvidedServices.Any(p => p.BirthDate == patient.BirthDate))
                //    return false;

               
                db.ProvidedServices.Add(patient);
                db.SaveChanges();

                return true;
            }
        }
        
        public static List<ProvidedService> GetProvidedServices()
        {
            using (DiplomaContext db = new())
            {
                db.ProvidedServices.Load();
                return db.ProvidedServices.ToList();
            }
        }

                public static bool UpdateProvidedService(ProvidedService providedService)
        {
            using (DiplomaContext db = new())
            {
                              
                if (db.ProvidedServices.Any(s=>s.Id == providedService.Id))
                   return false;
                //db.Entry(old).CurrentValues.SetValues(providedService);
                //db.SaveChanges();
                db.ProvidedServices.Update(providedService);
                return true;
            }
        }

        public static bool DeleteProvidedService(ProvidedService providedService)
        {
            using (DiplomaContext db = new())
            {
                if (!db.ProvidedServices.Any(p => p.Id == providedService.Id))
                    return false;
                db.ProvidedServices.Remove(providedService);
                db.SaveChanges();
                return true;
            }
        }
        #endregion

        #region User Operation

        #endregion

        #region Deceases

        public static List<Decease> GetDeceases()
        {
            using (DiplomaContext db = new())
            {
                return db.Deceases.ToList();
            }
        }
        #endregion

        #region SocialIntegrations
        public static List<SocialIntegration> GetSocialIntergration()
        {
            using (DiplomaContext db = new())
            {
                return db.SocialIntegrations.ToList();
            }
        }
        #endregion

        #region DisabilityGroups

        public static List<DisabilityGroup> GetDisabilityGroups()
        {
            using (DiplomaContext db = new())
            {
                return db.DisabilityGroups.ToList();
            }
            #endregion
        }
    }
}
