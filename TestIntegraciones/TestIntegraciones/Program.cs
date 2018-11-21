using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIntegraciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Banco.DgieWSPortClient WS = new Banco.DgieWSPortClient();                   
            string e;

            //string path = @"C:\Log\SatisfaccionCapacitacion\JSON.txt";
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    sw.WriteLine(WSCE.Execute("MRC", "", "", 0, "", out e));
            //}
            
            
            Console.WriteLine("Ya");
            HumanSite.WSInfoUnidadNegocioSoapPortClient HumanSite = new TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPortClient();
            /*Guardamos el resultado del WS en la variable json*/
            //var json = HumanSite.GETUNIDADNEGOCIO("MRC", 0, out e);
            //var json = WSH.Execute(uno, dos, out tres);
            //Console.WriteLine("Inicia petición a Human Site...");
            //var jsonRC = HumanSite.GETEMPLEADOSRELCHE("MRC", "24/08/2018", 16, out e);
            
            //Console.WriteLine("Termina petición a Human Site");
            //var jsonRC = WSRC.Execute("MRC", "20/03/2018", 17, out e);
            //Console.WriteLine("Inicia petición a Human Site...");
            //var jsonEmp = HumanSite.GETINFOEMPLEADO("MRC", 7417 , out e);
            //Console.WriteLine("Termina petición a Human Site");            
            var jsonCE = HumanSite.GETEMPLEADOS("MRC", "MRC50301", "", 3, "", out e);
            //var jsonCE = WSCE.Execute("MRC","","",0,"",out e);
            /*Creamos una lista del tipo UnidadNegocio que es la clase del WS y deserializamos el objeto json que recibimos anteriormente*/
            //List<UnidadNegocio> resh = JsonConvert.DeserializeObject<List<UnidadNegocio>>(json);
            //List<Checador> resrc = JsonConvert.DeserializeObject<List<Checador>>(jsonRC);
            //Console.WriteLine("Inicia Deserialización de Objeto ...");
            //CEmpleado resemp = JsonConvert.DeserializeObject<CEmpleado>(jsonEmp);
            //Console.WriteLine("Termina Deserialización de Objeto");
            List<CEmpleado> resCE = JsonConvert.DeserializeObject<List<CEmpleado>>(jsonCE);
            /*Recorremos el objeto JSON para acceder a sus elementos*/
            //DataClasses1DataContext BD = new DataClasses1DataContext();            
            //foreach (UnidadNegocio d in resh)
            {
                //Unidad U = new Unidad
                //{
                //    NombreUN = "",
                //    RazonSocialUN = d.ComDsc,
                //    IDHumanSiteUN = d.ComId
                //};
                //BD.Unidad.InsertOnSubmit(U);
                //BD.SubmitChanges();
                //Console.WriteLine(d.ComId);
                //Console.WriteLine(d.ComDsc);
            }          
            //foreach (Checador t in resrc)
            //{
            //    if (t.Emp_nie == 7201)
            //    {
            //        Console.WriteLine(t.Emp_nie);
            //        Console.WriteLine(t.EmpNomComp);
            //        Console.WriteLine(t.RelCheRegEnt);
            //        Console.WriteLine(t.RelCheRegSal);
            //    }
            //}
            foreach (CEmpleado CE in resCE)
            {
                Console.WriteLine(CE.Emp_patern + " " + CE.Emp_matern + " " + CE.Emp_nombres);
                Console.WriteLine(CE.Emp_nie);
                Console.WriteLine(CE.EmpCURP);
                Console.WriteLine(CE.EmpFechaAntiguedad);
                Console.WriteLine(CE.EmpFechaIngreso);
                Console.WriteLine(CE.EmpFechaNacimiento);
                Console.WriteLine(CE.EmpNumeroIMSS);
                Console.WriteLine(CE.EmpRFC);
                Console.WriteLine(CE.PlazaCatalagoDsc);
                Console.WriteLine(CE.PuestoDsc);
                Console.WriteLine(CE.PuestoId);
                Console.WriteLine(CE.TelefonoNo);
            }

            //Console.WriteLine(resemp.Emp_patern + " " + resemp.Emp_matern + " " + resemp.Emp_nombres);
            //Console.WriteLine(resemp.Emp_nie);
            //Console.WriteLine(resemp.EmpCURP);
            //Console.WriteLine(resemp.EmpFechaAntiguedad);
            //Console.WriteLine(resemp.EmpFechaIngreso);
            //Console.WriteLine(resemp.EmpFechaNacimiento);
            //Console.WriteLine(resemp.EmpNumeroIMSS);
            //Console.WriteLine(resemp.EmpRFC);
            //Console.WriteLine(resemp.PlazaCatalagoDsc);
            //Console.WriteLine(resemp.PuestoDsc);
            //Console.WriteLine(resemp.PuestoId);
            //Console.WriteLine(resemp.TelefonoNo);

            //Console.WriteLine(resCE.Count);
            Console.WriteLine("Fin");
            Console.ReadKey();

        }
    }
}
