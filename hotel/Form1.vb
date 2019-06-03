Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim sql As String = "SELECT * FROM estadia"
    Dim cmd As New SqlCommand(sql, con)

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HotelDataSet.estadia' Puede moverla o quitarla según sea necesario.
        Me.EstadiaTableAdapter.Fill(Me.HotelDataSet.estadia)
        'TODO: esta línea de código carga datos en la tabla 'HotelDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.HotelDataSet.cliente)


    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.EstadiaTableAdapter.Agregar_cliente(Id_estadiaTextBox.Text, Id_clienteTextBox.Text, Id_empleadoTextBox.Text, Id_habitacionTextBox.Text,
                                Id_servicioTextBox.Text, Convert.ToString(Hora_salidaTextBox.Text), Hora_salidaTextBox.Text, Num_personasTextBox.Text
                                )
        Me.ClienteTableAdapter.Fill(Me.HotelDataSet.cliente)
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub
End Class
