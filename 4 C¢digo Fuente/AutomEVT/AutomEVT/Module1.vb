Imports System.IO
Public Module Module1
    Dim str As String = ""
    Dim DirOrigen As String
    Sub Main()
        For Each argument As String In My.Application.CommandLineArgs
            str = str & argument.ToString() & " "
        Next
        If str <> "" Then
            'entonces hay argumentos y hay que checarlos para abrir los files automaticamente
            Console.Write("Abriendo archivo ")
            Console.Write(str.ToString)
            checar(str)
        Else
            Console.Write(" Sin argumento. Any key to exit.")
            Console.WriteLine()
            Console.Read()

        End If
    End Sub
    Sub checar(ByVal s As String)
        Try
            'hay que ver si el argumento esta bien
            Dim s1 As String
            s1 = s.Substring(s.LastIndexOf(":") - 1)
            DirOrigen = s1.Remove(s1.LastIndexOf("\"))
            descomprimir(s1)
            Do While s1.Length <> s.Length
                s = s.Replace(s1, "")
                s1 = s.Substring(s.LastIndexOf(":") - 1)
                descomprimir(s1)
            Loop
        Catch ex As Exception
            Console.Write("El argumento no esta bien, la ruta al archivo tiene espacios")
            Console.WriteLine()
            Console.Write(Err.ToString)
            Console.Read()
            Err.Clear()
            Exit Sub
        End Try
    End Sub

    Sub descomprimir(ByVal r As String)
        If r.EndsWith(" ") Then
            r = r.Remove(r.Length - 1, 1)
        End If

        'r = r.Replace(" ", "")
        If File.Exists(r) = True Then
            'tomamos el nombre del archivo
            Dim nombre As String
            Dim inicial As String
            Dim ruta As String
            nombre = r.Substring(r.LastIndexOf("\") + 1)
            ruta = r.Replace(nombre, "")
            If r.ToUpper.EndsWith(".EVT") Then
                File.Copy(System.AppDomain.CurrentDomain.BaseDirectory & "\KW2ASC32.exe", Path.Combine(ruta, "prg.exe"), True)
                'copiamos el programa de Altus a la carpeta de trabajo.
                Console.Write(vbNewLine & "Lanzando KW2ASC32.exe de Altus..." & vbNewLine)
                Dim pr As Process
                Dim argum As String = r & " -H"
                pr = Process.Start(Path.Combine(ruta, "prg.exe"), argum)
                pr.WaitForExit()
                Console.Write("terminado " & vbNewLine)

            Else
                Console.Write(vbNewLine & "No es un EVT" & vbNewLine)
            End If
            'borrar lo que ya no se usa
            File.Delete(Path.Combine(ruta, "prg.exe"))

            'se asigna el registrador
            Dim nombreSH As String
            nombreSH = r.Replace(".EVT", ".SHD")
            Dim strd As New StreamReader(nombreSH)
            nombreSH = strd.ReadToEnd
            strd.Close()
            nombreSH = nombreSH.Substring(nombreSH.IndexOf("Station ID:") + 12, 10)
            nombreSH = nombreSH.Substring(0, nombreSH.IndexOf(" "))

            If nombreSH <> "" Then
                inicial = "." & nombreSH.Substring(0, 1).ToUpper
                If "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(inicial.Substring(1)) = False Then
                    nombreSH = ".0"
                End If
            Else
                nombreSH = ".0"
            End If

            Console.Write("La estacion ID es " & nombreSH & vbNewLine)
            If nombreSH = ".0" Then

            Else
                nombreSH = "-" & nombreSH & ".0"
            End If

            'se obtienen todos los archivos en el subdirectorio
            Dim ArrFileInfo() As FileInfo
            Dim DirInfo As New DirectoryInfo(ruta)
            Try
                ArrFileInfo = DirInfo.GetFiles
            Catch ex As Exception
                Return
            End Try

            Dim FileInf As FileInfo
            Dim snomb As String
            snomb = nombre.Substring(0, nombre.LastIndexOf("."))
            For Each FileInf In ArrFileInfo

                If FileInf.ToString.ToUpper.EndsWith(".EXE") Or FileInf.ToString.ToUpper.EndsWith(".EVT") Or FileInf.ToString.ToUpper.EndsWith(".HDR") Or FileInf.ToString.ToUpper.EndsWith(".SHD") Then
                    'evitarlo
                    GoTo siguiente
                End If

                If FileInf.ToString.ToUpper.StartsWith(snomb) Then
                    Console.Write(vbNewLine & "renombrando " & Path.Combine(ruta, FileInf.Name))
                    Console.Write(vbNewLine & "con   " & Path.Combine(DirOrigen, FileInf.Name.Replace(".0", nombreSH)))

                    File.Move(Path.Combine(ruta, FileInf.Name), Path.Combine(DirOrigen, FileInf.Name.Replace(".0", nombreSH)))
                End If

siguiente:
            Next



        'se crea la carpeta temporal y se copia el programa de descompresión de Altus por si es necesario
        'Directory.CreateDirectory("C:\Sism")

        'File.Copy(System.AppDomain.CurrentDomain.BaseDirectory & "\KW2ASC32.exe", Path.Combine("C:\Sism", "prg.exe"), True)

        'si el archivo existe hay que descomprimirlo
        'If r.ToUpper.EndsWith(".EVT") Then
        'se descomprime un EVT con el KW2ASC32.exe y viene con el paquete de DOS SUPPORT, 
        'programa de línea de comandos suministrado por Altus

        'File.Copy(r, Path.Combine("C:\Sism", nombre), True)

        ' Console.Write(vbNewLine & "Lanzando KW2ASC32.exe de Altus..." & vbNewLine)
        ' Dim pr As Process
        ' Dim argum As String = Path.Combine("C:\Sism", nombre) & " -H"
        '  pr = Process.Start("C:\Sism\prg.exe", argum)
        ' pr.WaitForExit()
        ' Console.Write("terminado " & vbNewLine)

        'borrar lo que ya no se usa: el prg.exe y el evt de la temporal
        '  File.Delete(Path.Combine("C:\Sism", nombre))
        '  File.Delete("C:\Sism\prg.exe")

        'se asigna el registrador
        '  nombre = Path.Combine("C:\Sism", nombre)
        ' nombre = nombre.Replace(".EVT", ".SHD")
        '  Dim strd As New StreamReader(nombre)
        '  nombre = strd.ReadToEnd
        '  strd.Close()
        '  nombre = nombre.Substring(nombre.IndexOf("Station ID:") + 12, 10)
        '  nombre = nombre.Substring(0, nombre.IndexOf(" "))

        '  If nombre <> "" Then
        'inicial = "." & nombre.Substring(0, 1).ToUpper
        '  If "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(inicial.Substring(1)) = False Then
        'nombre = ".0"
        'End If
        'Else
        'nombre = ".0"
        ' End If

        'Console.Write("La estacion ID es " & nombre & vbNewLine)
        '  If nombre = ".0" Then

        'Else
        '     nombre = "-" & nombre & ".0"
        ' End If



        'se obtienen todos los archivos en el subdirectorio
        'Dim ArrFileInfo() As FileInfo
        'Dim DirInfo As New DirectoryInfo("C:\Sism")
        'Try
        'ArrFileInfo = DirInfo.GetFiles
        '  Catch ex As Exception
        'Return
        '  End Try

        '  Dim FileInf As FileInfo
        ' For Each FileInf In ArrFileInfo
        'If FileInf.ToString.ToUpper.EndsWith(".EXE") Or FileInf.ToString.ToUpper.EndsWith(".EVT") Then
        'evitarlo
        '  GoTo siguiente
        ' End If


        'File.Copy(Path.Combine("C:\Sism", FileInf.Name), _
        '  Path.Combine(DirOrigen, FileInf.Name.Replace(".0", nombre)), True)    ''''''''no camb

        'siguiente:
        'Next
        'borrar el directorio temporal
        ' If Directory.Exists("C:\Sism") Then
        'Directory.Delete("C:\Sism", True)
        'End If
        'End If
        Else
            Console.Write(vbNewLine & " El archivo no existe ")
            Console.Read()
        End If
    End Sub
End Module
