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
            checar(str)
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
            Err.Clear()
            Exit Sub
        End Try
    End Sub

    Sub descomprimir(ByVal r As String)
        r = r.Replace(" ", "")
        If File.Exists(r) = True Then
            'tomamos el nombre del archivo
            Dim nombre As String
            nombre = r.Substring(r.LastIndexOf("\") + 1)

            'se crea la carpeta temporal y se copia el programa de descompresión de Altus por si es necesario
            Directory.CreateDirectory("C:\Sism")
            File.Copy("C:\Archivos de programa\UAEMex\IdEst\KW2ASC32.exe", Path.Combine("C:\Sism", "prg.exe"), True)

            'si el archivo existe hay que descomprimirlo
            If r.ToUpper.EndsWith(".EVT") Then
                'se descomprime un EVT con el KW2ASC32.exe y viene con el paquete de DOS SUPPORT, 
                'programa de línea de comandos suministrado por Altus

                File.Copy(r, Path.Combine("C:\Sism", nombre), True)

                Dim pr As Process
                Dim argum As String = Path.Combine("C:\Sism", nombre) & " -H"
                pr = Process.Start("C:\Sism\prg.exe", argum)
                pr.WaitForExit()

                'borrar lo que ya no se usa: el prg.exe y el evt de la temporal
                File.Delete(Path.Combine("C:\Sism", nombre))
                File.Delete("C:\Sism\prg.exe")

                'se asigna el registrador
                nombre = Path.Combine("C:\Sism", nombre)
                nombre = nombre.Replace(".EVT", ".SHD")
                Dim strd As New StreamReader(nombre)
                nombre = strd.ReadToEnd
                strd.Close()
                nombre = nombre.Substring(nombre.IndexOf("Station ID:") + 12, 10)
                nombre = nombre.Substring(0, nombre.IndexOf(" "))
                If nombre <> "" Then
                    nombre = "." & nombre.Substring(0, 1).ToUpper
                    If "ABCDEFGHIJKL".Contains(nombre.Substring(1)) = False Then
                        nombre = ".0"
                    End If
                Else
                    nombre = ".0"
                End If

                'se obtienen todos los archivos en el subdirectorio
                Dim ArrFileInfo() As FileInfo
                Dim DirInfo As New DirectoryInfo("C:\Sism")
                Try
                    ArrFileInfo = DirInfo.GetFiles
                Catch ex As Exception
                    Return
                End Try

                Dim FileInf As FileInfo
                For Each FileInf In ArrFileInfo
                    If FileInf.ToString.ToUpper.EndsWith(".EXE") Or FileInf.ToString.ToUpper.EndsWith(".EVT") Then
                        'evitarlo
                        GoTo siguiente
                    End If
                    File.Copy(Path.Combine("C:\Sism", FileInf.Name), _
                    Path.Combine(DirOrigen, FileInf.Name.Replace(".0", nombre)), True)    ''''''''no camb

siguiente:
                Next
                'borrar el directorio temporal
                If Directory.Exists("C:\Sism") Then
                    Directory.Delete("C:\Sism", True)
                End If
            End If
        End If
    End Sub
End Module
