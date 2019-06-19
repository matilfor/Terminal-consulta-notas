Imports System.Console
Module ModificarNotas
    Sub Modificar(ByRef Notas(,) As Decimal, ByVal Alumnos() As String)
        Dim Mes, Alumno As String
        Dim NotaMod, opcion As Byte
        Dim Errores As Boolean = True
        Do
            WriteLine("Elija un alumno de la lista")
            WriteLine("1. " & Alumnos(0))
            WriteLine("2. " & Alumnos(1))
            WriteLine("3. " & Alumnos(2))
            WriteLine("4. " & Alumnos(3))
            WriteLine("5. " & Alumnos(4))
            Alumno = ReadLine()

            WriteLine("Elija un mes para modificar su nota")
            WriteLine("1. Marzo " & Notas(Alumno, 0))
            WriteLine("2. Abril " & Notas(Alumno, 1))
            WriteLine("3. Mayo " & Notas(Alumno, 2))
            WriteLine("4. Junio " & Notas(Alumno, 3))
            WriteLine("5. Julio " & Notas(Alumno, 4))
            WriteLine("6. Agosto " & Notas(Alumno, 5))
            WriteLine("7. Septiembre " & Notas(Alumno, 6))
            WriteLine("8. Octubre " & Notas(Alumno, 7))
            WriteLine("9. Noviembre " & Notas(Alumno, 8))
            WriteLine("10. Diciembre " & Notas(Alumno, 9))
            Mes = ReadLine()
            Do
                Try
                    WriteLine("Ingrese la nueva nota")
                    NotaMod = ReadLine()
                    Errores = False
                Catch ex As Exception
                    WriteLine("Usted ingresó un dato incorrecto")
                    Notas(Alumno, Mes) = NotaMod
                End Try
            Loop While Errores
            WriteLine("")
            WriteLine("¿Desea modificar otra nota? Ingrese 0 para continuar o 1 para salir")
            opcion = ReadLine()
        Loop While opcion <> 1
    End Sub
End Module
