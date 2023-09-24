using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Tarea4
{
    /// <summary>
    /// Descripción breve de AreasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal Cuadrado(decimal Lado1, decimal Lado2)
        {
            calculo c = new calculo();
            return c.cuadrado(Lado1, Lado2);
        }
        [WebMethod]
        public decimal Triangulo(decimal Largo, decimal Ancho)
        {
            calculo c = new calculo();
            return c.triangulo(Largo, Ancho);
        }
        [WebMethod]
        public double Circulo(double Radio)
        {
            calculo c = new calculo();
            return c.circulo(Radio);
        }
    }
}
