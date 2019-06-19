Imports System.Console
Module BuscarMenorPromedio
    Sub BuscarPromMenor(ByVal Notas(,) As Decimal)
        Dim Alumno As Integer
        Dim MenorProm As Decimal
        MenorProm = Notas(0, 10)
        For Alumno = 0 To 3
            If MenorProm > Notas(Alumno + 1, 10) Then
                MenorProm = Notas(Alumno + 1, 10)
            End If
        Next
        WriteLine("El menor promedio es: " & MenorProm)
    End Sub
End Module
