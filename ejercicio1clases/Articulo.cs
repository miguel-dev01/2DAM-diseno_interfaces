using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1clases
{
    public class Articulo
    {
        private static int ultimoCodigoArticulo = 0;
        private int codigoArticulo = 0;
        private string nombreArticulo;
        private static string[] categoriaArticulo = { "Informatica", "Imagen", "Telefonia", "Sonido" };
        private string categoria;
        private decimal precioArticulo;
        private int existenciasArticulo;

        public int CodigoArticulo { get => codigoArticulo; set => codigoArticulo = value; }
        public string NombreArticulo { get => nombreArticulo; set => nombreArticulo = value; }
        public decimal PrecioArticulo { get => precioArticulo; set => precioArticulo = value; }
        public int ExistenciasArticulo { get => existenciasArticulo; set => existenciasArticulo = value; }
        public string[] CategoriaArticulo { get => categoriaArticulo; set => categoriaArticulo = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        public Articulo() {}

        public Articulo(string nombreArticulo, string categoria, 
            decimal precioArticulo, int existenciasArticulo)
        {
            ultimoCodigoArticulo++;
            CodigoArticulo = ultimoCodigoArticulo;
            NombreArticulo = nombreArticulo;
            Categoria = categoria;
            PrecioArticulo = precioArticulo;
            ExistenciasArticulo = existenciasArticulo;
        }

        public void actualizarExistencias(int cantidad)
        {
            if (ExistenciasArticulo >= cantidad)
            {
                ExistenciasArticulo -= cantidad;
                decimal importePedido = PrecioArticulo * cantidad;
                MessageBox.Show($"Importe del pedido: {importePedido:C}\nExistencias restantes: {ExistenciasArticulo}");
            }
            else
            {
                MessageBox.Show($"No hay suficientes existencias.\nExistencias actuales: {ExistenciasArticulo}");
            }
        }

        public override string ToString()
        {
            return $"Código: {CodigoArticulo}, Nombre: {NombreArticulo}, " +
                $"Categoría: {Categoria}, Precio: {PrecioArticulo}, " +
                $"Existencias: {ExistenciasArticulo}";
        }
    }
}
