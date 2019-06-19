Imports System.Console
Module Principal
    Sub Main()
        Dim Notas(4, 10) As Decimal
        Dim Alumnos(4) As String
        Dim respuesta, opciones As Byte

        Alumnos = CargarNombres.Cargar(Alumnos)
        CargarNotas.Nota(Notas, Alumnos)
        Notas = CalcularPromedios.CalculaProm(Notas)
        Do
            WriteLine("Elija una opción del menú:")
            WriteLine("1. Modifique una nota ingresada")
            WriteLine("2. Busque una nota ingresada")
            WriteLine("3. Busque el mayor promedio")
            WriteLine("4. Busque el menor promedio")
            WriteLine("5. Busque el promedio de un alumno determinado")
            opciones = ReadLine()
            Select Case opciones
                Case 1
                    ModificarNotas.Modificar(Notas, Alumnos)
                Case 2
                    BuscarNota.BuscaNota(Notas, Alumnos)
                Case 3
                    BuscarMayorPromedio.BuscarPromMayor(Notas)
                Case 4
                    BuscarMenorPromedio.BuscarPromMenor(Notas)
                Case 5
                    BuscarPromedio.BuscaPromedio(Notas, Alumnos)
                Case Else
                    WriteLine("Usted ingresó una opción no válida")
            End Select

            WriteLine("Si desea salir del programa presione 1, si desea continuar presione 0")
            respuesta = ReadLine()
        Loop While respuesta <> 1
    End Sub
End Module
