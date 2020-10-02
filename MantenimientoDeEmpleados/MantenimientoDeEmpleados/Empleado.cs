using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoDeEmpleados
{
    class Empleado
    {
        ArrayList lstEmpleados = new ArrayList();


        public Empleado()
        {
        }

        public Empleado(string cedula, string nombre, string apellidos, string direccion, string puesto, string departamento, int annoDeIngreso, int antiguedad, int telefono, double salario)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.puesto = puesto;
            this.departamento = departamento;
            this.annoDeIngreso = annoDeIngreso;
            Antiguedad = antiguedad;
            this.telefono = telefono;
            this.salario = salario;
        }

        public string cedula;
        private string nombre;
        private string apellidos;
        private string direccion;
        private string puesto;
        private string departamento;
        private int annoDeIngreso;
        private int Antiguedad;
        private int telefono;
        private double salario;

        public void SetCedula(string cedula) {
            this.cedula = cedula;
        }
        public String GetCedula() {
            return this.cedula;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public String GetNombre()
        {
            return this.nombre;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public String GetApellidos()
        {
            return this.apellidos;
        }
        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public String GetDireccion()
        {
            return this.direccion;
        }
        public void Setpuesto(string puesto)
        {
            this.puesto = puesto;
        }
        public String GetPuesto()
        {
            return this.puesto;
        }
        public void SetDepartamento(string departamento)
        {
            this.departamento = departamento;
        }
        public String GetDepartamento()
        {
            return this.departamento;
        }
        public void SetAnnoDeIngreso(int annoDeIngreso)
        {
            this.annoDeIngreso = annoDeIngreso;
        }
        public int GetAnnoDeINgreso()
        {
            return this.annoDeIngreso;
        }
        public void SetAntiguedad(int antiguedad)
        {
            this.Antiguedad = antiguedad;
        }
        public int GetAntiguedad()
        {
            return this.Antiguedad;
        }
        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public int GetTelefono()
        {
            return this.telefono;
        }
        public void SetSalario(double salario)
        {
            this.salario = salario;
        }
        public double GetSalario()
        {
            return this.salario;
        }





        public override string ToString()
        {
            return "Nombre: " + nombre + "\nApellidos: "+ apellidos + "\nCédula: "+cedula+"\nDirección: "+"\nPuesto: "+puesto+"\nDepartamento: "+"\nAntiguedad: "+ Antiguedad + "\nTeléfono: " + telefono + "\nSalario: "+salario;
        }
    }
}
