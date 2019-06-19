Imports System.Console
Module CargarNombres
    Function Cargar(ByRef Alumnos() As String) As Array
        Dim Columna As Integer
        WriteLine("Escriba el nombre de cinco alumnos:")
        For Columna = 0 To 4
            Alumnos(Columna) = ReadLine()
        Next
        Return Alumnos
    End Function
End Module
