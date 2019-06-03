Imports System.Data.SqlClient

Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion

        Dim adaptador As New SqlCommand("INSERT INTO cliente VALUES ('" & nombres.Text & "', '" & apellidos.Text & "', " & celular.Text & " )", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se conecto correctamente")

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HotelDataSet.habitacion' Puede moverla o quitarla según sea necesario.
        Me.HabitacionTableAdapter.Fill(Me.HotelDataSet.habitacion)
        'TODO: esta línea de código carga datos en la tabla 'HotelDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.HotelDataSet.cliente)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion
        Dim adaptador As New SqlCommand("select * from cliente", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("se consulto correctamente")
        Me.ClienteTableAdapter.Fill(Me.HotelDataSet.cliente)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion

        Dim adaptador As New SqlCommand("INSERT INTO habitacion VALUES (" & id_cliente.Text & ", " & id_empleado.Text & ", '" & tipo_habitacion.Text & "', " & num_habitacion.Text & ", " & num_personas.Text & ", " & estado.Text & ")", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se inserto el registro correctamente")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion
        Dim adaptador As New SqlCommand("select * from cliente", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se consulto correctamente")
        Me.HabitacionTableAdapter.Fill(Me.HotelDataSet.habitacion)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion

        Dim adaptador As New SqlDataAdapter("select * from cliente where id_cliente= " & idC.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        If ds.Tables("datos").Rows.Count > 0 Then
            nombres.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            apellidos.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            celular.Text = ds.Tables("datos").Rows(0).Item(3).ToString

        Else
            MsgBox("El cliente que desea ingresar no existe")
        End If
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click

        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion
        Dim adaptador As New SqlCommand("update cliente set nombre = '" & nombres.Text & "',apellido='" & apellidos.Text & "',num_celular='" & celular.Text & "' WHERE id_cliente=" & idC.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se actualizo correctamente")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles buscarH.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion

        Dim adaptador As New SqlDataAdapter("select * from habitacion where id_habitacion= " & idH.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        If ds.Tables("datos").Rows.Count > 0 Then
            id_cliente.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            id_empleado.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            tipo_habitacion.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            num_habitacion.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            num_personas.Text = ds.Tables("datos").Rows(0).Item(5).ToString
            estado.Text = ds.Tables("datos").Rows(0).Item(6).ToString

        Else
            MsgBox("El cliente que desea ingresar no existe")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles modificarH.Click
        Dim coneccion As String = "Data Source=ELMER;Initial Catalog=hotel;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion
        Dim adaptador As New SqlCommand("update habitacion set tipo_habitacion='" & tipo_habitacion.Text & "',
                                           num_habitacion=" & num_habitacion.Text & ",num_personas=" & num_personas.Text & ",
                                           estado=" & estado.Text & " WHERE id_cliente=" & id_cliente.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se ha modificado correctamente.")
        Me.HabitacionTableAdapter.Fill(Me.HotelDataSet.habitacion)
    End Sub


End Class