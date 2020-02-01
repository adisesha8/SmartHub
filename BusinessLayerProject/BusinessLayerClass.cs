using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerProject;
using System.Data;
using ModelProject;
//using DataLayerProject;

namespace BusinessLayerProject
{
    public class BusinessLayerClass
    {
        public static List<ModelProject.ModelClass> GetPatientDetailsList()
        {
            ModelClass ModelClassObject = new ModelClass();
            List<ModelClass> ListofModelClassObjects = new List<ModelClass>();

            DataSet OutputFromDataLayerProject = new DataSet();

            OutputFromDataLayerProject = DataLayerClass.RetrievePatientInformation(); //2nd assignment

            //var Patientdatalookupbyservice = new PatientLookUp1.LookUpServiceClient();
            //OutputFromDataLayerProject = Patientdatalookupbyservice.RetrievePatientInformation();
            //3rd assignment

            if (OutputFromDataLayerProject.Tables.Count>0)
            {
                ListofModelClassObjects = OutputFromDataLayerProject.Tables[0].AsEnumerable().Select(x => new ModelClass
                {
                    FirstName = Convert.ToString(x["FirstName"]),
                    LastName = Convert.ToString(x["LastName"]),
                    Sex = Convert.ToString(x["Sex"]),
                    MaritalStatus = Convert.ToString(x["MaritalStatus"])
                }).ToList();
            }
            return ListofModelClassObjects;
        }
    }
}
