using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ws_swise
{
    /// <summary>
    /// Descripción breve de Swise
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Swise : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public bool siguienteNegocio()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            [WebMethod]
        public bool PagoDeFacturas
        {
            get
            {
                try
                {
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
}

 