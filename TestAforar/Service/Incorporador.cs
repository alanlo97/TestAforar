using System;
using System.Threading.Tasks;
using TestAforar.Entities;
using TestAforar.Response;
using TestAforar.Service.Interfaces;

namespace TestAforar.Service
{
    public class Incorporador : IIncorporador
    {
        public async Task<Result> Incorporar(Prestadora prestadora)
        {
            try
            {
                bool validPeriod = true;

                if(string.IsNullOrEmpty(prestadora.Perdiodo) || Convert.ToDateTime(prestadora.Perdiodo) <= DateTime.Now)
                    validPeriod = false;

                if (string.IsNullOrEmpty(prestadora.Name) || string.IsNullOrEmpty(prestadora.dbs_cliente) || validPeriod == false)
                    return Result.ResultState(500, "Los Datos son incorrectos o el periodo que se intenta procesar no es válido", false);

                return Result.ResultState(200, $"Se incorporaran los datos de la prestadora {prestadora.Name} del Periodo: {prestadora.Perdiodo} para el cliente {prestadora.dbs_cliente}", true);
            }
            catch(Exception e)
            {
                return Result.ResultState(500, e.Message, false);
            }
        }
    }
}
