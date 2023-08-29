Imports System.Data.SqlClient
Public Class InterviewForm
    Dim pkVar As String
    Private Sub InterviewForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd3 As New SqlCommand("select distinct JobCode from rMatchListTab order by JobCode", Conn)
        Dim D3 As SqlDataReader = Cmd3.ExecuteReader()
        While D3.Read
            ComboBox1.Items.Add(D3(0).ToString)
        End While

        disRecords()
    End Sub

    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        SaveRecord()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub
    Sub SaveRecord()
        If ComboBox2.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If


        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "insert into InterviewMarksTab("
        q2Var = " values("
        q1Var = q1Var & "JobCode" & ","
        q2Var = q2Var & "'" & (ComboBox1.Text) & "',"
        q1Var = q1Var & "iDate" & ","
        q2Var = q2Var & "'" & oDate.Value & "',"
        q1Var = q1Var & "CCode" & ","
        q2Var = q2Var & "'" & Microsoft.VisualBasic.Right(ComboBox2.Text, 4) & "',"
        q1Var = q1Var & "Cname" & ","
        q2Var = q2Var & "'" & ComboBox2.Text & "',"
        q1Var = q1Var & "ED" & ","
        q2Var = q2Var & "" & Val(TextBox2.Text) & ","
        q1Var = q1Var & "Skills" & ","
        q2Var = q2Var & "" & Val(TextBox3.Text) & ","
        q1Var = q1Var & "GK" & ","
        q2Var = q2Var & "" & Val(TextBox4.Text) & ","
        q1Var = q1Var & "Oral" & ","
        q2Var = q2Var & "" & Val(TextBox5.Text) & ","
        q1Var = q1Var & "TotalScore" & ","
        q2Var = q2Var & "" & Val(TextBox6.Text) & ","
        q1Var = q1Var & "Selected" & ")"
        q2Var = q2Var & "'')"

        'MsgBox(q1Var & q2Var)
        Dim cmd1 As New SqlCommand(q1Var & q2Var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()

    End Sub
    Sub disRecords()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select cCode,cName,JobCode From InterviewMarksTab order by cCode", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkVar = DG1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from InterviewMarksTab where cCode='" & pkVar & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            ComboBox1.Text = D1(0).ToString
            oDate.Value = D1(1)
            ComboBox2.Text = D1(2).ToString
            TextBox2.Text = D1(3).ToString
            TextBox3.Text = D1(4).ToString
            TextBox4.Text = D1(5).ToString
            TextBox5.Text = D1(6).ToString
            TextBox6.Text = D1(7).ToString
            
            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = True
            ButDelete.Enabled = True
            butPrint.Enabled = True
        Else
            ComboBox2.Text = ""
            TextBox2.Text = ""
            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = False
            ButDelete.Enabled = False


        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()

    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub

    Private Sub butModify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles butModify.Click
        If vbNo = MsgBox("Are you sure you want modify this record", MsgBoxStyle.YesNo, "Modify") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from InterviewMarksTab where cCode='" & pkVar & "'", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        SaveRecord()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub

    Private Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        If vbNo = MsgBox("Are you sure you want delete this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from InterviewMarksTab where cCode=1" & pkVar & "1", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub

    Private Sub butNew_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles butNew.Click
        ClearTxtControls(Me, 1)

        TextBox2.Focus()
        butNew.Enabled = False
        butSave.Enabled = True
        butModify.Enabled = False
        ButDelete.Enabled = False
    End Sub

    Private Sub butList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butList.Click
        disRecords()
    End Sub

   

    
    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd3 As New SqlCommand("select cName from rMatchListTab where jobcode='" & ComboBox1.Text & "' order by cName", Conn)
        Dim D3 As SqlDataReader = Cmd3.ExecuteReader()
        While D3.Read
            ComboBox2.Items.Add(D3(0).ToString)
        End While

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox6.Text = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox6.Text = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox6.Text = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        TextBox6.Text = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
    End Sub
End Class
