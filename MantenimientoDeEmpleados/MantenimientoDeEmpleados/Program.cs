using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDeEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Logica log = new Logica();
            Empleado em = new Empleado();
            string ced = "";
            int aumento = 0;
            String op = null;
            do
            {
                Console.WriteLine("Elija una opción: " +
                    "\n 1. Imprimir empleados y características " +
                    "\n 2. Incrementar Salario a un empleado" +
                    "\n 3. Incremento masivo " +
                    "\n 4. Insertar persona " +
                    "\n 5 - Salir");

                op = Console.ReadLine().ToString();
                ALL:
                switch (op)
                {
                    case "1":
                        foreach (Empleado item in log.empleado)
                        {
                            Console.WriteLine(item+"\n");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Ingrese la cédula de la persona: ");
                        ced = Console.ReadLine();
                        Console.WriteLine("Ingrese el aumento: ");
                        aumento = Int32.Parse(Console.ReadLine());
                        log.editarSalario(ced,aumento);
                        break;

                    case "3":
                        log.incrementarSalarioMasivo();
                        break;
                    
                    case "4":
                        
                        Empleado emp = new Empleado();
                        Console.WriteLine("Digite la cédula: ");
                        emp.SetCedula(Console.ReadLine());
                        Console.WriteLine("Digite el nombre : ");
                        emp.SetNombre(Console.ReadLine());
                        Console.WriteLine("Digite el apellido: ");
                        emp.SetApellidos(Console.ReadLine());
                        Console.WriteLine("Digite la dirección: ");
                        emp.SetDireccion(Console.ReadLine());
                        Console.WriteLine("Digite el puesto: : ");
                        emp.Setpuesto(Console.ReadLine());
                        Console.WriteLine("Digite el departamento: ");
                        emp.SetDepartamento(Console.ReadLine());
                        Console.WriteLine("Digite año de ingreso: ");
                        emp.SetAnnoDeIngreso( Int32.Parse( Console.ReadLine()));
                        Console.WriteLine("Digite el telefono: ");
                        emp.SetTelefono(Int32.Parse(Console.ReadLine()));
                        
                       
                        
                        while (true)
                        {

                            Console.WriteLine("Digite el salario: ");
                            double salario = double.Parse(Console.ReadLine());
                            if (salario > 450000)
                            {
                                emp.SetSalario(salario);
                                goto ALL;
                            }
                            else
                            {
                                Console.WriteLine("El salario debe ser mayor a 450000");
                                
                            }

                            
                        }
                        log.agregarEmpleado(emp);
                        break;

                    case "5":

                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;


                }
            } while (op != "4");
            Console.ReadKey();
        }
    }
}
