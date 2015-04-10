Public Class Utilidades

    Public Shared Function TransformadaRápidaDeFourier(ByVal rg(,) As Double, ByVal Tam_Orig As Double) As Double(,)
        Dim rgF(,) As Double
        Dim i, k As Integer 'contadores
        Dim N As Integer = rg.Length / 2    'El número de elementos

        'La FFT requiere que la cantidad de datos pueda expresarse como un número
        'igual a una potencia entera de 2.
        Dim P As Single = Math.Log(N) / Math.Log(2)
        If P <> CInt(P) Then '¿La potencia no es un entero?
            Dim supe As Int16
            'El tamaño de N se rectifica a el número superior más próximo que 
            'puede expresarse como potencia entera de 2.
            supe = CInt(P.ToString.Substring(0, P.ToString.IndexOf("."))) + 1
            N = 2 ^ supe
        End If

        'Copiamos el registro a una variable auxiliar con tamaño 2^p
        Dim rgaux(N - 1, 1) As Double
        Try
            For i = 0 To N - 1
                rgaux(i, 0) = rg(i, 0)
                rgaux(i, 1) = rg(i, 1)
            Next
        Catch ex As Exception
            Err.Clear()
        End Try

        'Aguzamos los extremos de la señal (tapering) para mejorar el desempeño
        'de la FFT. La operación se hace en un porcentaje del tamaño de la señal.
        Dim tam As Short = Tam_Orig * Form1.tap / 100 'Form1.tap indica el porcentaje
        For i = 0 To tam 'Extremo inicial
            rgaux(i, 0) = rgaux(i, 0) * (Math.Sin(Math.PI * i / (2 * tam)))
        Next
        For i = Tam_Orig - tam To Tam_Orig 'Extremo final
            rgaux(i, 0) = rgaux(i, 0) * (Math.Cos(Math.PI * (i - (Tam_Orig - tam)) / (2 * tam)))
        Next

        'Recuperamos el valor desde la variable auxiliar
        ReDim rgF(N - 1, 1)
        For i = 0 To rgF.Length / 2 - 1
            rgF(i, 0) = rgaux(i, 0)
        Next

        Dim J As Integer = N / 2
        Dim Aux_Real, Aux_Imag As Double
        'se invierte el orden de los datos de antemano pues el algoritmo 
        'de fft arroja los datos movidos. Tambien puede hacerse al final.
        For i = 1 To N - 2
            If i < J Then
                Aux_Real = rgF(J, 0)
                Aux_Imag = rgF(J, 1)
                rgF(J, 0) = rgF(i, 0)
                rgF(J, 1) = rgF(i, 1)
                rgF(i, 0) = Aux_Real
                rgF(i, 1) = Aux_Imag
            End If
            k = N / 2
            Do While k <= J
                J = J - k
                k = k / 2
            Loop
            J = J + k
        Next
        Dim Pe, ip As Integer
        'FFT:
        Dim UnitReal, UnitImag, coseno, seno As Double
        For Pe = 1 To CInt(Math.Log(N) / Math.Log(2))
            UnitReal = 1
            UnitImag = 0
            coseno = Math.Cos(Math.PI / (CInt(2 ^ Pe) / 2))
            seno = -Math.Sin(Math.PI / (CInt(2 ^ Pe) / 2))
            For J = 1 To CInt(CInt(2 ^ Pe) / 2)

                For i = J - 1 To N - 1 Step CInt(2 ^ Pe)
                    ip = i + (CInt(2 ^ Pe) / 2)
                    Aux_Real = rgF(ip, 0) * UnitReal - rgF(ip, 1) * UnitImag
                    Aux_Imag = rgF(ip, 0) * UnitImag + rgF(ip, 1) * UnitReal
                    rgF(ip, 0) = rgF(i, 0) - Aux_Real
                    rgF(ip, 1) = rgF(i, 1) - Aux_Imag
                    rgF(i, 0) = rgF(i, 0) + Aux_Real
                    rgF(i, 1) = rgF(i, 1) + Aux_Imag
                Next
                Aux_Real = UnitReal
                UnitReal = Aux_Real * coseno - UnitImag * seno
                UnitImag = Aux_Real * seno + UnitImag * coseno
            Next
        Next

        ' la frecuencia cero está en realidad en rgf.length/4-1 (a la mitad) .'. la mitad son negativos (por los conjugados)
        ' podría desecharse la parte negativa (la segunda mitad)
        Return rgF
    End Function

    Public Shared Function AntiTransformadaRápidaDeFourier(ByVal rgF(,) As Double) As Double(,)
        Dim rg(,) As Double
        rg = rgF.Clone 'se adquieren los valores

        Dim i, k As Integer 'contadores
        Dim N As Integer = rg.Length / 2
        Dim P As Single
        P = Math.Log(N) / Math.Log(2) 'teóricamente siempre va a ser un entero

        Dim J As Integer = N / 2
        Dim Aux_Real, Aux_Imag As Double            'se invierte el orden de los datos de antemano pues el algoritmo
        For i = 1 To N - 2                        'de fft hace éste mismo cambio. Tambien puede hacerse al final.
            If i < J Then
                Aux_Real = rg(J, 0)
                Aux_Imag = rg(J, 1)
                rg(J, 0) = rg(i, 0)
                rg(J, 1) = rg(i, 1)
                rg(i, 0) = Aux_Real
                rg(i, 1) = Aux_Imag
            End If
            k = N / 2
            Do While k <= J
                J = J - k
                k = k / 2
            Loop
            J = J + k
        Next
        Dim Pe, ip As Integer
        'AntiFFT:
        Dim UnitReal, UnitImag, coseno, seno As Double
        For Pe = 1 To CInt(Math.Log(N) / Math.Log(2))
            UnitReal = 1
            UnitImag = 0
            coseno = Math.Cos(Math.PI / (CInt(2 ^ Pe) / 2))
            seno = Math.Sin(Math.PI / (CInt(2 ^ Pe) / 2))   ' cambio de signo!!!
            For J = 1 To CInt(CInt(2 ^ Pe) / 2)

                For i = J - 1 To N - 1 Step CInt(2 ^ Pe)
                    ip = i + (CInt(2 ^ Pe) / 2)
                    Aux_Real = rg(ip, 0) * UnitReal - rg(ip, 1) * UnitImag
                    Aux_Imag = rg(ip, 0) * UnitImag + rg(ip, 1) * UnitReal
                    rg(ip, 0) = rg(i, 0) - Aux_Real
                    rg(ip, 1) = rg(i, 1) - Aux_Imag
                    rg(i, 0) = rg(i, 0) + Aux_Real
                    rg(i, 1) = rg(i, 1) + Aux_Imag
                Next
                Aux_Real = UnitReal
                UnitReal = Aux_Real * coseno - UnitImag * seno
                UnitImag = Aux_Real * seno + UnitImag * coseno
            Next
        Next
        Return rg
    End Function

    Public Shared Function magnitud(ByVal rgf(,) As Double) As Double()
        'magnitud
        Dim i, j, k As Integer
        Dim mag() As Double

        k = (Form1.SPS / 100)
        If k < 1 Then
            k = 1
        End If
        ReDim mag((rgf.Length / (2 * k)) - 1)

        For i = 0 To mag.Length - 1
            On Error Resume Next
            'Se obtiene la magnitud del número complejo y se multiplica por Dt para escalarlo
            mag(i) = (Math.Sqrt(rgf(j, 0) ^ 2 + rgf(j, 1) ^ 2)) / (Form1.SPS)
            j += k
        Next
        magnitud = mag.Clone
    End Function

    Public Shared Function Mult_Complx(ByVal Z1(,) As Double, ByVal Z2(,) As Double) As Double(,)
        '(a, b) · (c, d) = (ac - bd, bc + ad) 
        '   a= z1(i,0)
        '   b= z1(i,1)
        '   c= z2(i,0)
        '   d= z2(i,1) 

        Dim mul(Z1.Length / 2 - 1, 1) As Double 'variable auxiliar para calcular la multiplicación
        Dim i As Double 'ínidice
        For i = 0 To mul.Length / 2 - 1
            mul(i, 0) = Z1(i, 0) * Z2(i, 0) - Z1(i, 1) * Z2(i, 1)
            mul(i, 1) = Z1(i, 1) * Z2(i, 0) + Z1(i, 0) * Z2(i, 1)
        Next
        Return mul
    End Function

    Public Shared Function conju_complx(ByVal Z(,) As Double) As Double(,)
        '   Z = (a,b)
        '  *Z = (a,-b)
        Dim i As Double 'ínidice
        Dim Zcj(,) As Double = Z
        For i = 0 To Z.Length / 2 - 1
            Zcj(i, 1) = -Zcj(i, 1)
        Next
        Return Zcj
    End Function

    Public Shared Function Raiz_complx(ByVal Z(,) As Double) As Double(,)
        '   Z = (a,b)

        'sqrt(Z) = (sqrt((mod + a)/2), sqrt((mod - a)/2))  y  (sqrt((mod + a)/2), - sqrt((mod - a)/2))
        Dim rai(Z.Length / 2 - 1, 1) As Double 'variable auxiliar
        Dim i, modu As Double 'índice y variable auxiliar para manejar la magnitud 
        For i = 0 To rai.Length / 2 - 1
            modu = Math.Sqrt(Z(i, 0) ^ 2 + Z(i, 1) ^ 2)
            rai(i, 0) = Math.Sqrt((modu + Z(i, 0)) / 2)
            rai(i, 1) = Math.Sqrt((modu - Z(i, 0)) / 2)
        Next
        Return rai
    End Function

    Public Shared Function división_complx(ByVal Z1(,) As Double, ByVal Z2(,) As Double) As Double(,)
        '(a,b)/(c,d)= (a,b)(c,-d) (1/(c^2-d^2))
        'La fracción se multiplica y divide por el conjugado del denominador
        'Esto resulta en multiplicar el numerador por el conjuagdo del denominador y dividir
        'todo por el escalar c^2-d^2 producto de multiplicar el denominador por su conjugado

        Dim i As Double
        Dim div(,) As Double = Mult_Complx(Z1, conju_complx(Z2))
        For i = 0 To div.Length / 2 - 1
            div(i, 0) = div(i, 0) / (Z2(i, 0) ^ 2 - Z2(i, 1) ^ 2)
            div(i, 1) = div(i, 1) / (Z2(i, 0) ^ 2 - Z2(i, 1) ^ 2)
        Next
        Return div
    End Function

    Public Shared Function Solonum(ByVal Key As String) As Boolean
        If (Key >= 48 And Key <= 57) Or Key = 8 Then
            Solonum = False
        Else
            Solonum = True
        End If
        If (Key = 45) Or (Key = 46) Then
            Solonum = True
        End If
    End Function
End Class
