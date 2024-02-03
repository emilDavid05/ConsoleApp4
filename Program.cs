
Console.WriteLine();

Estudiantes estudiantes = new Estudiantes();


estudiantes.Matricula = "2018-1458";
estudiantes.Nombre = "Mario Carrasquilla";
estudiantes.Edad = 25;
estudiantes.Carrera = "Ingenieria de Software";

estudiantes.ImprimirDatos();
Console.WriteLine();

Estudiantes estudiantes2 = new Estudiantes();


estudiantes2.Matricula = "201851458";
estudiantes2.Nombre = "Kianna ";
estudiantes2.Edad = 15;
estudiantes2.Carrera = "Hoteleria";


//Imprimir la informacion
estudiantes2.ImprimirDatos();

class Estudiantes
{
    //declaracion de campo de clase
    private string matricula;
    private string nombre;
    private int edad;
    private string carrera;

    //Declaracion de las propiedades get y set
    public string Matricula
    {
        get { return matricula; }
        set { matricula = value; }
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public string Carrera
    {
        get { return carrera; }
        set { carrera = value; }
    }

    public void ImprimirDatos()
    {
        Console.WriteLine($"{nombre} de matricula {Matricula} tiene {Edad} años" +
            $" y cursa la carrera de {Carrera}");
    }
}



                 