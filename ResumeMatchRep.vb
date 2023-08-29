Imports System.Data.SqlClient
Public Class ResumeMatchRep

    Private Sub ResumeMatchRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select jobcode,DesignationName,DepartmentName,tJobs,ecourseName,eyears From JobopeningTab order by jdate,jobcode", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long
        YPos = 50
        Dim MyFont As New Font("Arial", 18)
        XPos = 10
        e.Graphics.DrawString("HR Management", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("", MyFont, Brushes.Black, XPos, YPos)
        YPos += 100
        XPos = 10
        e.Graphics.DrawString("Job match cadidate list", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("Candidate Name", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 50
        e.Graphics.DrawString("Mobile No", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Email Id", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("DOB", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Gender", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("First Lan ", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150



        YPos += 25
        For Each r As DataGridViewRow In DG2.Rows
            XPos = 10
            e.Graphics.DrawString(r.Cells(0).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 50
            e.Graphics.DrawString(r.Cells(1).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(2).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(Format(r.Cells(3).Value, "dd-MMM-yyyy"), MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(4).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(5).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            YPos += 25
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PP1.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select cName,MobileNo,eMail,Dob,Gender,Lan1 From ResumeTab where edcoursename='" & DG1.CurrentRow.Cells(4).Value & "' and eyears >=" & DG1.CurrentRow.Cells(5).Value & " order by ccode", Conn)
        adp.Fill(DS1)
        DG2.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd2 As New SqlCommand("Delete from rMatchListTab where jobcode='" & DG1.CurrentRow.Cells(0).Value & "'", Conn)
        cmd2.ExecuteNonQuery()

        For Each r As DataGridViewRow In DG2.Rows
            If Not r.Cells(0).Value = "" Then
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                q1Var = "insert into rMatchListTab("
                q2Var = " values("
                q1Var = q1Var & "Jobcode" & ","
                q2Var = q2Var & "'" & DG1.CurrentRow.Cells(0).Value & "',"
                q1Var = q1Var & "cName" & ")"
                q2Var = q2Var & "'" & r.Cells(0).Value & "')"
                Dim cmd1 As New SqlCommand(q1Var & q2Var, Conn)
                cmd1.ExecuteNonQuery()
            End If
        Next
        MsgBox("List is saved please proceed.")
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick

    End Sub
End Class