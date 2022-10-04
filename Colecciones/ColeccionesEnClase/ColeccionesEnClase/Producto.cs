/*1.Crear e instanciar el Dictionary<TKey,TValue> llamado maquinaExpendedora.
2.Cargar por lo menos 10 elementos en formato clave-valor (clave=numero de posición, valor=nombre del producto)
3.Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:
•Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.
•Pida al usuario elegir el número del producto que quiere
•Al seleccionar número, informar al usuario que recibió ese producto y volver a mostrar todos los productos SIN el producto que ya eligió
•El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.
BONUS: Refactorizar el programa para que en vez de tener un diccionario INT – STRING, tengamos un diccionario INT – PRODUCTO (que contenga nombre y precio del producto)
*/

namespace ColeccionesEnClase
{
    public class Producto
    {

        public string nombre;
        public float precio;
        public static int codigoDeProducto;
        public int codigo;

        static Producto()
        {
            codigoDeProducto = 1000;
        }

        public Producto(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.codigo = codigoDeProducto++;

        }
    }
}