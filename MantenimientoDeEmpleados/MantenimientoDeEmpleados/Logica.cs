using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDeEmpleados
{
    class Logica
    {

        public List<Empleado> empleado { get; set;}

        public Logica()
        {
            this.empleado = new List<Empleado>();
            insertarEmpleado();
        }

        public void agregarEmpleado( Empleado em ) {
            empleado.Add (em);
        }

        public void insertarEmpleado() {
            empleado.Add(new Empleado("207910145", "Erick", "Gamboa", "800 oeste", "Asistente", "Limpieza", 2000, 20, 84931242, 900000));
            empleado.Add(new Empleado("207910146", "Ericka", "Rojas", "700 oeste", "Subjefe", "Cirugía", 2010, 10, 84931246, 800000));
            empleado.Add(new Empleado("207910142", "Juan", "Venegas", "400 oeste", "Directora", "Administración", 20011, 9, 84931241, 500000));
            empleado.Add(new Empleado("207910141", "Juana", "Gomez", "200 oeste", "jefe", "Administración", 20011, 9, 84931241, 500000));
        }


        public void editarSalario(string ced, int aumento) {
            foreach (Empleado item in empleado)
                if (item.cedula.Equals(ced))
                {
                    double
                        salario;
                    salario = item.GetSalario();
                    item.SetSalario(salario + aumento);


                }
                else {
                    Console.WriteLine("Usuario no encontrado");
                }
            {

            }

        }
        public void incrementarSalarioMasivo()
        {
            foreach (Empleado item in empleado)
                if (!item.GetPuesto().Equals("jefe"))
                {
                    if (item.GetSalario() > 600000)
                    {
                        double aumento = item.GetSalario() * 0.5;
                        item.SetSalario(aumento);
                    }
                    else {
                        double aumento = item.GetSalario() * 0.2;
                        item.SetSalario(aumento);
                    }

                }
                else
                {
                    Console.WriteLine("Usuario no encontrado");
                }
        }

    }
}

