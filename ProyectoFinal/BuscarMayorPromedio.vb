Imports System.Console
Module BuscarMayorPromedio
    Sub BuscarPromMayor(ByVal Notas(,) As Decimal)
        Dim Alumno As Integer
        Dim MayorProm As Decimal
        MayorProm = Notas(0, 10)
        For Alumno = 0 To 3
            If MayorProm < Notas(Alumno + 1, 10) Then
                MayorProm = Notas(Alumno + 1, 10)
            End If
        Next
        WriteLine("El mayor promedio es: " & MayorProm)
    End Sub
End Module
