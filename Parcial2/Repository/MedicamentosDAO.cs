using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial2.Context;
using Parcial2.Models;

namespace Parcial2.Repository
{
    public class MedicamentosDAO
    {
        public class MedicamentoDAO
        {
            FarmaciaUnabContext context = new FarmaciaUnabContext();

            public List<Medicamento> Select()
                => context.Medicamentos.ToList();

            public Medicamento? GetId(int id)
                => context.Medicamentos.FirstOrDefault(medicamento => medicamento.Id == id);

            public bool Insertar(Medicamento medicamento)
            {
                try
                {
                    context.Medicamentos.Add(medicamento);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }

            public bool Actualizar(Medicamento medicamento)
            {
                try
                {
                    context.Medicamentos.Update(medicamento);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }

            public bool Eliminar(int id)
            {
                try
                {
                    var medicamento = context.Medicamentos.FirstOrDefault(m => m.Id == id);
                    if (medicamento != null)
                    {
                        context.Medicamentos.Remove(medicamento);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }


        }
    }
}



