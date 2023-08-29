Imports System.Data.SqlClient
Public Class ResumeEntry1Form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Please enter the Candidate Name")
            Exit Sub
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select max(ccode) from ResumeTab", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            cCodeVar = Val(D1(0).ToString) + 1
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "insert into ResumeTab("
        q2Var = " values("
        q1Var = q1Var & "ccode" & ","
        q2Var = q2Var & "" & cCodeVar & ","
        q1Var = q1Var & "cName" & ","
        q2Var = q2Var & "'" & TextBox1.Text & "     " & cCodeVar & "',"
        q1Var = q1Var & "pName" & ","
        q2Var = q2Var & "'" & TextBox2.Text & "',"
        q1Var = q1Var & "cAddress" & ","
        q2Var = q2Var & "'" & TextBox3.Text & "',"
        q1Var = q1Var & "MobileNo" & ","
        q2Var = q2Var & "'" & TextBox4.Text & "',"
        q1Var = q1Var & "email" & ")"
        q2Var = q2Var & "'" & TextBox5.Text & "')"

        'MsgBox(q1Var & q2Var)
        Dim cmd1 As New SqlCommand(q1Var & q2Var, Conn)
        cmd1.ExecuteNonQuery()
        ResumeEntry2Form.MdiParent = MDIParent1
        ResumeEntry2Form.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ResumeEntry1Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ClearTxtControls(Me, 1)
    End Sub

    Private Sub ResumeEntry1Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ClearTxtControls(Me, 1)
    End Sub
End Class