using Inventario.Models;
using Inventario.WiGoServiceReference;
using Newtonsoft.Json;
using System;
using System.Diagnostics; // Importar System.Diagnostics para usar Debug.WriteLine
using System.Collections.Generic;
using System.Web.Mvc;

public class CuentasController : Controller
{
    private WiGoServiceClient _serviceClient;

    public CuentasController()
    {
        _serviceClient = new WiGoServiceClient(); // Cliente del servicio WCF
    }

    public ActionResult Index()
    {
        try
        {
            string json = _serviceClient.GetData("Inventario", "MobileAccount", "");

            Debug.WriteLine($"Respuesta del servicio: {json}"); // Registra la respuesta en la ventana de "Salida"

            if (string.IsNullOrEmpty(json))
            {
                ViewBag.Error = "La respuesta del servicio está vacía.";
                return View();
            }

            // Verifica si el JSON es válido
            if (!json.Trim().StartsWith("{") && !json.Trim().StartsWith("["))
            {
                ViewBag.Error = $"La respuesta del servicio no es un JSON válido: {json}";
                return View();
            }

            List<MobileAccount> cuentas = JsonConvert.DeserializeObject<List<MobileAccount>>(json) ?? new List<MobileAccount>();

            ViewBag.MobileAccount = cuentas;
            return View();
        }
        catch (JsonReaderException ex)
        {
            ViewBag.Error = $"Error al deserializar el JSON: {ex.Message}";
            return View();
        }
        catch (Exception ex)
        {
            ViewBag.Error = $"Se ha producido un error inesperado: {ex.Message}";
            return View();
        }
    }

}
