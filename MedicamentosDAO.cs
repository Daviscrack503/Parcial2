using System;

public class MedicamentosDAO
{
	public bool InsertarMedicamento ()


	{
    try
	   
	
	{
            var medic = new Medicamentos

        IdMedicamento = Medicamento.IdMedicamento,
        NombreMedicamento = Medicamento.NombreMedicamento,
        PrecioMedicamento = Medicamento.PrecioMedicamento

	  Contexto.SaveChanges();
    }


    }return true;
	catch(Exception ex)
	{
		Console.WriteLine("Error al insertar medicamento: " + ex.Message);
		return false;
	}



   
   public bool ActualizarMedicamento(int, id, medcicamentos actualizar)

   try
   { var ActulizarMedicamento = GetById(id);
    if (ActulizarMedicamento == null)
    {
        return false;
    }
    ActulizarMedicamento.NombreMedicamento = actualizar.NombreMedicamento;
    ActulizarMedicamento.PrecioMedicamento = actualizar.PrecioMedicamento;
    Contexto.SaveChanges();
    return true;
}
catch (Exception ex)
{
    Console.WriteLine("Error al actualizar medicamento: " + ex.Message);
    return false;
}





}










}




     









