Imports System.Data.SqlClient
Public Class JobOpeningsForm
    Dim pkVar As String
    Private Sub JobOpeningsForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        oDate.Value = Today()

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select DesignationName from DesignationDetTab order by DesignationName", Conn)
        Dim D0 As SqlDataReader = Cmd0.ExecuteReader()
        While D0.Read
            ComboBox1.Items.Add(D0(0).ToString)
        End While
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select DepartmentName from DepartmentDetTab order by DepartmentName", Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        While D1.Read
            ComboBox2.Items.Add(D1(0).ToString)
        End While
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd2 As New SqlCommand("select CourseName from CourseDetTab order by CourseName", Conn)
        Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
        While D2.Read
            ComboBox3.Items.Add(D2(0).ToString)
        End While
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd3 As New SqlCommand("select CourseName from AddCourseDetTab order by CourseName", Conn)
        Dim D3 As SqlDataReader = Cmd3.ExecuteReader()
        While D3.Read
            ComboBox4.Items.Add(D3(0).ToString)
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
        If TextBox1.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If


        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "insert into JobOpeningTab("
        q2Var = " values("
        q1Var = q1Var & "JobCode" & ","
        q2Var = q2Var & "'" & TextBox1.Text & "',"
        q1Var = q1Var & "jDate" & ","
        q2Var = q2Var & "'" & oDate.Value & "',"
        q1Var = q1Var & "DesignationName" & ","
        q2Var = q2Var & "'" & ComboBox1.Text & "',"
        q1Var = q1Var & "DepartmentName" & ","
        q2Var = q2Var & "'" & ComboBox2.Text & "',"
        q1Var = q1Var & "tJobs" & ","
        q2Var = q2Var & "" & Val(TextBox2.Text) & ","
        q1Var = q1Var & "eCourseName" & ","
        q2Var = q2Var & "'" & ComboBox3.Text & "',"
        q1Var = q1Var & "aCourseName" & ","
        q2Var = q2Var & "'" & ComboBox4.Text & "',"
        q1Var = q1Var & "eYears" & ")"
        q2Var = q2Var & "" & Val(TextBox3.Text) & ")"

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
        Dim adp As New SqlDataAdapter("Select JobCode,DesignationName From JobOpeningTab order by JobCode", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkVar = DG1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from JobOpeningTab where JobCode='" & pkVar & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(0).ToString
            oDate.Value = D1(1)
            ComboBox1.Text = D1(2).ToString
            ComboBox2.Text = D1(3).ToString
            TextBox2.Text = D1(4).ToString
            ComboBox3.Text = D1(5).ToString
            ComboBox4.Text = D1(6).ToString
            TextBox3.Text = D1(7).ToString
            
            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = True
            ButDelete.Enabled = True
            butPrint.Enabled = True
        Else
            TextBox1.Text = ""
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
        If vbNo = MsgBox("Are you sure you want modify this record", MsgBoxStyle.YesNo, "Modify Record") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from JobOpeningTab where JobCode='" & pkVar & "'", Conn)
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
        Dim cmd1 As New SqlCommand("Delete from JobOpeningTab where JobCode='" & pkVar & "'", Conn)
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
        
        TextBox1.Focus()
        butNew.Enabled = False
        butSave.Enabled = True
        butModify.Enabled = False
        ButDelete.Enabled = False
    End Sub

    Private Sub butList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butList.Click
        disRecords()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = UCase(TextBox1.Text)
    End Sub

   

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long

        YPos += 50
        XPos = 10
        Dim MyFont As New Font("Arial", 20)
        e.Graphics.DrawString("HR Management", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        MyFont = New Font("Arial", 12)
        XPos = 10
        e.Graphics.DrawString("Job Openings Details", MyFont, Brushes.Black, XPos, YPos)
        YPos += 20
        XPos = 10
        e.Graphics.DrawString("________________________________________________", MyFont, Brushes.Black, XPos, YPos)

        XPos = 10
        e.Graphics.DrawString("Job Code", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 200
        e.Graphics.DrawString(TextBox1.Text, MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        e.Graphics.DrawString("Date", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 200
        e.Graphics.DrawString(oDate.Value, MyFont, Brushes.Black, XPos, YPos)

        YPos += 50
        XPos = 10
        e.Graphics.DrawString("Designation Name", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 200
        e.Graphics.DrawString(ComboBox1.Text, MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        e.Graphics.DrawString("Department Name", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 200
        e.Graphics.DrawString(ComboBox2.Text, MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        e.Graphics.DrawString("Total Jobs", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 200
        e.Graphics.DrawString(TextBox2.Text, MyFont, Brushes.Black, XPos, YPos)




        YPos += 25
        XPos = 10
        e.Graphics.DrawString("________________________________________________", MyFont, Brushes.Black, XPos, YPos)

    End Sub
    Private Sub PP1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles PP1.Disposed
        PP1.Close()
        PrintDocument1.Dispose()
    End Sub

    Private Sub butPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles butPrint.Click
        PP1.ShowDialog()
    End Sub
End Class
