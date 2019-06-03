Imports System.Data.SqlClient

Public Class Form4
    Private Sub EstadiaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstadiaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstadiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HotelDataSet.estadia' Puede moverla o quitarla según sea necesario.
        Me.EstadiaTableAdapter.Fill(Me.HotelDataSet.estadia)

    End Sub

    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion

        Dim adaptador As New SqlCommand("INSERT INTO estadia VALUES (" & id_cliente.Text & ", " & id_empleado.Text & ", " & id_habitacion.Text & ", '" & Fecha_ingreso.Text & "','" & hora_salida.Text & "', " & num_personas.Text & ", '" & fecha_salida.Text & "', " & id_servicio.Text & "  )", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se agrego correctamente")
    End Sub

    Private Sub consultar_Click(sender As Object, e As EventArgs) Handles consultar.Click

        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion
        Dim adaptador As New SqlCommand("select * from estadia", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Consulta con exito")
        Me.EstadiaTableAdapter.Fill(Me.HotelDataSet.estadia)

    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click

        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion
        Dim adaptador As New SqlCommand("update estadia set fecha_salida = '" & fecha_salida.Text & "',hora_salida='" & hora_salida.Text & "' WHERE id_cliente=" & id_cliente.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se modifico correctamente")
        Me.EstadiaTableAdapter.Fill(Me.HotelDataSet.estadia)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion
        'create view hotel.buscar AS (" & id_cliente.Text & ")
        Dim adaptador As New SqlDataAdapter("select * from estadia where id_cliente= " & id_cliente.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        If ds.Tables("datos").Rows.Count > 0 Then
            id_cliente.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            id_empleado.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            id_habitacion.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            Fecha_ingreso.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            hora_salida.Text = ds.Tables("datos").Rows(0).Item(5).ToString
            num_personas.Text = ds.Tables("datos").Rows(0).Item(6).ToString
            fecha_salida.Text = ds.Tables("datos").Rows(0).Item(7).ToString
            id_servicio.Text = ds.Tables("datos").Rows(0).Item(8).ToString
        Else
            MsgBox("El codigo ingresado no existe amigo")
        End If
    End Sub
End Class