Imports System.Data.SqlClient
Public Class ResumeEntry3Form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "update ResumeTab set "
        q1Var = q1Var & "edcourseName ='" & ComboBox1.Text & "',"
        q1Var = q1Var & "BranchName ='" & ComboBox2.Text & "',"
        q1Var = q1Var & "AddCourseName ='" & ComboBox3.Text & "',"
        q1Var = q1Var & "eYears =" & Val(TextBox1.Text) & ","
        q1Var = q1Var & "ExDetails ='" & TextBox2.Text & "'"
        q1Var = q1Var & " where ccode =" & cCodeVar & ""
        'MsgBox(q1Var )
        Dim cmd1 As New SqlCommand(q1Var, Conn)
        cmd1.ExecuteNonQuery()


        ResumeEntry1Form.MdiParent = MDIParent1
        ResumeEntry1Form.Show()

        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from ResumeTab where cCode=" & cCodeVar & "", Conn)
        cmd1.ExecuteNonQuery()
        Me.Close()

    End Sub

    Private Sub ResumeEntry3Form_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click


    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select BranchName from BranchDetTab where coursename='" & ComboBox1.Text & "' order by BranchName", Conn)
        Dim D0 As SqlDataReader = Cmd0.ExecuteReader()
        While D0.Read
            ComboBox2.Items.Add(D0(0).ToString)
        End While

    End Sub

    Private Sub ResumeEntry3Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ClearTxtControls(Me, 1)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd2 As New SqlCommand("select CourseName from CourseDetTab order by CourseName", Conn)
        Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
        While D2.Read
            ComboBox1.Items.Add(D2(0).ToString)
        End While

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd3 As New SqlCommand("select CourseName from AddCourseDetTab order by CourseName", Conn)
        Dim D3 As SqlDataReader = Cmd3.ExecuteReader()
        While D3.Read
            ComboBox3.Items.Add(D3(0).ToString)
        End While
    End Sub
End Class