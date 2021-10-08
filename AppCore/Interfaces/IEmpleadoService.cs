using Domain.Entities.Empleados;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IEmpleadoService : IService<Empleado>
    {
        Empleado FindById(int id);
        int GetLastEmpleadoId();

        void create(Empleado e);
        int Update(Empleado e);
        bool Delete(Empleado e);
        



    }
}
