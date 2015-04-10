Imports System.Xml.Serialization
Imports System.Xml
Imports System.IO
<Serializable()> Public Class ClassBox

    Private RutaBox As String = "C:\Archivos de programa\UAEMex\ARSis v1.2\Box.opt"    'Ruta al archivo Box donde se guarda todo
    Private Lista As String = "No"   'la lista exportada

    Public Property RutaExportada() As String          'Con ésta propiedad se asignan o se leen los valores de LaRuta exportada
        Get
            Return Lista
        End Get
        Set(ByVal Value As String)
            Lista = Value
        End Set
    End Property

    Public Function SiExisteNooo() As Boolean     'Para saber si existe el archivo que guarda la info
        Dim OBio As New FileInfo(RutaBox)
        Return OBio.Exists
    End Function

    Public Sub Lea_los_datos_EXPORTADOS()         'Ésta instrucción extrae la información exportada la decodifica y le asisgna a
        '                                          las variables locales los valores leidos.
        Dim OBbox As New ClassBox 'Una nueva instancia de éste mismo objeto (recibe los datos decodificados en forma de variables ya decodificadas)
        If OBbox.SiExisteNooo Then 'Si si existe ...  (Siempre existe porque es éste documento, esta solo para asegurar que el proceso lo puede accesar)
            Dim SERIADOR As New XmlSerializer(GetType(ClassBox)) 'El componente que codifica y decodifica
            Dim Pointer As New StreamReader(RutaBox) 'El apuntador que lee el texto del archivo
            Dim lectorXML As New XmlTextReader(Pointer) 'El componente que interpreta el texto para el SERIADOR

            If SERIADOR.CanDeserialize(lectorXML) Then 'Si se puede ...
                OBbox = CType(SERIADOR.Deserialize(lectorXML), ClassBox) ' Pasarle los datos decodificados y ya interpretados
            Else                                                        ' como del mismo tipo que el objeto que los recibe
                GuardarOpciones() 'en el archivo que las almacena
            End If
            lectorXML.Close()
            Pointer.Close()     'si no se cierran se traba la compu
            Me.Lista = OBbox.Lista.Clone 'Le asigna a la variable local el valor leido en OBbox
        End If
    End Sub   'al salir se desecha automáticamente OBbox

    Public Sub GuardarOpciones()     'Para cuando no se puede decodificar el archivo o bien cuando se cambian los valores y
        '                             se quieren almacenar para la próxima vez
        Dim wr As New StreamWriter(RutaBox)                'el escribano
        Dim seriadorXML As New XmlSerializer(Me.GetType)   'el codificador (el tipo es el tipo de objetos podra codificar)
        seriadorXML.Serialize(wr, Me)
        wr.Close()
    End Sub
End Class
