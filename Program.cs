namespace examen_parcial_practico
{
    using System;

    namespace SistemaInventario
    {

        public class Producto
        {
            private string nombre;
            private string codigo;
            private double precio;
            private int cantidad;

            public Producto(string nombre, string codigo, double precio, int cantidad)
            {
                this.nombre = nombre;
                this.codigo = codigo;
                this.precio = precio;
                this.cantidad = cantidad;
            }

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public string Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public double Precio
            {
                get { return precio; }
                set { precio = value; }
            }

            public int Cantidad
            {
                get { return cantidad; }
                set { cantidad = value; }
            }

            public virtual void MostrarProducto()
            {
                Console.WriteLine($"Producto: {nombre}");
                Console.WriteLine($"Codigo: {codigo}");
                Console.WriteLine($"Precio: {precio}");
                Console.WriteLine($"Cantidad: {cantidad}");
            }

            public virtual double CalcularImpuesto()
            {
                return 0;
            }
        }

        // ==================== PRODUCTO ELECTRONICO ====================
        public class ProductoElectronico : Producto
        {
            private int garantiaMeses;

            public ProductoElectronico(string nombre, string codigo, double precio, int cantidad, int garantiaMeses)
                : base(nombre, codigo, precio, cantidad)
            {
                this.garantiaMeses = garantiaMeses;
            }

            public int GarantiaMeses
            {
                get { return garantiaMeses; }
                set { garantiaMeses = value; }
            }

            public override void MostrarProducto()
            {
                base.MostrarProducto();
                Console.WriteLine($"Garantia: {garantiaMeses} meses");
            }

            public override double CalcularImpuesto()
            {
                return Precio * 0.18;
            }
        }

        // ==================== PRODUCTO ALIMENTO ====================
        public class ProductoAlimento : Producto
        {
            private string fechaVencimiento;

            public ProductoAlimento(string nombre, string codigo, double precio, int cantidad, string fechaVencimiento)
                : base(nombre, codigo, precio, cantidad)
            {
                this.fechaVencimiento = fechaVencimiento;
            }

            public string FechaVencimiento
            {
                get { return fechaVencimiento; }
                set { fechaVencimiento = value; }
            }

            public override void MostrarProducto()
            {
                base.MostrarProducto();
                Console.WriteLine($"Fecha de Vencimiento: {fechaVencimiento}");
            }

            public override double CalcularImpuesto()
            {
                return Precio * 0.08;
            }
        }

        // ==================== PROGRAMA PRINCIPAL ====================
        class Program
        {
            static void Main(string[] args)
            {
                ProductoElectronico laptop = new ProductoElectronico(
                    nombre: "Laptop",
                    codigo: "P1001",
                    precio: 45000,
                    cantidad: 5,
                    garantiaMeses: 12
                );

                ProductoAlimento arroz = new ProductoAlimento(
                    nombre: "Arroz",
                    codigo: "A2001",
                    precio: 350,
                    cantidad: 100,
                    fechaVencimiento: "2025-12-31"
                );

                Console.WriteLine("===== PRODUCTO ELECTRONICO =====");
                laptop.MostrarProducto();
                Console.WriteLine($"Impuesto: {laptop.CalcularImpuesto()}");

                Console.WriteLine();

                Console.WriteLine("===== PRODUCTO ALIMENTO =====");
                arroz.MostrarProducto();
                Console.WriteLine($"Impuesto: {arroz.CalcularImpuesto()}");

                Console.ReadKey();
            }
        }
    }

}