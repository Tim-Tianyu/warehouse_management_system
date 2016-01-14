
Imports System.Configuration
Imports System.Data.SqlClient
Module warehouse_module
    Public Function Check_material(name As String) As Integer
        Dim a As Integer = 0
        Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
        Dim cs As New SqlConnection(sqlcs)
        'Dim hint As String = ""
        Try
            a = Int(name) 'this line will have an error if name have any non-numeric char in it
            Dim sqlcommand As New SqlCommand("SELECT Material_ID FROM warehouse_material WHERE Material_ID=@ID", cs)
            sqlcommand.Parameters.Add("@ID", SqlDbType.SmallInt).Value = a
            Dim dbadptor As New SqlDataAdapter(sqlcommand)
            Dim tbl As New DataTable()
            dbadptor.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                a = tbl.Rows(0).Item(0)
            Else
                'hint = "no such ID"
                a = 77777
            End If
        Catch ex1 As Exception
            Dim sqlcommand As New SqlCommand("SELECT Material_ID FROM warehouse_material WHERE Mname = @name", cs)
            sqlcommand.Parameters.Add("@name", SqlDbType.NChar).Value = name
            Dim dbadptor As New SqlDataAdapter(sqlcommand)
            Dim tbl As New DataTable()
            dbadptor.Fill(tbl)
            If tbl.Rows.Count = 1 Then
                a = tbl.Rows(0).Item(0)
            ElseIf tbl.Rows.Count = 0 Then
                'hint = "no such name"
                a = 88888
            Else
                'hint = "two or more have this name, must enter ID"
                a = 99999
            End If
        End Try
        Return a
    End Function
    Public Function Check_worker(name As String) As Integer
        Dim a As Integer = 0
        Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
        Dim cs As New SqlConnection(sqlcs)
        'Dim hint As String = ""
        Try
            a = Int(name) 'this line will have an error if name have any non-numeric char in it
            Dim sqlcommand As New SqlCommand("SELECT Woker_ID FROM warehouse_worker WHERE Worker_ID=@ID", cs)
            sqlcommand.Parameters.Add("@ID", SqlDbType.TinyInt).Value = a
            Dim dbadptor As New SqlDataAdapter(sqlcommand)
            Dim tbl As New DataTable()
            dbadptor.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                a = tbl.Rows(0).Item(0)
            Else
                'hint = "no such ID"
                a = 77777
            End If
        Catch ex1 As Exception
            Dim sqlcommand As New SqlCommand("SELECT Worker_ID FROM warehouse_worker WHERE Wname = @name", cs)
            sqlcommand.Parameters.Add("@name", SqlDbType.NChar).Value = name
            Dim dbadptor As New SqlDataAdapter(sqlcommand)
            Dim tbl As New DataTable()
            dbadptor.Fill(tbl)
            If tbl.Rows.Count = 1 Then
                a = tbl.Rows(0).Item(0)
            ElseIf tbl.Rows.Count = 0 Then
                'hint = "no such name"
                a = 88888
            Else
                'hint = "two or more have this name, must enter ID"
                a = 99999
            End If
        End Try
        Return a
    End Function

    Declare Function MF_Halt Lib "MF1.dll" () As Integer
    Declare Function ControlLED Lib "MF1.dll" (ByVal arg1 As Byte, ByVal arg2 As Byte, ByRef arg3 As Byte) As Integer
    Declare Function ControlBuzzer Lib "MF1.dll" (ByVal arg1 As Byte, ByVal arg2 As Byte, ByRef arg3 As Byte) As Integer
    Declare Function MF_Getsnr Lib "MF1.dll" (ByVal arg1 As Byte, ByVal arg2 As Byte, ByRef arg3 As Byte, ByRef arg4 As Byte) As Integer
    Declare Function MF_Read Lib "MF1.dll" (ByVal arg1 As Byte, ByVal arg2 As Byte, ByVal arg3 As Byte, ByRef arg4 As Byte, ByRef arg5 As Byte) As Integer
    Declare Function MF_Write Lib "MF1.dll" (ByVal arg1 As Byte, ByVal arg2 As Byte, ByVal arg3 As Byte, ByRef arg4 As Byte, ByRef arg5 As Byte) As Integer
    Declare Function MF_InitValue Lib "MF1.dll" (ByVal arg1 As Byte, ByVal arg2 As Byte, ByRef arg3 As Byte, ByRef arg4 As Byte) As Integer
    Declare Function MF_Dec Lib "MF1.dll" (ByVal arg1 As Byte, ByVal arg2 As Byte, ByRef arg3 As Byte, ByRef arg4 As Byte) As Integer
    Declare Function MF_Inc Lib "MF1.dll" (ByVal arg1 As Byte, ByVal arg2 As Byte, ByRef arg3 As Byte, ByRef arg4 As Byte) As Integer

End Module
