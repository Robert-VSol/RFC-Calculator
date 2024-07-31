class Program{
    static void Main(string[] args){
        Console.WriteLine("Bienvenido a matrices");
        string textoFila = "Ingrese la cantidad de filas: ";
        int cantFilas = cantFilasColumnas(textoFila);
        string textoColumna = "Ingrese la cantidad de columnas: ";
        int cantColumnas = cantFilasColumnas(textoColumna);
        Console.WriteLine("____________________________________________________________________");
        int[,] mat = new int[cantFilas,cantColumnas];
        for(int f=0; f<cantFilas; f++){
            for(int c=0; c<cantColumnas; c++){
                Console.Write($"Ingrese valor en la fila {f+1} columna {c+1}: ");
                mat[f,c] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Su matriz queda de la siguiente manera: ");
        for(int f=0; f<cantFilas; f++){
            for(int c=0; c<cantColumnas; c++){
                Console.Write(mat[f,c]+" ");
            }
            Console.WriteLine("");
        }
    }
    static int cantFilasColumnas(string texto){
        sbyte respuesta = 0;
        int cant = 0;
        while(respuesta==Convert.ToSByte(0)){
            Console.Write(texto);
            cant = int.Parse(Console.ReadLine());
            if (cant>=2) respuesta=Convert.ToSByte(1);
            else Console.WriteLine("Respuesta no válida, tiene que ser 2 o mayor");
        }
        return (cant);
    }
}