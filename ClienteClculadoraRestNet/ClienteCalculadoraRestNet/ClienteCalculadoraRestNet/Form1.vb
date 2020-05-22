Imports System.Globalization
Imports System.Net
Imports System.Text

Public Class Form1
    Private Sub txtSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim x, y, res As Double
        Dim uri As String
        Dim refCliente As WebClient
        Dim cadenaUri As String
        Dim content As String
        Dim provider As NumberFormatInfo

        x = CDbl(txtX.Text)
        y = CDbl(txtY.Text)

        provider = New NumberFormatInfo()
        provider.NumberDecimalSeparator = "."


        cadenaUri = "x=" + CStr(x) + "&y=" + CStr(y)
        uri = "http://localhost:7101/AplicacionServidorCalculadoraRest-ProyectoServidorCalculadoraRest-context-root/resources/model/sumar?" + cadenaUri
        refCliente = New WebClient()
        content = refCliente.DownloadString(uri)

        res = Convert.ToDouble(content, provider)

        txtRes.Text = CStr(res)
    End Sub

    Private Sub txtAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim Kte As Double
        Dim uri As String
        Dim refCliente As WebClient
        Dim postArray As Byte()
        Dim cadenaUri As String


        Kte = CDbl(txtKte.Text)

        cadenaUri = "Kte=" + CStr(Kte)
        uri = "http://localhost:7101/AplicacionServidorCalculadoraRest-ProyectoServidorCalculadoraRest-context-root/resources/model/asignarKte?" + cadenaUri
        refCliente = New WebClient()
        postArray = Encoding.ASCII.GetBytes(cadenaUri)
        refCliente.UploadData(uri, "POST", postArray)

    End Sub
End Class
