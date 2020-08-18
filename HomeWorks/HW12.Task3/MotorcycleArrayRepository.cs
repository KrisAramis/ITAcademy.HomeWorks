using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.ComponentModel;
using log4net.Core;
using log4net;

namespace HW12.Task3
{
    class MotorcycleArrayRepository: IRepository<Motorcycle>
    {
        public MotorcycleArrayRepository()
        {
            GlobalVars.motoarray = new List<Motorcycle>();
        }
        private static readonly ILog log = LogManager.GetLogger(typeof(MotorcycleArrayRepository));

        public Motorcycle GetMotorcycle(int id)
        {
           return GlobalVars.motoarray.Find(mot => mot.ID == id);
        }

        public IEnumerable<Motorcycle> GetMotorcycles()
        {
            return GlobalVars.motoarray.FindAll(mot => mot.ID != 0);
        }

        public void Create(Motorcycle moto)
        {
            try
            {
                GlobalVars.motoarray.Add(moto);
                //int id = 0;
                //if (motoarray.Length > 0)
                //{
                //    id = motoarray.GetUpperBound(0);
                //    moto.ID = ++id;
                //    motoarray.SetValue(moto, id + 1);
                //}
            }
            catch {
                log.Debug("Object to Motorcycle list added");
            }
        }
        public void Update(Motorcycle moto)
        {
            try
            {
                int index = GlobalVars.motoarray.FindIndex(mot => mot.ID == moto.ID);
                GlobalVars.motoarray[index] = moto;
            }
            catch
            {
                log.Debug("Object in Motorcycle list updated");
            }
        }
        public void Delete(int id)
        {
            try
            {
                var toremove = from t in GlobalVars.motoarray
                               where t.ID.Equals(id)
                               select t;

                GlobalVars.motoarray.Remove((Motorcycle)toremove);
            }
            catch 
            {
                log.Debug("Object to Motorcycle list deleted");
            }
        }
        public void Save() { }
    }    
}

