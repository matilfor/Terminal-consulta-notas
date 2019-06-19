Imports System.Console
Module BuscarNota
    Sub BuscaNota(ByVal Notas(,) As Decimal, ByVal Alumnos() As String)
        Dim Mes, Alumno As String
        Dim opcion As Byte
        Do
            WriteLine("Elija un alumno de la lista")
            WriteLine("1. " & Alumnos(0))
            WriteLine("2. " & Alumnos(1))
            WriteLine("3. " & Alumnos(2))
            WriteLine("4. " & Alumnos(3))
            WriteLine("5. " & Alumnos(4))
            Alumno = ReadLine()

            WriteLine("Elija un mes")
            WriteLine("1. Marzo ")
            WriteLine("2. Abril ")
            WriteLine("3. Mayo ")
            WriteLine("4. Junio ")
            WriteLine("5. Julio ")
            WriteLine("6. Agosto ")
            WriteLine("7. Septiembre ")
            WriteLine("8. Octubre ")
            WriteLine("9. Noviembre ")
            WriteLine("10. Diciembre ")
            Mes = ReadLine()

            WriteLine("La nota es: " & Alumno, Mes)
            WriteLine("")
            WriteLine("¿Desea consultar otra nota? Ingrese 0 para continuar o ingrese 1 para salir")
            opcion = ReadLine()
        Loop While opcion <> 1
    End Sub
End Module
