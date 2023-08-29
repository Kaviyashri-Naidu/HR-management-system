Imports System.Data.SqlClient
Public Class ResumeEntry2Form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "update ResumeTab set "
        q1Var = q1Var & "dob ='" & dDate.Value & "',"
        q1Var = q1Var & "Gender ='" & ComboBox1.Text & "',"
        q1Var = q1Var & "Nationality ='" & ComboBox2.Text & "',"
        q1Var = q1Var & "Lan1 ='" & ComboBox3.Text & "',"
        q1Var = q1Var & "Lan2 ='" & ComboBox4.Text & "'"
        q1Var = q1Var & " where ccode =" & cCodeVar & ""
        'MsgBox(q1Var )
        Dim cmd1 As New SqlCommand(q1Var, Conn)
        cmd1.ExecuteNonQuery()
       


        ResumeEntry3Form.MdiParent = MDIParent1
        ResumeEntry3Form.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from ResumeTab where cCode=" & cCodeVar & "", Conn)
        cmd1.ExecuteNonQuery()
        Me.Close()

    End Sub
End Class