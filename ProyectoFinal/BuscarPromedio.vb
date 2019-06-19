Imports System.Console
Module BuscarPromedio
    Sub BuscaPromedio(ByVal Notas(,) As Decimal, ByVal Alumnos() As String)
        Dim Alumno As String
        Dim opcion As Byte
        Do
            WriteLine("Elija un alumno de la lista")
            WriteLine("1. " & Alumnos(0))
            WriteLine("2. " & Alumnos(1))
            WriteLine("3. " & Alumnos(2))
            WriteLine("4. " & Alumnos(3))
            WriteLine("5. " & Alumnos(4))
            Alumno = ReadLine()

            WriteLine("El promedio es: " & Notas(Alumno, 10))
            WriteLine("")
            WriteLine("¿Desea consultar otro promedio? Ingrese 0 para continuar o ingrese 1 para salir")
            opcion = ReadLine()
        Loop While opcion <> 1
    End Sub
End Module
