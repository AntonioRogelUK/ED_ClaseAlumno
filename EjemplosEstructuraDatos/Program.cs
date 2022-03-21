using EjemplosEstructuraDatos;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();
alumno1.Nombres = "Antonio";
alumno1.ApellidoPaterno = "Rogel";
alumno1.Matricula = "123";
alumno1.FechaNacimiento = DateTime.Now;


Alumno alumno2 = new Alumno();
alumno2.Nombres = "Juan";
alumno2.ApellidoPaterno = "Lopez";
alumno2.Matricula = "456";
alumno2.FechaNacimiento = new DateTime(1980,02,28);

lista.Add(alumno1);
lista.Add(alumno2);

foreach (Alumno alumnoEnLista in lista) 
{
    Console.WriteLine(
        " Nombre: "
        + alumnoEnLista.NombreCompleto 
        + " Matricula: " 
        + alumnoEnLista.Matricula 
        + " fecha nacimiento: " 
        + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));
}