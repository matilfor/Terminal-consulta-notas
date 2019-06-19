Imports System.Console
Module CargarNotas
    Sub Nota(ByRef Notas(,) As Decimal, ByVal Alumnos() As String)
        Dim Fila As Integer
        Dim Errores As Boolean = True
        For Fila = 0 To 4
            Do
                Try
                    WriteLine("Ingrese las notas del alumno:" & Alumnos(Fila))
                    WriteLine("Marzo:")
                    Notas(Fila, 0) = ReadLine()
                    WriteLine("Abril:")
                    Notas(Fila, 1) = ReadLine()
                    WriteLine("Mayo:")
                    Notas(Fila, 2) = ReadLine()
                    WriteLine("Junio:")
                    Notas(Fila, 3) = ReadLine()
                    WriteLine("Julio:")
                    Notas(Fila, 4) = ReadLine()
                    WriteLine("Agosto:")
                    Notas(Fila, 5) = ReadLine()
                    WriteLine("Septiembre:")
                    Notas(Fila, 6) = ReadLine()
                    WriteLine("Octubre:")
                    Notas(Fila, 7) = ReadLine()
                    WriteLine("Noviembre:")
                    Notas(Fila, 8) = ReadLine()
                    WriteLine("Diciembre")
                    Notas(Fila, 9) = ReadLine()

                    Errores = False
                Catch ex As Exception
                    WriteLine("Usted ingresó un dato incorrecto")
                End Try
            Loop While Errores
        Next
    End Sub
End Module
