Imports System.Console
Module CalcularPromedios
    Function CalculaProm(ByRef Notas(,) As Decimal) As Array
        Dim Fila, Columna, Promedio, SumaNotas As Decimal
        For Fila = 0 To 4
            For Columna = 0 To 9
                SumaNotas = Notas(Fila, Columna) + SumaNotas
            Next
            Promedio = SumaNotas / 10
            Notas(Fila, 10) = Promedio
            WriteLine("Tu promedio es " & Promedio)
        Next
        WriteLine("------------------------")
        Return Notas
    End Function
End Module
